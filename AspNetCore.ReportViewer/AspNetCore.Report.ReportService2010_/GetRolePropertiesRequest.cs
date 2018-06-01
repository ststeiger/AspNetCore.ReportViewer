
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName = "GetRoleProperties", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetRolePropertiesRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string Name;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public string SiteUrl;

		public GetRolePropertiesRequest()
		{
		}

		public GetRolePropertiesRequest(TrustedUserHeader TrustedUserHeader, string Name, string SiteUrl)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.Name = Name;
			this.SiteUrl = SiteUrl;
		}
	}
}