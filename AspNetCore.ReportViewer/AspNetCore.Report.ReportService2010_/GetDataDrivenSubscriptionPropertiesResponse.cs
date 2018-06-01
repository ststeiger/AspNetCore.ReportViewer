
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
	[MessageContract(WrapperName = "GetDataDrivenSubscriptionPropertiesResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetDataDrivenSubscriptionPropertiesResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string Owner;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public ExtensionSettings ExtensionSettings;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 2)]
		public DataRetrievalPlan DataRetrievalPlan;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 3)]
		public string Description;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 4)]
		public ActiveState Active;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 5)]
		public string Status;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 6)]
		public string EventType;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 7)]
		public string MatchData;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 8)]
		public ParameterValueOrFieldReference[] Parameters;

		public GetDataDrivenSubscriptionPropertiesResponse()
		{
		}

		public GetDataDrivenSubscriptionPropertiesResponse(ServerInfoHeader ServerInfoHeader, string Owner, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, ActiveState Active, string Status, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.Owner = Owner;
			this.ExtensionSettings = ExtensionSettings;
			this.DataRetrievalPlan = DataRetrievalPlan;
			this.Description = Description;
			this.Active = Active;
			this.Status = Status;
			this.EventType = EventType;
			this.MatchData = MatchData;
			this.Parameters = Parameters;
		}
	}
}