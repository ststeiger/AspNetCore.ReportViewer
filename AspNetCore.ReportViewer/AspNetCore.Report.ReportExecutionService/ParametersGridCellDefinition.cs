
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
	public class ParametersGridCellDefinition
	{
		private int rowIndexField;

		private int columnsIndexField;

		private string parameterNameField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public int RowIndex
		{
			get
			{
				return this.rowIndexField;
			}
			set
			{
				this.rowIndexField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public int ColumnsIndex
		{
			get
			{
				return this.columnsIndexField;
			}
			set
			{
				this.columnsIndexField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public string ParameterName
		{
			get
			{
				return this.parameterNameField;
			}
			set
			{
				this.parameterNameField = value;
			}
		}
	}
}