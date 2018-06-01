namespace AspNetCore.Report
{
	/// <summary>
	/// how to Excute for report
	/// </summary>
	public class ReportRequest
	{
		private string _fileName = string.Empty;

		/// <summary>
		/// The report id
		/// The SSRS useless, but can used by client to set something
		/// </summary>
		public int Id
		{
			get;
			set;
		}

		/// <summary>
		/// report name, used for export the fileName
		/// </summary>
		public string Name
		{
			get;
			set;
		}

		/// <summary>
		/// this is used by export
		/// </summary>
		public string FileName
		{
			get
			{
				if (string.IsNullOrEmpty(this._fileName))
				{
					this.SetFileName(null);
				}
				return this._fileName;
			}
			protected set
			{
				this._fileName = value;
			}
		}

		/// <summary>
		/// The report path on server
		/// </summary>
		public string Path
		{
			get;
			set;
		}

		/// <summary>
		/// the report session id, can used by client to excute report fast
		/// </summary>
		public string SessionId
		{
			get;
			set;
		}

		/// <summary>
		/// set what character to find in report
		/// </summary>
		public string FindString
		{
			get;
			set;
		}

		/// <summary>
		/// the colse div for html which is the element id
		/// </summary>
		public string ToggleId
		{
			get;
			set;
		}

		/// <summary>
		/// the page index which to display for html
		/// </summary>
		public int PageIndex
		{
			get;
			set;
		}

		/// <summary>
		///  Whether reload report data by ignore the session id
		/// </summary>
		public bool Reset
		{
			get;
			set;
		}

		/// <summary>
		/// how to render the report data
		/// </summary>
		public ReportRenderType RenderType
		{
			get;
			set;
		}

		/// <summary>
		/// how to execute the report
		/// </summary>
		public ReportExecuteType ExecuteType
		{
			get;
			set;
		}

		/// <summary>
		/// the report parameters of the conditions
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Parameters
		{
			get;
			set;
		} = new System.Collections.Generic.Dictionary<string, string>();


		/// <summary>
		/// set file name for export file
		/// </summary>
		/// <param name="append"></param>
		public void SetFileName(string append = null)
		{
			string name3 = string.Empty;
			if (string.IsNullOrEmpty(this.Name))
			{
				if (!string.IsNullOrEmpty(this.Path) && this.Path.IndexOf("/") > -1)
				{
					string[] i = this.Path.Split(new char[1]
					{
						'/'
					});
					string s = i[i.Length - 1];
					if (string.IsNullOrEmpty(s))
					{
						s = i[i.Length - 2];
					}
					name3 = s;
				}
				else
				{
					name3 = this.Path;
				}
			}
			else
			{
				name3 = this.Name;
			}
			if (string.IsNullOrEmpty(name3))
			{
				name3 = "Report";
			}
			name3 = name3.Replace(" ", "_");
			if (!string.IsNullOrEmpty(append))
			{
				name3 = $"{name3}_{append}";
			}
			this._fileName = name3;
		}
	}
}
