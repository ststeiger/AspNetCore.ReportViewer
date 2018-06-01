
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
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
	public enum ParameterTypeEnum
	{
		/// <remarks />
		Boolean,
		/// <remarks />
		DateTime,
		/// <remarks />
		Integer,
		/// <remarks />
		Float,
		/// <remarks />
		String
	}
}