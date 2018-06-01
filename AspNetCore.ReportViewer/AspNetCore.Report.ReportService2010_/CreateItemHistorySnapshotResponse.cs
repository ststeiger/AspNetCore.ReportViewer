

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
	[MessageContract(WrapperName = "CreateItemHistorySnapshotResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class CreateItemHistorySnapshotResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string HistoryID;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public Warning[] Warnings;

		public CreateItemHistorySnapshotResponse()
		{
		}

		public CreateItemHistorySnapshotResponse(ServerInfoHeader ServerInfoHeader, string HistoryID, Warning[] Warnings)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.HistoryID = HistoryID;
			this.Warnings = Warnings;
		}
	}
}
