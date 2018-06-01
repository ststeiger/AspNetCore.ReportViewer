
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
	public class TimeZoneInformation
	{
		private int biasField;

		private int standardBiasField;

		private SYSTEMTIME standardDateField;

		private int daylightBiasField;

		private SYSTEMTIME daylightDateField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public int Bias
		{
			get
			{
				return this.biasField;
			}
			set
			{
				this.biasField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public int StandardBias
		{
			get
			{
				return this.standardBiasField;
			}
			set
			{
				this.standardBiasField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public SYSTEMTIME StandardDate
		{
			get
			{
				return this.standardDateField;
			}
			set
			{
				this.standardDateField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public int DaylightBias
		{
			get
			{
				return this.daylightBiasField;
			}
			set
			{
				this.daylightBiasField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public SYSTEMTIME DaylightDate
		{
			get
			{
				return this.daylightDateField;
			}
			set
			{
				this.daylightDateField = value;
			}
		}
	}
}
