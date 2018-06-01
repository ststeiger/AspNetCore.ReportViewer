
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
	public class MonthsOfYearSelector
	{
		private bool januaryField;

		private bool februaryField;

		private bool marchField;

		private bool aprilField;

		private bool mayField;

		private bool juneField;

		private bool julyField;

		private bool augustField;

		private bool septemberField;

		private bool octoberField;

		private bool novemberField;

		private bool decemberField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public bool January
		{
			get
			{
				return this.januaryField;
			}
			set
			{
				this.januaryField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public bool February
		{
			get
			{
				return this.februaryField;
			}
			set
			{
				this.februaryField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public bool March
		{
			get
			{
				return this.marchField;
			}
			set
			{
				this.marchField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public bool April
		{
			get
			{
				return this.aprilField;
			}
			set
			{
				this.aprilField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public bool May
		{
			get
			{
				return this.mayField;
			}
			set
			{
				this.mayField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public bool June
		{
			get
			{
				return this.juneField;
			}
			set
			{
				this.juneField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 6)]
		public bool July
		{
			get
			{
				return this.julyField;
			}
			set
			{
				this.julyField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 7)]
		public bool August
		{
			get
			{
				return this.augustField;
			}
			set
			{
				this.augustField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 8)]
		public bool September
		{
			get
			{
				return this.septemberField;
			}
			set
			{
				this.septemberField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 9)]
		public bool October
		{
			get
			{
				return this.octoberField;
			}
			set
			{
				this.octoberField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 10)]
		public bool November
		{
			get
			{
				return this.novemberField;
			}
			set
			{
				this.novemberField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 11)]
		public bool December
		{
			get
			{
				return this.decemberField;
			}
			set
			{
				this.decemberField = value;
			}
		}
	}
}