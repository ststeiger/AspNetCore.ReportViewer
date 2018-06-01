
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
	[MessageContract(WrapperName = "LoadReport3Response", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsWrapped = true)]
	public class LoadReport3Response
	{
		[MessageHeader]
		public ExecutionHeader ExecutionHeader;

		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageHeader]
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Order = 0)]
		public ExecutionInfo3 executionInfo;

		public LoadReport3Response()
		{
		}

		public LoadReport3Response(ExecutionHeader ExecutionHeader, ServerInfoHeader ServerInfoHeader, TrustedUserHeader TrustedUserHeader, ExecutionInfo3 executionInfo)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.ExecutionHeader = ExecutionHeader;
			this.ServerInfoHeader = ServerInfoHeader;
			this.executionInfo = executionInfo;
		}
	}
}