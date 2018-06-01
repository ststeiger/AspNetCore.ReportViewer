
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;

namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName = "TestConnectForDataSourceDefinitionResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class TestConnectForDataSourceDefinitionResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public bool TestConnectForDataSourceDefinitionResult;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public string ConnectError;

		public TestConnectForDataSourceDefinitionResponse()
		{
		}

		public TestConnectForDataSourceDefinitionResponse(ServerInfoHeader ServerInfoHeader, bool TestConnectForDataSourceDefinitionResult, string ConnectError)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.TestConnectForDataSourceDefinitionResult = TestConnectForDataSourceDefinitionResult;
			this.ConnectError = ConnectError;
		}
	}
}
