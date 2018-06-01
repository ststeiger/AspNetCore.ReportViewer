
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
	[MessageContract(WrapperName = "GetProperties", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetPropertiesRequest
	{
		public ItemNamespaceHeader ItemNamespaceHeader;

		[MessageHeader]
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string ItemPath;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public Property[] Properties;

		public GetPropertiesRequest()
		{
		}

		public GetPropertiesRequest(ItemNamespaceHeader ItemNamespaceHeader, TrustedUserHeader TrustedUserHeader, string ItemPath, Property[] Properties)
		{
			this.ItemNamespaceHeader = ItemNamespaceHeader;
			this.TrustedUserHeader = TrustedUserHeader;
			this.ItemPath = ItemPath;
			this.Properties = Properties;
		}
	}
}