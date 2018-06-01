
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;


namespace AspNetCore.Report.ReportExecutionService
{
	/// <remarks />
	[XmlInclude(typeof(ExecutionInfo3))]
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
	public class ExecutionInfo2 : ExecutionInfo
	{
		private PageCountMode pageCountModeField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public PageCountMode PageCountMode
		{
			get
			{
				return this.pageCountModeField;
			}
			set
			{
				this.pageCountModeField = value;
			}
		}
	}
}