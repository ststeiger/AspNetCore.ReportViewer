
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportExecutionService
{
	/// <remarks />
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
	public class ReportMargins
	{
		private double topField;

		private double bottomField;

		private double leftField;

		private double rightField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public double Top
		{
			get
			{
				return this.topField;
			}
			set
			{
				this.topField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public double Bottom
		{
			get
			{
				return this.bottomField;
			}
			set
			{
				this.bottomField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public double Left
		{
			get
			{
				return this.leftField;
			}
			set
			{
				this.leftField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public double Right
		{
			get
			{
				return this.rightField;
			}
			set
			{
				this.rightField = value;
			}
		}
	}
}