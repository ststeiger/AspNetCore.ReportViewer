
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
	[MessageContract(WrapperName = "GetItemHistoryOptionsResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetItemHistoryOptionsResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public bool EnableManualSnapshotCreation;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public bool KeepExecutionSnapshots;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 2)]
		[XmlElement("NoSchedule", typeof(NoSchedule))]
		[XmlElement("ScheduleDefinition", typeof(ScheduleDefinition))]
		[XmlElement("ScheduleReference", typeof(ScheduleReference))]
		public ScheduleDefinitionOrReference Item;

		public GetItemHistoryOptionsResponse()
		{
		}

		public GetItemHistoryOptionsResponse(ServerInfoHeader ServerInfoHeader, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, ScheduleDefinitionOrReference Item)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.EnableManualSnapshotCreation = EnableManualSnapshotCreation;
			this.KeepExecutionSnapshots = KeepExecutionSnapshots;
			this.Item = Item;
		}
	}
}