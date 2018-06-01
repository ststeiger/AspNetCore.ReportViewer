
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
	public class ParametersGridLayoutDefinition
	{
		private int numberOfColumnsField;

		private int numberOfRowsField;

		private ParametersGridCellDefinition[] cellDefinitionsField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public int NumberOfColumns
		{
			get
			{
				return this.numberOfColumnsField;
			}
			set
			{
				this.numberOfColumnsField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public int NumberOfRows
		{
			get
			{
				return this.numberOfRowsField;
			}
			set
			{
				this.numberOfRowsField = value;
			}
		}

		/// <remarks />
		[XmlArray(Order = 2)]
		public ParametersGridCellDefinition[] CellDefinitions
		{
			get
			{
				return this.cellDefinitionsField;
			}
			set
			{
				this.cellDefinitionsField = value;
			}
		}
	}
}