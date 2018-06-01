
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
	public class ScheduleDefinition : ScheduleDefinitionOrReference
	{
		private System.DateTime startDateTimeField;

		private System.DateTime endDateField;

		private bool endDateFieldSpecified;

		private RecurrencePattern itemField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public System.DateTime StartDateTime
		{
			get
			{
				return this.startDateTimeField;
			}
			set
			{
				this.startDateTimeField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public System.DateTime EndDate
		{
			get
			{
				return this.endDateField;
			}
			set
			{
				this.endDateField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool EndDateSpecified
		{
			get
			{
				return this.endDateFieldSpecified;
			}
			set
			{
				this.endDateFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement("DailyRecurrence", typeof(DailyRecurrence), Order = 2)]
		[XmlElement("MinuteRecurrence", typeof(MinuteRecurrence), Order = 2)]
		[XmlElement("MonthlyDOWRecurrence", typeof(MonthlyDOWRecurrence), Order = 2)]
		[XmlElement("MonthlyRecurrence", typeof(MonthlyRecurrence), Order = 2)]
		[XmlElement("WeeklyRecurrence", typeof(WeeklyRecurrence), Order = 2)]
		public RecurrencePattern Item
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