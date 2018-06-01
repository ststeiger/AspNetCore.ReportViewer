
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportExecutionService
{
	[DataContractFormat(Style = System.ServiceModel.OperationFormatStyle.Rpc)]
	[XmlInclude(typeof(ParameterFieldReference))]
	[XmlInclude(typeof(ParameterValue))]
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
	public class ParameterValueOrFieldReference
	{
	}
}