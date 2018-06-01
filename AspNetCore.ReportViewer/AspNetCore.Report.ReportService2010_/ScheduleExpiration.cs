
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	/// <remarks />
	[GeneratedCode("svcutil", "4.6.1055.0")]
	[DataContract]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
	public class ScheduleExpiration : ExpirationDefinition
	{
		private ScheduleDefinitionOrReference itemField;

		/// <remarks />
		[XmlElement("ScheduleDefinition", typeof(ScheduleDefinition), Order = 0)]
		[XmlElement("ScheduleReference", typeof(ScheduleReference), Order = 0)]
		public ScheduleDefinitionOrReference Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}
	}
}