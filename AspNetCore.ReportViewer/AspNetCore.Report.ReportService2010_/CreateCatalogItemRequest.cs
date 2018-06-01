

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
	[MessageContract(WrapperName = "CreateCatalogItem", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class CreateCatalogItemRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string ItemType;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public string Name;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 2)]
		public string Parent;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 3)]
		public bool Overwrite;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 4)]
		[XmlElement(DataType = "base64Binary")]
		public byte[] Definition;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 5)]
		public Property[] Properties;

		public CreateCatalogItemRequest()
		{
		}

		public CreateCatalogItemRequest(TrustedUserHeader TrustedUserHeader, string ItemType, string Name, string Parent, bool Overwrite, byte[] Definition, Property[] Properties)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.ItemType = ItemType;
			this.Name = Name;
			this.Parent = Parent;
			this.Overwrite = Overwrite;
			this.Definition = Definition;
			this.Properties = Properties;
		}
	}
}
