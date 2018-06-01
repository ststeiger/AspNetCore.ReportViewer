

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
	public class DataRetrievalPlan
	{
		private DataSourceDefinitionOrReference itemField;

		private DataSetDefinition dataSetField;

		/// <remarks />
		[XmlElement("DataSourceDefinition", typeof(DataSourceDefinition), Order = 0)]
		[XmlElement("DataSourceReference", typeof(DataSourceReference), Order = 0)]
		[XmlElement("InvalidDataSourceReference", typeof(InvalidDataSourceReference), Order = 0)]
		public DataSourceDefinitionOrReference Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public DataSetDefinition DataSet
		{
			get
			{
				return this.dataSetField;
			}
			set
			{
				this.dataSetField = value;
			}
		}
	}
}
