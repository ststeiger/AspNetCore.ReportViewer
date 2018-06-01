
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
	[MessageContract(WrapperName = "FindItems", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class FindItemsRequest
	{
		[MessageHeader]
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string Folder;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public BooleanOperatorEnum BooleanOperator;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 2)]
		public Property[] SearchOptions;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 3)]
		public SearchCondition[] SearchConditions;

		public FindItemsRequest()
		{
		}

		public FindItemsRequest(TrustedUserHeader TrustedUserHeader, string Folder, BooleanOperatorEnum BooleanOperator, Property[] SearchOptions, SearchCondition[] SearchConditions)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.Folder = Folder;
			this.BooleanOperator = BooleanOperator;
			this.SearchOptions = SearchOptions;
			this.SearchConditions = SearchConditions;
		}
	}
}