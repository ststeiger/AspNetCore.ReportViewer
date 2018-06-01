
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
	public class ParameterFieldReference : ParameterValueOrFieldReference
	{
		private string parameterNameField;

		private string fieldAliasField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string ParameterName
		{
			get
			{
				return this.parameterNameField;
			}
			set
			{
				this.parameterNameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public string FieldAlias
		{
			get
			{
				return this.fieldAliasField;
			}
			set
			{
				this.fieldAliasField = value;
			}
		}
	}
}