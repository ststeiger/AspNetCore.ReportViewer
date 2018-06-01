namespace AspNetCore.Report
{
	/// <summary>
	/// SSRS Report Viewer 
	/// </summary>
	public class ReportViewer
	{
		/// <summary>
		/// MSSQL Server 2012
		/// </summary>
		private const int SuportExportVersion = 11;

		private static System.Text.RegularExpressions.Regex VersionRegex;

		private static System.Collections.Concurrent.ConcurrentDictionary<string, System.Version> Versions;

		/// <summary>
		///
		/// </summary>
		private const string ExecutionPath = "/ReportExecution2005.asmx";

		private static AspNetCore.Report.ReportExecutionService.ReportExecutionServiceSoapClient client;

		private static readonly string TOOL_BAR_STRING;

		internal ReportSettings ReportSettings
		{
			get;
			set;
		}

		private AspNetCore.Report.ReportExecutionService.ReportExecutionServiceSoapClient ReportClient
		{
			get
			{
				if (ReportViewer.client == null)
				{
					ReportViewer.client = new AspNetCore.Report.ReportExecutionService.ReportExecutionServiceSoapClient(this.CreateBinding(), new System.ServiceModel.EndpointAddress(string.Format("{0}{1}", this.ReportSettings.ReportServer, "/ReportExecution2005.asmx")));
					ReportViewer.client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
					ReportViewer.client.ClientCredentials.Windows.ClientCredential = (System.Net.NetworkCredential)this.ReportSettings.Credential;
					ReportViewer.client.ExecutionHeader = new AspNetCore.Report.ReportExecutionService.ExecutionHeader();
					ReportViewer.client.TrustedUserHeader = new AspNetCore.Report.ReportExecutionService.TrustedUserHeader();
					ReportViewer.client.Endpoint.EndpointBehaviors.Add(new ReportEndpointBehavior(ReportViewer.client));
				}
				return ReportViewer.client;
			}
		}

		/// <summary>
		/// init the report viewer, e.g. set report server,set certificate
		/// </summary>
		/// <param name="settings"></param>
		public ReportViewer(ReportSettings settings)
		{
			this.ReportSettings = settings;
			if (this.CheckSettings(out ReportException ex))
			{
				return;
			}
			throw ex;
		}

		/// <summary>
		/// execute report by use <see cref="T:AspNetCore.Report.ReportRequest" /> settings
		/// </summary>
		/// <param name="request">the request settings for execute report</param>
		/// <returns></returns>
		public ReportResponse Execute(ReportRequest request)
		{
			switch (request.ExecuteType)
			{
			case ReportExecuteType.Display:
				return this.Display(request);
			case ReportExecuteType.Export:
				return this.Export(request);
			case ReportExecuteType.FindString:
				return this.FindString(request);
			case ReportExecuteType.Toggle:
				return this.Toggle(request);
			case ReportExecuteType.Print:
				request.RenderType = ReportRenderType.WordOpenXml;
				return this.Export(request);
			default:
				return new ReportResponse
				{
					Status = 1,
					Message = "ExecuteType not provide or incorrect."
				};
			}
		}

		protected ReportResponse Display(ReportRequest request)
		{
			ReportResponse response = new ReportResponse();
			try
			{
				ReportExecuteResult result = new ReportExecuteResult();
				this.LoadReport(request, ref result);
				this.Render(request, ref result, null);
				this.GetPageNumber(request, ref result);
				response.Data = this.SetData(result, false);
			}
			catch (System.Exception ex)
			{
				response.Status = 1;
				response.Message = ex.Message;
			}
			return response;
		}

		protected ReportData SetData(ReportExecuteResult result, bool appendStream = true)
		{
			ReportData data = new ReportData
			{
				SessionId = result.SessionId,
				Extension = result.Extension,
				MimeType = result.MimeType,
				PageCount = result.PageCount,
				PageIndex = result.PageIndex
			};
			if (ReportViewer.Versions.TryGetValue(this.ReportSettings.ReportServer, out System.Version version))
			{
				data.Version = version;
			}
			if (appendStream && result.Stream != null)
			{
				data.Stream = result.Stream;
			}
			if (!string.IsNullOrEmpty(result.Contents))
			{
				data.Contents = this.GetContent(result.Contents, this.ReportSettings.ShowToolBar);
			}
			return data;
		}

		protected ReportResponse Export(ReportRequest request)
		{
			ReportResponse response = new ReportResponse();
			try
			{
				ReportExecuteResult result = new ReportExecuteResult();
				this.LoadReport(request, ref result);
				this.Render(request, ref result, null);
				response.Data = this.SetData(result, true);
			}
			catch (System.Exception ex)
			{
				response.Status = 1;
				response.Message = ex.Message;
			}
			return response;
		}

		protected ReportResponse FindString(ReportRequest request)
		{
			ReportResponse response2 = new ReportResponse();
			if (string.IsNullOrEmpty(request.FindString))
			{
				response2.Status = 2;
				response2.Message = "Search value can not be empty.";
				return response2;
			}
			try
			{
				ReportExecuteResult result = new ReportExecuteResult();
				this.LoadReport(request, ref result);
				this.Render(request, ref result, null);
				this.GetPageNumber(request, ref result);
				AspNetCore.Report.ReportExecutionService.FindStringRequest request2 = new AspNetCore.Report.ReportExecutionService.FindStringRequest
				{
					FindValue = request.FindString,
					StartPage = request.PageIndex,
					EndPage = result.PageCount
				};
				System.Runtime.CompilerServices.TaskAwaiter<AspNetCore.Report.ReportExecutionService.FindStringResponse> awaiter = this.ReportClient.FindStringAsync(request2).GetAwaiter();
				AspNetCore.Report.ReportExecutionService.FindStringResponse response = awaiter.GetResult();
				if (response.PageNumber > 0)
				{
					ReportExecuteResult reportExecuteResult = result;
					int num2 = reportExecuteResult.PageIndex = (request.PageIndex = response.PageNumber);
				}
				else
				{
					if (request.PageIndex > 1)
					{
						request2.StartPage = 1;
					}
					awaiter = this.ReportClient.FindStringAsync(request2).GetAwaiter();
					response = awaiter.GetResult();
					if (response.PageNumber < 1)
					{
						response2.Status = 23;
						response2.Message = "The Find Text not found in the report";
						return response2;
					}
					ReportExecuteResult reportExecuteResult2 = result;
					int num2 = reportExecuteResult2.PageIndex = (request.PageIndex = response.PageNumber);
				}
				this.Render(request, ref result, null);
				response2.Data = this.SetData(result, true);
				response2.Data.Contents = this.GetContent(result.Stream, this.ReportSettings.ShowToolBar);
			}
			catch (System.Exception ex)
			{
				response2.Status = 1;
				response2.Message = ex.Message;
			}
			return response2;
		}

		protected ReportResponse Toggle(ReportRequest request)
		{
			ReportResponse response = new ReportResponse();
			if (string.IsNullOrEmpty(request.ToggleId))
			{
				response.Status = 2;
				response.Message = "The ToggleId can not be empty.";
				return response;
			}
			try
			{
				ReportExecuteResult result = new ReportExecuteResult();
				this.LoadReport(request, ref result);
				AspNetCore.Report.ReportExecutionService.ToggleItemResponse s = this.ReportClient.ToggleItemAsync(new AspNetCore.Report.ReportExecutionService.ToggleItemRequest(request.ToggleId)).GetAwaiter().GetResult();
				if (s.Found)
				{
					this.Render(request, ref result, null);
					this.GetPageNumber(request, ref result);
					response.Data = this.SetData(result, true);
					response.Data.Contents = this.GetContent(result.Stream, this.ReportSettings.ShowToolBar);
				}
				else
				{
					response.Status = 5;
					response.Message = "Toggle: not found item";
				}
			}
			catch (System.Exception ex)
			{
				response.Status = 1;
				response.Message = "Toggle:" + ex.Message;
			}
			return response;
		}

		protected string GetContent(byte[] bytes, bool showToolBar)
		{
			string content = System.Text.Encoding.UTF8.GetString(bytes);
			return this.GetContent(content, showToolBar);
		}

		protected string GetContent(string content, bool showToolBar)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("(<style [^>]+>[^<]+?</style>)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
			System.Text.RegularExpressions.Match i = reg.Match(content);
			if (i.Success)
			{
				sb.AppendLine(i.Result("$1"));
			}
			System.Text.RegularExpressions.Regex reg2 = new System.Text.RegularExpressions.Regex("<body [^>]+>([\\w\\W]*?)</body>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
			i = reg2.Match(content);
			if (i.Success)
			{
				if (this.ReportSettings.ShowToolBar)
				{
					sb.AppendLine(ReportViewer.TOOL_BAR_STRING);
					content = ReportViewer.TOOL_BAR_STRING + content;
				}
				sb.AppendLine(i.Result("$1"));
			}
			return sb.ToString();
		}

		/// <summary>
		/// step 1
		/// </summary>
		protected void LoadReport(ReportRequest request, ref ReportExecuteResult result)
		{
			if (string.IsNullOrEmpty(request.Path))
			{
				throw new ReportException("Please set ReportPath to execute.");
			}
			try
			{
				if (!string.IsNullOrEmpty(request.SessionId))
				{
					try
					{
						if (request.Reset)
						{
							AspNetCore.Report.ReportExecutionService.ResetExecutionResponse r = this.ReportClient.ResetExecutionAsync(new AspNetCore.Report.ReportExecutionService.ResetExecutionRequest()).GetAwaiter().GetResult();
							result.SessionId = r.executionInfo.ExecutionID;
						}
						this.ReportClient.ExecutionHeader.ExecutionID = request.SessionId;
						AspNetCore.Report.ReportExecutionService.GetExecutionInfoResponse rr = this.ReportClient.GetExecutionInfoAsync(new AspNetCore.Report.ReportExecutionService.GetExecutionInfoRequest()).GetAwaiter().GetResult();
					}
					catch
					{
						request.SessionId = null;
					}
				}
				if (string.IsNullOrEmpty(request.SessionId))
				{
					AspNetCore.Report.ReportExecutionService.LoadReportRequest request2 = new AspNetCore.Report.ReportExecutionService.LoadReportRequest(request.Path, null);
					AspNetCore.Report.ReportExecutionService.LoadReportResponse response = this.ReportClient.LoadReportAsync(request2).GetAwaiter().GetResult();
					try
					{
						System.Text.RegularExpressions.Match match = ReportViewer.VersionRegex.Match(response.ServerInfoHeader.ReportServerVersion);
						if (match.Success)
						{
							ReportViewer.Versions.TryAdd(this.ReportSettings.ReportServer, System.Version.Parse(match.Result("$1")));
						}
					}
					catch
					{
					}
					result.ParametersRequired = response.executionInfo.ParametersRequired;
					System.Collections.Generic.Dictionary<string, string> dict = new System.Collections.Generic.Dictionary<string, string>(response.executionInfo.Parameters.Length);
					if (response.executionInfo.Parameters.Length != 0)
					{
						AspNetCore.Report.ReportExecutionService.ReportParameter[] parameters = response.executionInfo.Parameters;
						foreach (AspNetCore.Report.ReportExecutionService.ReportParameter p in parameters)
						{
							if (p.DefaultValues != null && p.DefaultValues.Length != 0)
							{
								dict[p.Name] = System.Linq.Enumerable.SingleOrDefault(p.DefaultValues);
							}
							if (request.Parameters.ContainsKey(p.Name))
							{
								dict[p.Name] = request.Parameters[p.Name];
							}
						}
					}
					request.Parameters = dict;
					ReportExecuteResult obj3 = result;
					string text2 = obj3.SessionId = (request.SessionId = response.executionInfo.ExecutionID);
					this.SetParameters(request, result);
				}
			}
			catch (System.Exception ex)
			{
				throw new ReportException("LoadReport error: " + ex.Message, ex);
			}
		}

		/// <summary>
		/// step 2.
		/// </summary>
		protected void SetParameters(ReportRequest rRequest, ReportExecuteResult result)
		{
			if (result.ParametersRequired && rRequest.Parameters.Count == 0)
			{
				throw new ReportException("The report parameters is required.");
			}
			try
			{
				AspNetCore.Report.ReportExecutionService.ParameterValue[] paramenters = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select(rRequest.Parameters, (System.Collections.Generic.KeyValuePair<string, string> t) => new AspNetCore.Report.ReportExecutionService.ParameterValue
				{
					Name = t.Key,
					Value = t.Value
				}));
				AspNetCore.Report.ReportExecutionService.SetExecutionParametersRequest request = new AspNetCore.Report.ReportExecutionService.SetExecutionParametersRequest(paramenters, "en-us");
				AspNetCore.Report.ReportExecutionService.SetExecutionParametersResponse response = this.ReportClient.SetExecutionParametersAsync(request).GetAwaiter().GetResult();
				string text2 = result.SessionId = (rRequest.SessionId = response.executionInfo.ExecutionID);
			}
			catch (System.Exception ex)
			{
				throw new ReportException("SetParameters error: " + ex.Message, ex);
			}
		}

		/// <summary>
		/// step 3.
		/// </summary>
		/// <param name="result"></param>
		protected void Render(ReportRequest rRequest, ref ReportExecuteResult result, string findString = null)
		{
			try
			{
				AspNetCore.Report.DeviceInfos.DeviceInfo deviceInfo = this.GenerateDeviceInfo(rRequest);
				ReportViewer.Versions.TryGetValue(this.ReportSettings.ReportServer, out System.Version version);
				string format;
				ReportRenderType reportRenderType;
				switch (rRequest.RenderType)
				{
				case ReportRenderType.Html4_0:
					format = "Html4.0";
					break;
				case ReportRenderType.ExcelOpenXml:
					if (version.Major < 11)
					{
						reportRenderType = ReportRenderType.Excel;
						format = reportRenderType.ToString();
					}
					else
					{
						reportRenderType = ReportRenderType.ExcelOpenXml;
						format = reportRenderType.ToString();
					}
					break;
				case ReportRenderType.WordOpenXml:
					if (version.Major < 11)
					{
						reportRenderType = ReportRenderType.Word;
						format = reportRenderType.ToString();
					}
					else
					{
						reportRenderType = ReportRenderType.WordOpenXml;
						format = reportRenderType.ToString();
					}
					break;
				default:
					reportRenderType = rRequest.RenderType;
					format = reportRenderType.ToString();
					break;
				}
				string strDeviceInfo = deviceInfo.ToString();
				AspNetCore.Report.ReportExecutionService.Render2Request request = new AspNetCore.Report.ReportExecutionService.Render2Request(format, strDeviceInfo, AspNetCore.Report.ReportExecutionService.PageCountMode.Actual);
				AspNetCore.Report.ReportExecutionService.Render2Response response = this.ReportClient.Render2Async(request).GetAwaiter().GetResult();
				if (rRequest.RenderType == ReportRenderType.Html4_0 || rRequest.RenderType == ReportRenderType.Html5)
				{
					string content = System.Text.Encoding.UTF8.GetString(response.Result);
					System.Text.StringBuilder sb = new System.Text.StringBuilder(content);
					System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("(<img [^>]*? src=\"([^\"]+&rs%3AImageID=([^\"']+))\")", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
					System.Text.RegularExpressions.Match matchs = reg.Match(content);
					while (matchs.Success)
					{
						string a = matchs.Result("$1");
						string b = matchs.Result("$2");
						string c = matchs.Result("$3");
						AspNetCore.Report.ReportExecutionService.RenderStreamResponse cc = this.ReportClient.RenderStreamAsync(new AspNetCore.Report.ReportExecutionService.RenderStreamRequest(format, c, strDeviceInfo)).GetAwaiter().GetResult();
						string img = $"data:{cc.MimeType};base64,{System.Convert.ToBase64String(cc.Result)}";
						string aa = a.Replace(b, img);
						sb.Replace(a, aa);
						matchs = matchs.NextMatch();
					}
					result.Contents = sb.ToString();
				}
				result.Stream = response.Result;
				result.Encoding = response.Encoding;
				result.Extension = response.Extension;
				result.MimeType = response.MimeType;
			}
			catch (System.Exception ex)
			{
				throw new ReportException("Render error: " + ex.Message, ex);
			}
		}

		/// <summary>
		/// step 4
		/// </summary>
		/// <param name="result"></param>
		protected void GetPageNumber(ReportRequest rRequest, ref ReportExecuteResult result)
		{
			try
			{
				ReportViewer.Versions.TryGetValue(this.ReportSettings.ReportServer, out System.Version version);
				if (version.Major <= 11)
				{
					AspNetCore.Report.ReportExecutionService.GetExecutionInfo2Request request2 = new AspNetCore.Report.ReportExecutionService.GetExecutionInfo2Request();
					AspNetCore.Report.ReportExecutionService.GetExecutionInfo2Response response2 = this.ReportClient.GetExecutionInfo2Async(request2).GetAwaiter().GetResult();
					result.PageCount = response2.executionInfo.NumPages;
					result.PageIndex = rRequest.PageIndex;
					ReportExecuteResult obj = result;
					AspNetCore.Report.ReportExecutionService.ExecutionHeader executionHeader = this.ReportClient.ExecutionHeader;
					string text = executionHeader.ExecutionID = response2.executionInfo.ExecutionID;
					string text4 = obj.SessionId = (rRequest.SessionId = text);
				}
				else
				{
					AspNetCore.Report.ReportExecutionService.GetExecutionInfo3Request request = new AspNetCore.Report.ReportExecutionService.GetExecutionInfo3Request();
					AspNetCore.Report.ReportExecutionService.GetExecutionInfo3Response response = this.ReportClient.GetExecutionInfo3Async(request).GetAwaiter().GetResult();
					result.PageCount = response.executionInfo.NumPages;
					result.PageIndex = rRequest.PageIndex;
					ReportExecuteResult obj2 = result;
					AspNetCore.Report.ReportExecutionService.ExecutionHeader executionHeader2 = this.ReportClient.ExecutionHeader;
					string text = executionHeader2.ExecutionID = response.executionInfo.ExecutionID;
					string text4 = obj2.SessionId = (rRequest.SessionId = text);
				}
			}
			catch (System.Exception ex)
			{
				throw new ReportException("GetPageNumber error: " + ex.Message, ex);
			}
		}

		private AspNetCore.Report.DeviceInfos.DeviceInfo GenerateDeviceInfo(ReportRequest rRequest)
		{
			if (rRequest.ExecuteType == ReportExecuteType.Export)
			{
				return new AspNetCore.Report.DeviceInfos.DeviceInfo
				{
					Toolbar = false
				};
			}
			AspNetCore.Report.DeviceInfos.HtmlDeviceInfo deviceInfo = new AspNetCore.Report.DeviceInfos.HtmlDeviceInfo();
			deviceInfo.HTMLFragment = false;
			if (rRequest.PageIndex < 1)
			{
				rRequest.PageIndex = 1;
			}
			deviceInfo.Section = rRequest.PageIndex;
			deviceInfo.Toolbar = false;
			if (!string.IsNullOrEmpty(rRequest.FindString))
			{
				deviceInfo.FindString = rRequest.FindString;
				deviceInfo.Toolbar = null;
			}
			if (!string.IsNullOrEmpty(this.ReportSettings.UserAgent))
			{
				deviceInfo.UserAgent = this.ReportSettings.UserAgent;
			}
			return deviceInfo;
		}

		protected System.ServiceModel.Channels.Binding CreateBinding()
		{
			System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
			System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
			textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap11, System.ServiceModel.Channels.AddressingVersion.None);
			result.Elements.Add(textBindingElement);
			if (this.ReportSettings.IsSSL)
			{
				System.ServiceModel.Channels.HttpsTransportBindingElement httpBindingElement2 = new System.ServiceModel.Channels.HttpsTransportBindingElement();
				httpBindingElement2.AllowCookies = true;
				httpBindingElement2.MaxBufferSize = 2147483647;
				httpBindingElement2.MaxReceivedMessageSize = 2147483647L;
				httpBindingElement2.AuthenticationScheme = System.Net.AuthenticationSchemes.Ntlm;
				result.Elements.Add(httpBindingElement2);
			}
			else
			{
				System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
				httpBindingElement.AllowCookies = true;
				httpBindingElement.MaxBufferSize = 2147483647;
				httpBindingElement.MaxReceivedMessageSize = 2147483647L;
				httpBindingElement.AuthenticationScheme = System.Net.AuthenticationSchemes.Ntlm;
				result.Elements.Add(httpBindingElement);
			}
			return result;
		}

		private bool CheckSettings(out ReportException ex)
		{
			ex = new ReportException();
			if (string.IsNullOrEmpty(this.ReportSettings.ReportServer))
			{
				ex = new ReportException("Please set ReportServer.");
				return false;
			}
			if (!System.Uri.IsWellFormedUriString(this.ReportSettings.ReportServer, System.UriKind.Absolute))
			{
				ex = new ReportException("Please check whether the ReportServer is correct.");
				return false;
			}
			return true;
		}

		static ReportViewer()
		{
			ReportViewer.VersionRegex = new System.Text.RegularExpressions.Regex("([\\d\\.]+)$");
			ReportViewer.Versions = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Version>(new StringCompare());
			switch (System.Globalization.CultureInfo.CurrentCulture.Name)
			{
			case "zh":
			case "zh-CN":
			case "zh-Hans":
			case "zh-Hans-HK":
			case "zh-Hans-MO":
			case "zh-Hant":
			case "zh-HK":
			case "zh-MO":
			case "zh-TW":
			case "zh-SG":
				ReportViewer.TOOL_BAR_STRING = "<table id='ssrs_toolbar'><tr><td class='small-td'><button type='button' title='首页' id='ssrs_first'></button></td><td class='small-td'><button type='button' title='上一页' id='ssrs_prev'></button></td><td style='width:100px;'><input type='text' value='1' id='ssrs_page' />&nbsp;/&nbsp;<span id='ssrs_pageNum'>1</span></td><td class='small-td'><button type='button' title='下一页' id='ssrs_next'></button></td><td class='small-td'><button type='button' title='尾页' id='ssrs_last'></button></td><td class='ssrs_h'></td><td class='small-td'><button type='button' title='刷新' id='ssrs_refresh'></button></td><td class='ssrs_h'></td><td class='small-td'><button type='button' title='导出' id='ssrs_export'></button><div><ul class='ssrs_export_list'><li id='__2'>Word文档</li><li id='__4'>Excel表格</li><li id='__6'>PDF文件</li><li id='__7'>图片</li><li id='__9'>CSV文件</li></ul></div></td><td class='ssrs_h'></td><td class='small-td'><button type='button' title='打印' id='ssrs_print'></button></td><td class='ssrs_h'></td><td style='width:160px;'><input type='text' value='' id='ssrs_find_text' autocomplete='off' placeholder='查找' /></td><td class='small-td showtext'><button type='button' id='ssrs_find_btn' title='在报表中查找'>查找</button><td style='width:5px;'>|</td><td class='small-td showtext'><button type='button' title='查找下一个' id='ssrs_find_next'>下一个</button></td><td class='ssrs_h'></td><td></td></tr></table>";
				break;
			default:
				ReportViewer.TOOL_BAR_STRING = "<table id='ssrs_toolbar'><tr><td class='small-td'><button type='button' title='First Page' id='ssrs_first'></button></td><td class='small-td'><button type='button' title='Previous Page' id='ssrs_prev'></button></td><td style='width:100px;'><input type='text' value='1' id='ssrs_page' />&nbsp;/&nbsp;<span id='ssrs_pageNum'>1</span></td><td class='small-td'><button type='button' title='Next Page' id='ssrs_next'></button></td><td class='small-td'><button type='button' title='Last Page' id='ssrs_last'></button></td><td class='ssrs_h'></td><td class='small-td'><button type='button' title='Refresh Report' id='ssrs_refresh'></button></td><td class='ssrs_h'></td><td class='small-td'><button type='button' title='Export Report' id='ssrs_export'></button><div><ul class='ssrs_export_list'><li id='__2'>Word Document</li><li id='__4'>Excel Sheet</li><li id='__6'>PDF File</li><li id='__7'>Image (TIFF)</li><li id='__9'>CSV File</li></ul></div></td><td class='ssrs_h'></td><td class='small-td'><button type='button' title='Print' id='ssrs_print'></button></td><td class='ssrs_h'></td><td style='width:160px;'><input type='text' value='' id='ssrs_find_text' autocomplete='off' placeholder='Find' /></td><td class='small-td showtext'><button type='button' id='ssrs_find_btn' title='Find In Report'>Find</button><td style='width:5px;'>|</td><td class='small-td showtext'><button type='button' title='Find Next' id='ssrs_find_next'>Next</button></td><td class='ssrs_h'></td><td></td></tr></table>";
				break;
			}
		}
	}
}
