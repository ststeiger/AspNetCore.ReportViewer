
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
	[MessageContract(WrapperName = "GetCacheRefreshPlanPropertiesResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetCacheRefreshPlanPropertiesResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string Description;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public string LastRunStatus;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 2)]
		public CacheRefreshPlanState State;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 3)]
		public string EventType;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 4)]
		public string MatchData;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 5)]
		public ParameterValue[] Parameters;

		public GetCacheRefreshPlanPropertiesResponse()
		{
		}

		public GetCacheRefreshPlanPropertiesResponse(ServerInfoHeader ServerInfoHeader, string Description, string LastRunStatus, CacheRefreshPlanState State, string EventType, string MatchData, ParameterValue[] Parameters)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.Description = Description;
			this.LastRunStatus = LastRunStatus;
			this.State = State;
			this.EventType = EventType;
			this.MatchData = MatchData;
			this.Parameters = Parameters;
		}
	}
}