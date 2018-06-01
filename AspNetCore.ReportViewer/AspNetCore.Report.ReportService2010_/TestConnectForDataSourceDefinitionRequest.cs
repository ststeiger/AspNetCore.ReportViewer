
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
	[MessageContract(WrapperName = "TestConnectForDataSourceDefinition", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class TestConnectForDataSourceDefinitionRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public DataSourceDefinition DataSourceDefinition;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public string UserName;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 2)]
		public string Password;

		public TestConnectForDataSourceDefinitionRequest()
		{
		}

		public TestConnectForDataSourceDefinitionRequest(TrustedUserHeader TrustedUserHeader, DataSourceDefinition DataSourceDefinition, string UserName, string Password)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.DataSourceDefinition = DataSourceDefinition;
			this.UserName = UserName;
			this.Password = Password;
		}
	}
}
