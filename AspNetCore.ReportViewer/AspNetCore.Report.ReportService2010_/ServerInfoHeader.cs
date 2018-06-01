
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
	public class ServerInfoHeader
	{
		private string reportServerVersionNumberField;

		private string reportServerEditionField;

		private string reportServerVersionField;

		private string reportServerDateTimeField;

		private TimeZoneInformation reportServerTimeZoneInfoField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string ReportServerVersionNumber
		{
			get
			{
				return this.reportServerVersionNumberField;
			}
			set
			{
				this.reportServerVersionNumberField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public string ReportServerEdition
		{
			get
			{
				return this.reportServerEditionField;
			}
			set
			{
				this.reportServerEditionField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public string ReportServerVersion
		{
			get
			{
				return this.reportServerVersionField;
			}
			set
			{
				this.reportServerVersionField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public string ReportServerDateTime
		{
			get
			{
				return this.reportServerDateTimeField;
			}
			set
			{
				this.reportServerDateTimeField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public TimeZoneInformation ReportServerTimeZoneInfo
		{
			get
			{
				return this.reportServerTimeZoneInfoField;
			}
			set
			{
				this.reportServerTimeZoneInfoField = value;
			}
		}
	}
}