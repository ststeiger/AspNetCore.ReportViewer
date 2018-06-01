namespace AspNetCore.Report
{
	public class ReportException : System.Exception
	{
		internal ReportException()
		{
		}

		public ReportException(string message)
			: base(message)
		{
		}

		public ReportException(string message, System.Exception ex)
			: base(message, ex)
		{
		}
	}
}
