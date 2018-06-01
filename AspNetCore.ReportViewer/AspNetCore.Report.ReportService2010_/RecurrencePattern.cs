
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
	[XmlInclude(typeof(WeeklyRecurrence))]
	[XmlInclude(typeof(MonthlyRecurrence))]
	[XmlInclude(typeof(MinuteRecurrence))]
	[XmlInclude(typeof(MonthlyDOWRecurrence))]
	[XmlInclude(typeof(DailyRecurrence))]
	[GeneratedCode("svcutil", "4.6.1055.0")]
	[DataContract]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
	public class RecurrencePattern
	{
	}
}