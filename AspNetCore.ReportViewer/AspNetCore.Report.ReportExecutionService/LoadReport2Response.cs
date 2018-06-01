
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportExecutionService
{
	[DebuggerStepThrough]
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[MessageContract(WrapperName = "LoadReport2Response", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsWrapped = true)]
	public class LoadReport2Response
	{
		[MessageHeader]
		public ExecutionHeader ExecutionHeader;

		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageHeader]
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Order = 0)]
		public ExecutionInfo2 executionInfo;

		public LoadReport2Response()
		{
		}

		public LoadReport2Response(ExecutionHeader ExecutionHeader, ServerInfoHeader ServerInfoHeader, TrustedUserHeader TrustedUserHeader, ExecutionInfo2 executionInfo)
		{
			this.ExecutionHeader = ExecutionHeader;
			this.ServerInfoHeader = ServerInfoHeader;
			this.TrustedUserHeader = TrustedUserHeader;
			this.executionInfo = executionInfo;
		}
	}
}