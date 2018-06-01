namespace AspNetCore.Report
{
	/// <summary>
	/// the report data
	/// </summary>
	public class ReportData
	{
		/// <summary>
		/// string contents
		/// e.g. html
		/// </summary>
		public string Contents
		{
			get;
			internal set;
		}

		/// <summary>
		/// the report session id
		/// </summary>
		public string SessionId
		{
			get;
			internal set;
		}

		/// <summary>
		/// which page of report to excuting
		/// </summary>
		public int PageIndex
		{
			get;
			internal set;
		}

		/// <summary>
		/// the total page count of report
		/// </summary>
		public int PageCount
		{
			get;
			internal set;
		}

		/// <summary>
		/// 版本号
		/// </summary>
		public System.Version Version
		{
			get;
			internal set;
		}

		/// <summary>
		/// used for export the fileName
		/// </summary>
		public string FileName
		{
			get;
			set;
		}

		/// <summary>
		/// the content stream, for download file
		/// </summary>
		public byte[] Stream
		{
			get;
			internal set;
		}

		/// <summary>
		/// the file mime type
		/// </summary>
		public string MimeType
		{
			get;
			internal set;
		}

		/// <summary>
		/// the file extension
		/// </summary>
		public string Extension
		{
			get;
			internal set;
		}
	}
}
