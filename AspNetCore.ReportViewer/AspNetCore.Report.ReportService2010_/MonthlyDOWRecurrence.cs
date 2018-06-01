
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
	public class MonthlyDOWRecurrence : RecurrencePattern
	{
		private WeekNumberEnum whichWeekField;

		private bool whichWeekFieldSpecified;

		private DaysOfWeekSelector daysOfWeekField;

		private MonthsOfYearSelector monthsOfYearField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public WeekNumberEnum WhichWeek
		{
			get
			{
				return this.whichWeekField;
			}
			set
			{
				this.whichWeekField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool WhichWeekSpecified
		{
			get
			{
				return this.whichWeekFieldSpecified;
			}
			set
			{
				this.whichWeekFieldSpecified = value;
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

		/// <remarks />
		[XmlElement(Order = 2)]
		public MonthsOfYearSelector MonthsOfYear
		{
			get
			{
				return this.monthsOfYearField;
			}
			set
			{
				this.monthsOfYearField = value;
			}
		}
	}
}