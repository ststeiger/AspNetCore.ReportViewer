namespace AspNetCore.Report
{
	public enum ReportRenderType
	{
		/// <summary>
		/// NULL
		/// </summary>
		Null,
		/// <summary>
		/// word 2003-2007 .doc
		/// </summary>
		Word,
		/// <summary>
		/// word 2010-2016 .docx
		/// </summary>
		WordOpenXml,
		/// <summary>
		/// excel 2003-2007 .xls
		/// </summary>
		Excel,
		/// <summary>
		/// excel 2010-2016 .xlsx
		/// </summary>
		ExcelOpenXml,
		/// <summary>
		/// power point 2010-2016 .pptx
		/// </summary>
		Pptx,
		/// <summary>
		/// pdf file
		/// </summary>
		Pdf,
		/// <summary>
		/// image
		/// </summary>
		Image,
		/// <summary>
		/// Mhtml
		/// </summary>
		Mhtml,
		/// <summary>
		/// CSV
		/// </summary>
		Csv,
		/// <summary>
		/// XML
		/// </summary>
		Xml,
		/// <summary>
		/// Atom
		/// </summary>
		Atom,
		/// <summary>
		/// html4.0
		/// </summary>
		Html4_0,
		/// <summary>
		/// html5
		/// </summary>
		Html5,
		/// <summary>
		/// RPL
		/// </summary>
		Rpl
	}
}
