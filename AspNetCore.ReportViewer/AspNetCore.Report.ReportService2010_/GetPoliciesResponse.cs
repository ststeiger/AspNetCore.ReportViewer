
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName = "GetPoliciesResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetPoliciesResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public Policy[] Policies;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public bool InheritParent;

		public GetPoliciesResponse()
		{
		}

		public GetPoliciesResponse(ServerInfoHeader ServerInfoHeader, Policy[] Policies, bool InheritParent)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.Policies = Policies;
			this.InheritParent = InheritParent;
		}
	}
}