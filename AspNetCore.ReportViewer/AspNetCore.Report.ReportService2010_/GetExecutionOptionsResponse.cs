
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
	[MessageContract(WrapperName = "GetExecutionOptionsResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetExecutionOptionsResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string ExecutionSetting;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		[XmlElement("NoSchedule", typeof(NoSchedule))]
		[XmlElement("ScheduleDefinition", typeof(ScheduleDefinition))]
		[XmlElement("ScheduleReference", typeof(ScheduleReference))]
		public ScheduleDefinitionOrReference Item;

		public GetExecutionOptionsResponse()
		{
		}

		public GetExecutionOptionsResponse(ServerInfoHeader ServerInfoHeader, string ExecutionSetting, ScheduleDefinitionOrReference Item)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.ExecutionSetting = ExecutionSetting;
			this.Item = Item;
		}
	}
}