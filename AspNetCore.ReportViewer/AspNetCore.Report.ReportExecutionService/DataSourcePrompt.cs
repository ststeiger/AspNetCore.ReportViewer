
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;



namespace AspNetCore.Report.ReportExecutionService
{
	/// <remarks />
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
	public class DataSourcePrompt
	{
		private string nameField;

		private string dataSourceIDField;

		private string promptField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public string DataSourceID
		{
			get
			{
				return this.dataSourceIDField;
			}
			set
			{
				this.dataSourceIDField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public string Prompt
		{
			get
			{
				return this.promptField;
			}
			set
			{
				this.promptField = value;
			}
		}
	}
}