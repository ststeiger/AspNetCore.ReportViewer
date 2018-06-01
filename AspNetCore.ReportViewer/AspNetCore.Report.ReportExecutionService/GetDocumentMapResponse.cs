
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;


namespace AspNetCore.Report.ReportExecutionService
{
	[DebuggerStepThrough]
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[MessageContract(WrapperName = "GetDocumentMapResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsWrapped = true)]
	public class GetDocumentMapResponse
	{
		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Order = 0)]
		public DocumentMapNode result;

		public GetDocumentMapResponse()
		{
		}

		public GetDocumentMapResponse(DocumentMapNode result)
		{
			this.result = result;
		}
	}
}