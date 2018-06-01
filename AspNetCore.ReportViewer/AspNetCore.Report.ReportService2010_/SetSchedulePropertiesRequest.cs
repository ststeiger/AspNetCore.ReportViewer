
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
	[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	[MessageContract(WrapperName = "SetScheduleProperties", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class SetSchedulePropertiesRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string Name;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public string ScheduleID;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 2)]
		public ScheduleDefinition ScheduleDefinition;

		public SetSchedulePropertiesRequest()
		{
		}

		public SetSchedulePropertiesRequest(TrustedUserHeader TrustedUserHeader, string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.Name = Name;
			this.ScheduleID = ScheduleID;
			this.ScheduleDefinition = ScheduleDefinition;
		}
	}
}