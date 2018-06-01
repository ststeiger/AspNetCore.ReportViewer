

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
	[MessageContract(WrapperName = "CreateCatalogItemResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class CreateCatalogItemResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public CatalogItem ItemInfo;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public Warning[] Warnings;

		public CreateCatalogItemResponse()
		{
		}

		public CreateCatalogItemResponse(ServerInfoHeader ServerInfoHeader, CatalogItem ItemInfo, Warning[] Warnings)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.ItemInfo = ItemInfo;
			this.Warnings = Warnings;
		}
	}
}
