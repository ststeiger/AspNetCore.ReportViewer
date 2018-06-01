
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
	[MessageContract(WrapperName = "SetCacheRefreshPlanProperties", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class SetCacheRefreshPlanPropertiesRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string CacheRefreshPlanID;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public string Description;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 2)]
		public string EventType;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 3)]
		public string MatchData;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 4)]
		public ParameterValue[] Parameters;

		public SetCacheRefreshPlanPropertiesRequest()
		{
		}

		public SetCacheRefreshPlanPropertiesRequest(TrustedUserHeader TrustedUserHeader, string CacheRefreshPlanID, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.CacheRefreshPlanID = CacheRefreshPlanID;
			this.Description = Description;
			this.EventType = EventType;
			this.MatchData = MatchData;
			this.Parameters = Parameters;
		}
	}
}