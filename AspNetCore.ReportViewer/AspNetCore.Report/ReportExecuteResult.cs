namespace AspNetCore.Report
{
	public class ReportExecuteResult
	{
		public string Contents
		{
			get;
			internal set;
		}

		public byte[] Stream
		{
			get;
			internal set;
		}

		public string MimeType
		{
			get;
			internal set;
		}

		public string Encoding
		{
			get;
			internal set;
		}

		public string Extension
		{
			get;
			internal set;
		}

		public int PageCount
		{
			get;
			internal set;
		}

		public int PageIndex
		{
			get;
			internal set;
		}

		public string SessionId
		{
			get;
			internal set;
		}

		public bool ParametersRequired
		{
			get;
			internal set;
		}

		internal ReportExecuteResult()
		{
		}
	}
}
