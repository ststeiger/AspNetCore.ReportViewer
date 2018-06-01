
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
	public class Subscription
	{
		private string subscriptionIDField;

		private string ownerField;

		private string pathField;

		private string virtualPathField;

		private string reportField;

		private ExtensionSettings deliverySettingsField;

		private string descriptionField;

		private string statusField;

		private ActiveState activeField;

		private System.DateTime lastExecutedField;

		private bool lastExecutedFieldSpecified;

		private string modifiedByField;

		private System.DateTime modifiedDateField;

		private string eventTypeField;

		private bool isDataDrivenField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string SubscriptionID
		{
			get
			{
				return this.subscriptionIDField;
			}
			set
			{
				this.subscriptionIDField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public string Owner
		{
			get
			{
				return this.ownerField;
			}
			set
			{
				this.ownerField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public string Path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public string VirtualPath
		{
			get
			{
				return this.virtualPathField;
			}
			set
			{
				this.virtualPathField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public string Report
		{
			get
			{
				return this.reportField;
			}
			set
			{
				this.reportField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public ExtensionSettings DeliverySettings
		{
			get
			{
				return this.deliverySettingsField;
			}
			set
			{
				this.deliverySettingsField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
		public string Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 8)]
		public ActiveState Active
		{
			get
			{
				return this.activeField;
			}
			set
			{
				this.activeField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 9)]
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
		[XmlIgnore]
		public bool LastExecutedSpecified
		{
			get
			{
				return this.lastExecutedFieldSpecified;
			}
			set
			{
				this.lastExecutedFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
		public string EventType
		{
			get
			{
				return this.eventTypeField;
			}
			set
			{
				this.eventTypeField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 13)]
		public bool IsDataDriven
		{
			get
			{
				return this.isDataDrivenField;
			}
			set
			{
				this.isDataDrivenField = value;
			}
		}
	}
}
