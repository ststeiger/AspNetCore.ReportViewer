
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
	[MessageContract(WrapperName = "GetItemHistoryLimitResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetItemHistoryLimitResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public int HistoryLimit;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public bool IsSystem;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 2)]
		public int SystemLimit;

		public GetItemHistoryLimitResponse()
		{
		}

		public GetItemHistoryLimitResponse(ServerInfoHeader ServerInfoHeader, int HistoryLimit, bool IsSystem, int SystemLimit)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.HistoryLimit = HistoryLimit;
			this.IsSystem = IsSystem;
			this.SystemLimit = SystemLimit;
		}
	}
}