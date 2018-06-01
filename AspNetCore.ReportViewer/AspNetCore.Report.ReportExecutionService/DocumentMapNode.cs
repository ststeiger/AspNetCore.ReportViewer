
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
	public class DocumentMapNode
	{
		private string labelField;

		private string uniqueNameField;

		private DocumentMapNode[] childrenField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string Label
		{
			get
			{
				return this.labelField;
			}
			set
			{
				this.labelField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public string UniqueName
		{
			get
			{
				return this.uniqueNameField;
			}
			set
			{
				this.uniqueNameField = value;
			}
		}

		/// <remarks />
		[XmlArray(Order = 2)]
		public DocumentMapNode[] Children
		{
			get
			{
				return this.childrenField;
			}
			set
			{
				this.childrenField = value;
			}
		}
	}
}