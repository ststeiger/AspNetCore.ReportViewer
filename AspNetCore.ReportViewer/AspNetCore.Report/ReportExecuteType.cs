namespace AspNetCore.Report
{
	/// <summary>
	/// Report Execute Type
	/// </summary>
	public enum ReportExecuteType
	{
		/// <summary>
		/// show html
		/// </summary>
		Display,
		/// <summary>
		/// export file
		/// </summary>
		Export,
		/// <summary>
		/// find strings in report
		/// </summary>
		FindString,
		/// <summary>
		/// toggle the report for show or hide child content
		/// </summary>
		Toggle,
		/// <summary>
		/// Print report
		/// </summary>
		Print
	}
}
