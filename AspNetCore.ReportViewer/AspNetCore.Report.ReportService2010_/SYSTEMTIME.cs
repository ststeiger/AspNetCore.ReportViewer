
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
	public class SYSTEMTIME
	{
		private short yearField;

		private short monthField;

		private short dayOfWeekField;

		private short dayField;

		private short hourField;

		private short minuteField;

		private short secondField;

		private short millisecondsField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public short year
		{
			get
			{
				return this.yearField;
			}
			set
			{
				this.yearField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public short month
		{
			get
			{
				return this.monthField;
			}
			set
			{
				this.monthField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public short dayOfWeek
		{
			get
			{
				return this.dayOfWeekField;
			}
			set
			{
				this.dayOfWeekField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public short day
		{
			get
			{
				return this.dayField;
			}
			set
			{
				this.dayField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public short hour
		{
			get
			{
				return this.hourField;
			}
			set
			{
				this.hourField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public short minute
		{
			get
			{
				return this.minuteField;
			}
			set
			{
				this.minuteField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 6)]
		public short second
		{
			get
			{
				return this.secondField;
			}
			set
			{
				this.secondField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 7)]
		public short milliseconds
		{
			get
			{
				return this.millisecondsField;
			}
			set
			{
				this.millisecondsField = value;
			}
		}
	}
}
