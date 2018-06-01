
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
	[MessageContract(WrapperName = "GetCacheOptionsResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetCacheOptionsResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public bool CacheItem;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		[XmlElement("ScheduleExpiration", typeof(ScheduleExpiration))]
		[XmlElement("TimeExpiration", typeof(TimeExpiration))]
		public ExpirationDefinition Item;

		public GetCacheOptionsResponse()
		{
		}

		public GetCacheOptionsResponse(ServerInfoHeader ServerInfoHeader, bool CacheItem, ExpirationDefinition Item)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.CacheItem = CacheItem;
			this.Item = Item;
		}
	}
}