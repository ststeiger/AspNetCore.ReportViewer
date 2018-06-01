
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;


namespace AspNetCore.Report.ReportExecutionService
{
	[DebuggerStepThrough]
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[MessageContract(WrapperName = "Sort2", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsWrapped = true)]
	public class Sort2Request
	{
		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Order = 0)]
		public string SortItem;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Order = 1)]
		public SortDirectionEnum Direction;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Order = 2)]
		public bool Clear;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Order = 3)]
		public PageCountMode PaginationMode;

		public Sort2Request()
		{
		}

		public Sort2Request(string SortItem, SortDirectionEnum Direction, bool Clear, PageCountMode PaginationMode)
		{
			this.SortItem = SortItem;
			this.Direction = Direction;
			this.Clear = Clear;
			this.PaginationMode = PaginationMode;
		}
	}
}