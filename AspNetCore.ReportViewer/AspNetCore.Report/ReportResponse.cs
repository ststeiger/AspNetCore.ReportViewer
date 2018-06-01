namespace AspNetCore.Report
{
	/// <summary>
	/// the report executed result
	/// </summary>
	public class ReportResponse
	{
		/// <summary>
		/// 0 success
		/// </summary>
		public int Status
		{
			get;
			internal set;
		} = 0;


		/// <summary>
		/// excute message
		/// </summary>
		public string Message
		{
			get;
			internal set;
		} = "OK";


		/// <summary>
		/// the report data
		/// </summary>
		public ReportData Data
		{
			get;
			internal set;
		} = new ReportData();


		/// <summary>
		/// defalut return success.
		/// </summary>
		public ReportResponse()
		{
		}

		/// <summary>
		/// return error.
		/// </summary>
		/// <param name="errorMessage"></param>
		public ReportResponse(string errorMessage)
		{
			this.Status = -2;
			this.Message = errorMessage;
		}

		/// <summary>
		/// set excuted of error
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		public ReportResponse SetError(string message)
		{
			this.Status = -1;
			this.Message = message;
			return this;
		}
	}
}
