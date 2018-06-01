
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
	public class CacheRefreshPlan
	{
		private string cacheRefreshPlanIDField;

		private string itemPathField;

		private string descriptionField;

		private CacheRefreshPlanState stateField;

		private System.DateTime lastExecutedField;

		private System.DateTime modifiedDateField;

		private string modifiedByField;

		private string lastRunStatusField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string CacheRefreshPlanID
		{
			get
			{
				return this.cacheRefreshPlanIDField;
			}
			set
			{
				this.cacheRefreshPlanIDField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public string ItemPath
		{
			get
			{
				return this.itemPathField;
			}
			set
			{
				this.itemPathField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public CacheRefreshPlanState State
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public System.DateTime LastExecuted
		{
			get
			{
				return this.lastExecutedField;
			}
			set
			{
				this.lastExecutedField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this.modifiedDateField;
			}
			set
			{
				this.modifiedDateField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 6)]
		public string ModifiedBy
		{
			get
			{
				return this.modifiedByField;
			}
			set
			{
				this.modifiedByField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 7)]
		public string LastRunStatus
		{
			get
			{
				return this.lastRunStatusField;
			}
			set
			{
				this.lastRunStatusField = value;
			}
		}
	}
}
