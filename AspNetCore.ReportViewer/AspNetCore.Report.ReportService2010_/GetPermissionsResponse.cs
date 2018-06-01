
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	[MessageContract(WrapperName = "GetPermissionsResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetPermissionsResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		[XmlArrayItem("Operation")]
		public string[] Permissions;

		public GetPermissionsResponse()
		{
		}

		public GetPermissionsResponse(ServerInfoHeader ServerInfoHeader, string[] Permissions)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.Permissions = Permissions;
		}
	}
}