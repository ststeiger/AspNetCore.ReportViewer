

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
	public class DailyRecurrence : RecurrencePattern
	{
		private int daysIntervalField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public int DaysInterval
		{
			get
			{
				return this.daysIntervalField;
			}
			set
			{
				this.daysIntervalField = value;
			}
		}
	}
}
