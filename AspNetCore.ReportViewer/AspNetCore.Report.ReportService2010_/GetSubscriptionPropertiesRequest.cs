
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
	[MessageContract(WrapperName = "GetSubscriptionProperties", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetSubscriptionPropertiesRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string SubscriptionID;

		public GetSubscriptionPropertiesRequest()
		{
		}

		public GetSubscriptionPropertiesRequest(TrustedUserHeader TrustedUserHeader, string SubscriptionID)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.SubscriptionID = SubscriptionID;
		}
	}
}