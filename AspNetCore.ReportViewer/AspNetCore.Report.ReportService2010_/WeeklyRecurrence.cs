

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;



namespace AspNetCore.Report.ReportService2010_
{
	/// <remarks />
	[GeneratedCode("svcutil", "4.6.1055.0")]
	[DataContract]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
	public class WeeklyRecurrence : RecurrencePattern
	{
		private int weeksIntervalField;

		private bool weeksIntervalFieldSpecified;

		private DaysOfWeekSelector daysOfWeekField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public int WeeksInterval
		{
			get
			{
				return this.weeksIntervalField;
			}
			set
			{
				this.weeksIntervalField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool WeeksIntervalSpecified
		{
			get
			{
				return this.weeksIntervalFieldSpecified;
			}
			set
			{
				this.weeksIntervalFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public DaysOfWeekSelector DaysOfWeek
		{
			get
			{
				return this.daysOfWeekField;
			}
			set
			{
				this.daysOfWeekField = value;
			}
		}
	}
}
