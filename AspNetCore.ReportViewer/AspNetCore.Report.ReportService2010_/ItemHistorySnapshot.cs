
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
	public class ItemHistorySnapshot
	{
		private string historyIDField;

		private System.DateTime creationDateField;

		private int sizeField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string HistoryID
		{
			get
			{
				return this.historyIDField;
			}
			set
			{
				this.historyIDField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public System.DateTime CreationDate
		{
			get
			{
				return this.creationDateField;
			}
			set
			{
				this.creationDateField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public int Size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
			}
		}
	}
}