

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
	[MessageContract(WrapperName = "TestConnectForItemDataSourceResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class TestConnectForItemDataSourceResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public bool TestConnectForItemDataSourceResult;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public string ConnectError;

		public TestConnectForItemDataSourceResponse()
		{
		}

		public TestConnectForItemDataSourceResponse(ServerInfoHeader ServerInfoHeader, bool TestConnectForItemDataSourceResult, string ConnectError)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.TestConnectForItemDataSourceResult = TestConnectForItemDataSourceResult;
			this.ConnectError = ConnectError;
		}
	}
}
