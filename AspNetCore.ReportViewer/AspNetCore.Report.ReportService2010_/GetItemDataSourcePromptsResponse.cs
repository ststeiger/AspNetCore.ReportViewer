
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
	[MessageContract(WrapperName = "GetItemDataSourcePromptsResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetItemDataSourcePromptsResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public DataSourcePrompt[] DataSourcePrompts;

		public GetItemDataSourcePromptsResponse()
		{
		}

		public GetItemDataSourcePromptsResponse(ServerInfoHeader ServerInfoHeader, DataSourcePrompt[] DataSourcePrompts)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.DataSourcePrompts = DataSourcePrompts;
		}
	}
}