
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	[MessageContract(WrapperName = "InheritModelItemParentSecurity", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class InheritModelItemParentSecurityRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string Model;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public string ModelItemID;

		public InheritModelItemParentSecurityRequest()
		{
		}

		public InheritModelItemParentSecurityRequest(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.Model = Model;
			this.ModelItemID = ModelItemID;
		}
	}
}