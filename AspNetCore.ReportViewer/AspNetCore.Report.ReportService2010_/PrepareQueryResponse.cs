
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
	[MessageContract(WrapperName = "PrepareQueryResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class PrepareQueryResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public DataSetDefinition DataSettings;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public bool Changed;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 2)]
		public string[] ParameterNames;

		public PrepareQueryResponse()
		{
		}

		public PrepareQueryResponse(ServerInfoHeader ServerInfoHeader, DataSetDefinition DataSettings, bool Changed, string[] ParameterNames)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.DataSettings = DataSettings;
			this.Changed = Changed;
			this.ParameterNames = ParameterNames;
		}
	}
}