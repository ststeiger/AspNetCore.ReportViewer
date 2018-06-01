
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
	public class MonthlyRecurrence : RecurrencePattern
	{
		private string daysField;

		private MonthsOfYearSelector monthsOfYearField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string Days
		{
			get
			{
				return this.daysField;
			}
			set
			{
				this.daysField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
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