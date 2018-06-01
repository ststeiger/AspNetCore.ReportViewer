
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
	public class QueryDefinition
	{
		private string commandTypeField;

		private string commandTextField;

		private int timeoutField;

		private bool timeoutFieldSpecified;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string CommandType
		{
			get
			{
				return this.commandTypeField;
			}
			set
			{
				this.commandTypeField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public string CommandText
		{
			get
			{
				return this.commandTextField;
			}
			set
			{
				this.commandTextField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public int Timeout
		{
			get
			{
				return this.timeoutField;
			}
			set
			{
				this.timeoutField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool TimeoutSpecified
		{
			get
			{
				return this.timeoutFieldSpecified;
			}
			set
			{
				this.timeoutFieldSpecified = value;
			}
		}
	}
}