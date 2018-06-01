
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ComponentModel;
using System.ServiceModel;

namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	[MessageContract(WrapperName = "ValidateExtensionSettings", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class ValidateExtensionSettingsRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string Extension;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public ParameterValueOrFieldReference[] ParameterValues;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 2)]
		public string SiteUrl;

		public ValidateExtensionSettingsRequest()
		{
		}

		public ValidateExtensionSettingsRequest(TrustedUserHeader TrustedUserHeader, string Extension, ParameterValueOrFieldReference[] ParameterValues, string SiteUrl)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.Extension = Extension;
			this.ParameterValues = ParameterValues;
			this.SiteUrl = SiteUrl;
		}
	}
}
