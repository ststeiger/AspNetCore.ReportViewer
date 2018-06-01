
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportExecutionService
{
	/// <remarks />
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
	public class PageSettings
	{
		private ReportPaperSize paperSizeField;

		private ReportMargins marginsField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public ReportPaperSize PaperSize
		{
			get
			{
				return this.paperSizeField;
			}
			set
			{
				this.paperSizeField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public ReportMargins Margins
		{
			get
			{
				return this.marginsField;
			}
			set
			{
				this.marginsField = value;
			}
		}
	}
}