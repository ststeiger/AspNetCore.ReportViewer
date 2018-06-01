

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ComponentModel;
using System.ServiceModel;

namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	[MessageContract(WrapperName = "CreateDataDrivenSubscriptionResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class CreateDataDrivenSubscriptionResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string SubscriptionID;

		public CreateDataDrivenSubscriptionResponse()
		{
		}

		public CreateDataDrivenSubscriptionResponse(ServerInfoHeader ServerInfoHeader, string SubscriptionID)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.SubscriptionID = SubscriptionID;
		}
	}
}
