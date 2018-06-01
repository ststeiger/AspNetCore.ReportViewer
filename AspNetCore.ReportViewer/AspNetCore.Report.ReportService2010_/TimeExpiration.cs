
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
	public class TimeExpiration : ExpirationDefinition
	{
		private int minutesField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public int Minutes
		{
			get
			{
				return this.minutesField;
			}
			set
			{
				this.minutesField = value;
			}
		}
	}
}
