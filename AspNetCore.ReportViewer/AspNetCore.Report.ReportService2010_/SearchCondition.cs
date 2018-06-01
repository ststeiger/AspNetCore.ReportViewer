
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
	public class SearchCondition
	{
		private ConditionEnum conditionField;

		private bool conditionFieldSpecified;

		private string[] valuesField;

		private string nameField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public ConditionEnum Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool ConditionSpecified
		{
			get
			{
				return this.conditionFieldSpecified;
			}
			set
			{
				this.conditionFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlArray(Order = 1)]
		[XmlArrayItem("Value")]
		public string[] Values
		{
			get
			{
				return this.valuesField;
			}
			set
			{
				this.valuesField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
	}
}