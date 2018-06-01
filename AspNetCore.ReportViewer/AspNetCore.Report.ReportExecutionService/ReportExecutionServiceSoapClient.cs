
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportExecutionService
{
	[DebuggerStepThrough]
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	public class ReportExecutionServiceSoapClient : System.ServiceModel.ClientBase<ReportExecutionServiceSoap>, ReportExecutionServiceSoap
	{
		public enum EndpointConfiguration
		{
			ReportExecutionServiceSoap,
			ReportExecutionServiceSoap12
		}

		public ExecutionHeader ExecutionHeader
		{
			get;
			set;
		}

		public ServerInfoHeader ServerInfoHeader
		{
			get;
			set;
		}

		public TrustedUserHeader TrustedUserHeader
		{
			get;
			set;
		}

		public ReportExecutionServiceSoapClient(EndpointConfiguration endpointConfiguration)
			: base(ReportExecutionServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), ReportExecutionServiceSoapClient.GetEndpointAddress(endpointConfiguration))
		{
			base.Endpoint.Name = endpointConfiguration.ToString();
		}

		public ReportExecutionServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress)
			: base(ReportExecutionServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
		{
			base.Endpoint.Name = endpointConfiguration.ToString();
		}

		public ReportExecutionServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress)
			: base(ReportExecutionServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
		{
			base.Endpoint.Name = endpointConfiguration.ToString();
		}

		public ReportExecutionServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress)
			: base(binding, remoteAddress)
		{
		}

		public System.Threading.Tasks.Task<ListSecureMethodsResponse> ListSecureMethodsAsync(ListSecureMethodsRequest request)
		{
			return base.Channel.ListSecureMethodsAsync(request);
		}

		public System.Threading.Tasks.Task<LoadReportResponse> LoadReportAsync(LoadReportRequest request)
		{
			System.Threading.Tasks.Task<LoadReportResponse> task = base.Channel.LoadReportAsync(request);
			LoadReportResponse response = task.Result;
			this.ServerInfoHeader = response.ServerInfoHeader;
			this.TrustedUserHeader = response.TrustedUserHeader;
			this.ExecutionHeader = response.ExecutionHeader;
			return task;
		}

		public System.Threading.Tasks.Task<LoadReport3Response> LoadReport3Async(LoadReport3Request request)
		{
			System.Threading.Tasks.Task<LoadReport3Response> task = base.Channel.LoadReport3Async(request);
			LoadReport3Response response = task.Result;
			this.ServerInfoHeader = response.ServerInfoHeader;
			this.TrustedUserHeader = response.TrustedUserHeader;
			this.ExecutionHeader = response.ExecutionHeader;
			return task;
		}

		public System.Threading.Tasks.Task<LoadReport2Response> LoadReport2Async(LoadReport2Request request)
		{
			System.Threading.Tasks.Task<LoadReport2Response> task = base.Channel.LoadReport2Async(request);
			LoadReport2Response response = task.Result;
			this.ServerInfoHeader = response.ServerInfoHeader;
			this.TrustedUserHeader = response.TrustedUserHeader;
			this.ExecutionHeader = response.ExecutionHeader;
			return task;
		}

		public System.Threading.Tasks.Task<LoadReportDefinitionResponse> LoadReportDefinitionAsync(LoadReportDefinitionRequest request)
		{
			return base.Channel.LoadReportDefinitionAsync(request);
		}

		public System.Threading.Tasks.Task<LoadReportDefinition2Response> LoadReportDefinition2Async(LoadReportDefinition2Request request)
		{
			return base.Channel.LoadReportDefinition2Async(request);
		}

		public System.Threading.Tasks.Task<LoadReportDefinition3Response> LoadReportDefinition3Async(LoadReportDefinition3Request request)
		{
			return base.Channel.LoadReportDefinition3Async(request);
		}

		public System.Threading.Tasks.Task<SetExecutionCredentialsResponse> SetExecutionCredentialsAsync(SetExecutionCredentialsRequest request)
		{
			return base.Channel.SetExecutionCredentialsAsync(request);
		}

		public System.Threading.Tasks.Task<SetExecutionCredentials2Response> SetExecutionCredentials2Async(SetExecutionCredentials2Request request)
		{
			return base.Channel.SetExecutionCredentials2Async(request);
		}

		public System.Threading.Tasks.Task<SetExecutionCredentials3Response> SetExecutionCredentials3Async(SetExecutionCredentials3Request request)
		{
			return base.Channel.SetExecutionCredentials3Async(request);
		}

		public System.Threading.Tasks.Task<SetExecutionParametersResponse> SetExecutionParametersAsync(SetExecutionParametersRequest request)
		{
			return base.Channel.SetExecutionParametersAsync(request);
		}

		public System.Threading.Tasks.Task<SetExecutionParameters2Response> SetExecutionParameters2Async(SetExecutionParameters2Request request)
		{
			return base.Channel.SetExecutionParameters2Async(request);
		}

		public System.Threading.Tasks.Task<SetExecutionParameters3Response> SetExecutionParameters3Async(SetExecutionParameters3Request request)
		{
			return base.Channel.SetExecutionParameters3Async(request);
		}

		public System.Threading.Tasks.Task<ResetExecutionResponse> ResetExecutionAsync(ResetExecutionRequest request)
		{
			return base.Channel.ResetExecutionAsync(request);
		}

		public System.Threading.Tasks.Task<ResetExecution2Response> ResetExecution2Async(ResetExecution2Request request)
		{
			return base.Channel.ResetExecution2Async(request);
		}

		public System.Threading.Tasks.Task<ResetExecution3Response> ResetExecution3Async(ResetExecution3Request request)
		{
			return base.Channel.ResetExecution3Async(request);
		}

		public System.Threading.Tasks.Task<RenderResponse> RenderAsync(RenderRequest request)
		{
			return base.Channel.RenderAsync(request);
		}

		public System.Threading.Tasks.Task<Render2Response> Render2Async(Render2Request request)
		{
			return base.Channel.Render2Async(request);
		}

		public System.Threading.Tasks.Task<DeliverReportItemResponse> DeliverReportItemAsync(DeliverReportItemRequest request)
		{
			return base.Channel.DeliverReportItemAsync(request);
		}

		public System.Threading.Tasks.Task<RenderStreamResponse> RenderStreamAsync(RenderStreamRequest request)
		{
			return base.Channel.RenderStreamAsync(request);
		}

		public System.Threading.Tasks.Task<GetExecutionInfoResponse> GetExecutionInfoAsync(GetExecutionInfoRequest request)
		{
			return base.Channel.GetExecutionInfoAsync(request);
		}

		public System.Threading.Tasks.Task<GetExecutionInfo2Response> GetExecutionInfo2Async(GetExecutionInfo2Request request)
		{
			return base.Channel.GetExecutionInfo2Async(request);
		}

		public System.Threading.Tasks.Task<GetExecutionInfo3Response> GetExecutionInfo3Async(GetExecutionInfo3Request request)
		{
			System.Threading.Tasks.Task<GetExecutionInfo3Response> task = base.Channel.GetExecutionInfo3Async(request);
			this.ServerInfoHeader = task.Result.ServerInfoHeader;
			return task;
		}

		public System.Threading.Tasks.Task<GetDocumentMapResponse> GetDocumentMapAsync(GetDocumentMapRequest request)
		{
			return base.Channel.GetDocumentMapAsync(request);
		}

		public System.Threading.Tasks.Task<LoadDrillthroughTargetResponse> LoadDrillthroughTargetAsync(LoadDrillthroughTargetRequest request)
		{
			return base.Channel.LoadDrillthroughTargetAsync(request);
		}

		public System.Threading.Tasks.Task<LoadDrillthroughTarget2Response> LoadDrillthroughTarget2Async(LoadDrillthroughTarget2Request request)
		{
			return base.Channel.LoadDrillthroughTarget2Async(request);
		}

		public System.Threading.Tasks.Task<LoadDrillthroughTarget3Response> LoadDrillthroughTarget3Async(LoadDrillthroughTarget3Request request)
		{
			return base.Channel.LoadDrillthroughTarget3Async(request);
		}

		public System.Threading.Tasks.Task<ToggleItemResponse> ToggleItemAsync(ToggleItemRequest request)
		{
			return base.Channel.ToggleItemAsync(request);
		}

		public System.Threading.Tasks.Task<NavigateDocumentMapResponse> NavigateDocumentMapAsync(NavigateDocumentMapRequest request)
		{
			return base.Channel.NavigateDocumentMapAsync(request);
		}

		public System.Threading.Tasks.Task<NavigateBookmarkResponse> NavigateBookmarkAsync(NavigateBookmarkRequest request)
		{
			return base.Channel.NavigateBookmarkAsync(request);
		}

		public System.Threading.Tasks.Task<FindStringResponse> FindStringAsync(FindStringRequest request)
		{
			return base.Channel.FindStringAsync(request);
		}

		public System.Threading.Tasks.Task<SortResponse> SortAsync(SortRequest request)
		{
			return base.Channel.SortAsync(request);
		}

		public System.Threading.Tasks.Task<Sort2Response> Sort2Async(Sort2Request request)
		{
			return base.Channel.Sort2Async(request);
		}

		public System.Threading.Tasks.Task<Sort3Response> Sort3Async(Sort3Request request)
		{
			return base.Channel.Sort3Async(request);
		}

		public System.Threading.Tasks.Task<GetRenderResourceResponse> GetRenderResourceAsync(GetRenderResourceRequest request)
		{
			return base.Channel.GetRenderResourceAsync(request);
		}

		public System.Threading.Tasks.Task<ListRenderingExtensionsResponse> ListRenderingExtensionsAsync(ListRenderingExtensionsRequest request)
		{
			return base.Channel.ListRenderingExtensionsAsync(request);
		}

		public System.Threading.Tasks.Task<LogonUserResponse> LogonUserAsync(LogonUserRequest request)
		{
			return base.Channel.LogonUserAsync(request);
		}

		public System.Threading.Tasks.Task<LogoffResponse> LogoffAsync(LogoffRequest request)
		{
			return base.Channel.LogoffAsync(request);
		}

		public virtual System.Threading.Tasks.Task OpenAsync()
		{
			return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)this).BeginOpen((System.AsyncCallback)null, (object)null), ((System.ServiceModel.ICommunicationObject)this).EndOpen);
		}

		public virtual System.Threading.Tasks.Task CloseAsync()
		{
			return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)this).BeginClose((System.AsyncCallback)null, (object)null), ((System.ServiceModel.ICommunicationObject)this).EndClose);
		}

		private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
		{
			switch (endpointConfiguration)
			{
			case EndpointConfiguration.ReportExecutionServiceSoap:
			{
				System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
				result.MaxBufferSize = 2147483647;
				result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
				result.MaxReceivedMessageSize = 2147483647L;
				result.AllowCookies = true;
				return result;
			}
			case EndpointConfiguration.ReportExecutionServiceSoap12:
			{
				System.ServiceModel.Channels.CustomBinding result2 = new System.ServiceModel.Channels.CustomBinding();
				System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
				textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
				result2.Elements.Add(textBindingElement);
				System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
				httpBindingElement.AllowCookies = true;
				httpBindingElement.MaxBufferSize = 2147483647;
				httpBindingElement.MaxReceivedMessageSize = 2147483647L;
				httpBindingElement.AuthenticationScheme = System.Net.AuthenticationSchemes.Ntlm;
				result2.Elements.Add(httpBindingElement);
				return result2;
			}
			default:
				throw new System.InvalidOperationException($"Could not find endpoint with name '{endpointConfiguration}'.");
			}
		}

		private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
		{
			switch (endpointConfiguration)
			{
			case EndpointConfiguration.ReportExecutionServiceSoap:
				return new System.ServiceModel.EndpointAddress("http://amh1979/ReportServer/ReportExecution2005.asmx");
			case EndpointConfiguration.ReportExecutionServiceSoap12:
				return new System.ServiceModel.EndpointAddress("http://amh1979/ReportServer/ReportExecution2005.asmx");
			default:
				throw new System.InvalidOperationException($"Could not find endpoint with name '{endpointConfiguration}'.");
			}
		}
	}
}