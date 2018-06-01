
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
	public class ExtensionSettings
	{
		private string extensionField;

		private ParameterValueOrFieldReference[] parameterValuesField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string Extension
		{
			get
			{
				return this.extensionField;
			}
			set
			{
				this.extensionField = value;
			}
		}

		/// <remarks />
		[XmlArray(Order = 1)]
		[XmlArrayItem(typeof(ParameterFieldReference))]
		[XmlArrayItem(typeof(ParameterValue))]
		public ParameterValueOrFieldReference[] ParameterValues
		{
			get
			{
				return this.parameterValuesField;
			}
			set
			{
				this.parameterValuesField = value;
			}
		}
	}
}