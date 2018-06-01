
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	/// <remarks />
	[GeneratedCode("svcutil", "4.6.1055.0")]
	[DataContract]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
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