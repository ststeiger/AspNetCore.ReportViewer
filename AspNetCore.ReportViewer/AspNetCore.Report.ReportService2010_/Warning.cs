

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
	public class Warning
	{
		private string codeField;

		private string severityField;

		private string objectNameField;

		private string objectTypeField;

		private string messageField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string Code
		{
			get
			{
				return this.codeField;
			}
			set
			{
				this.codeField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public string Severity
		{
			get
			{
				return this.severityField;
			}
			set
			{
				this.severityField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public string ObjectName
		{
			get
			{
				return this.objectNameField;
			}
			set
			{
				this.objectNameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public string ObjectType
		{
			get
			{
				return this.objectTypeField;
			}
			set
			{
				this.objectTypeField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public string Message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
			}
		}
	}
}
