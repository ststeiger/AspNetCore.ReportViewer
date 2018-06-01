
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
	public class DaysOfWeekSelector
	{
		private bool sundayField;

		private bool mondayField;

		private bool tuesdayField;

		private bool wednesdayField;

		private bool thursdayField;

		private bool fridayField;

		private bool saturdayField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public bool Sunday
		{
			get
			{
				return this.sundayField;
			}
			set
			{
				this.sundayField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public bool Monday
		{
			get
			{
				return this.mondayField;
			}
			set
			{
				this.mondayField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public bool Tuesday
		{
			get
			{
				return this.tuesdayField;
			}
			set
			{
				this.tuesdayField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public bool Wednesday
		{
			get
			{
				return this.wednesdayField;
			}
			set
			{
				this.wednesdayField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public bool Thursday
		{
			get
			{
				return this.thursdayField;
			}
			set
			{
				this.thursdayField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public bool Friday
		{
			get
			{
				return this.fridayField;
			}
			set
			{
				this.fridayField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 6)]
		public bool Saturday
		{
			get
			{
				return this.saturdayField;
			}
			set
			{
				this.saturdayField = value;
			}
		}
	}
}