
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
	public class Schedule
	{
		private string scheduleIDField;

		private string nameField;

		private ScheduleDefinition definitionField;

		private string descriptionField;

		private string creatorField;

		private System.DateTime nextRunTimeField;

		private bool nextRunTimeFieldSpecified;

		private System.DateTime lastRunTimeField;

		private bool lastRunTimeFieldSpecified;

		private bool referencesPresentField;

		private string scheduleStateNameField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string ScheduleID
		{
			get
			{
				return this.scheduleIDField;
			}
			set
			{
				this.scheduleIDField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
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

		/// <remarks />
		[XmlElement(Order = 2)]
		public ScheduleDefinition Definition
		{
			get
			{
				return this.definitionField;
			}
			set
			{
				this.definitionField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
		public string Creator
		{
			get
			{
				return this.creatorField;
			}
			set
			{
				this.creatorField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public System.DateTime NextRunTime
		{
			get
			{
				return this.nextRunTimeField;
			}
			set
			{
				this.nextRunTimeField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool NextRunTimeSpecified
		{
			get
			{
				return this.nextRunTimeFieldSpecified;
			}
			set
			{
				this.nextRunTimeFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 6)]
		public System.DateTime LastRunTime
		{
			get
			{
				return this.lastRunTimeField;
			}
			set
			{
				this.lastRunTimeField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool LastRunTimeSpecified
		{
			get
			{
				return this.lastRunTimeFieldSpecified;
			}
			set
			{
				this.lastRunTimeFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 7)]
		public bool ReferencesPresent
		{
			get
			{
				return this.referencesPresentField;
			}
			set
			{
				this.referencesPresentField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 8)]
		public string ScheduleStateName
		{
			get
			{
				return this.scheduleStateNameField;
			}
			set
			{
				this.scheduleStateNameField = value;
			}
		}
	}
}