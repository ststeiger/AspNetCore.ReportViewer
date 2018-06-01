
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;


namespace AspNetCore.Report.ReportExecutionService
{
	/// <remarks />
	[XmlInclude(typeof(ExecutionInfo2))]
	[XmlInclude(typeof(ExecutionInfo3))]
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
	public class ExecutionInfo
	{
		private bool hasSnapshotField;

		private bool needsProcessingField;

		private bool allowQueryExecutionField;

		private bool credentialsRequiredField;

		private bool parametersRequiredField;

		private System.DateTime expirationDateTimeField;

		private System.DateTime executionDateTimeField;

		private int numPagesField;

		private ReportParameter[] parametersField;

		private DataSourcePrompt[] dataSourcePromptsField;

		private bool hasDocumentMapField;

		private string executionIDField;

		private string reportPathField;

		private string historyIDField;

		private PageSettings reportPageSettingsField;

		private int autoRefreshIntervalField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public bool HasSnapshot
		{
			get
			{
				return this.hasSnapshotField;
			}
			set
			{
				this.hasSnapshotField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public bool NeedsProcessing
		{
			get
			{
				return this.needsProcessingField;
			}
			set
			{
				this.needsProcessingField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public bool AllowQueryExecution
		{
			get
			{
				return this.allowQueryExecutionField;
			}
			set
			{
				this.allowQueryExecutionField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public bool CredentialsRequired
		{
			get
			{
				return this.credentialsRequiredField;
			}
			set
			{
				this.credentialsRequiredField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public bool ParametersRequired
		{
			get
			{
				return this.parametersRequiredField;
			}
			set
			{
				this.parametersRequiredField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public System.DateTime ExpirationDateTime
		{
			get
			{
				return this.expirationDateTimeField;
			}
			set
			{
				this.expirationDateTimeField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 6)]
		public System.DateTime ExecutionDateTime
		{
			get
			{
				return this.executionDateTimeField;
			}
			set
			{
				this.executionDateTimeField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 7)]
		public int NumPages
		{
			get
			{
				return this.numPagesField;
			}
			set
			{
				this.numPagesField = value;
			}
		}

		/// <remarks />
		[XmlArray(Order = 8)]
		public ReportParameter[] Parameters
		{
			get
			{
				return this.parametersField;
			}
			set
			{
				this.parametersField = value;
			}
		}

		/// <remarks />
		[XmlArray(Order = 9)]
		public DataSourcePrompt[] DataSourcePrompts
		{
			get
			{
				return this.dataSourcePromptsField;
			}
			set
			{
				this.dataSourcePromptsField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 10)]
		public bool HasDocumentMap
		{
			get
			{
				return this.hasDocumentMapField;
			}
			set
			{
				this.hasDocumentMapField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 11)]
		public string ExecutionID
		{
			get
			{
				return this.executionIDField;
			}
			set
			{
				this.executionIDField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 12)]
		public string ReportPath
		{
			get
			{
				return this.reportPathField;
			}
			set
			{
				this.reportPathField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
		public PageSettings ReportPageSettings
		{
			get
			{
				return this.reportPageSettingsField;
			}
			set
			{
				this.reportPageSettingsField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 15)]
		public int AutoRefreshInterval
		{
			get
			{
				return this.autoRefreshIntervalField;
			}
			set
			{
				this.autoRefreshIntervalField = value;
			}
		}
	}
}