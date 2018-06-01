
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
	public class ActiveState
	{
		private bool deliveryExtensionRemovedField;

		private bool deliveryExtensionRemovedFieldSpecified;

		private bool sharedDataSourceRemovedField;

		private bool sharedDataSourceRemovedFieldSpecified;

		private bool missingParameterValueField;

		private bool missingParameterValueFieldSpecified;

		private bool invalidParameterValueField;

		private bool invalidParameterValueFieldSpecified;

		private bool unknownReportParameterField;

		private bool unknownReportParameterFieldSpecified;

		private bool disabledByUserField;

		private bool disabledByUserFieldSpecified;

		/// <remarks />
		[XmlElement(Order = 0)]
		public bool DeliveryExtensionRemoved
		{
			get
			{
				return this.deliveryExtensionRemovedField;
			}
			set
			{
				this.deliveryExtensionRemovedField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool DeliveryExtensionRemovedSpecified
		{
			get
			{
				return this.deliveryExtensionRemovedFieldSpecified;
			}
			set
			{
				this.deliveryExtensionRemovedFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public bool SharedDataSourceRemoved
		{
			get
			{
				return this.sharedDataSourceRemovedField;
			}
			set
			{
				this.sharedDataSourceRemovedField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool SharedDataSourceRemovedSpecified
		{
			get
			{
				return this.sharedDataSourceRemovedFieldSpecified;
			}
			set
			{
				this.sharedDataSourceRemovedFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public bool MissingParameterValue
		{
			get
			{
				return this.missingParameterValueField;
			}
			set
			{
				this.missingParameterValueField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool MissingParameterValueSpecified
		{
			get
			{
				return this.missingParameterValueFieldSpecified;
			}
			set
			{
				this.missingParameterValueFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public bool InvalidParameterValue
		{
			get
			{
				return this.invalidParameterValueField;
			}
			set
			{
				this.invalidParameterValueField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool InvalidParameterValueSpecified
		{
			get
			{
				return this.invalidParameterValueFieldSpecified;
			}
			set
			{
				this.invalidParameterValueFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public bool UnknownReportParameter
		{
			get
			{
				return this.unknownReportParameterField;
			}
			set
			{
				this.unknownReportParameterField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool UnknownReportParameterSpecified
		{
			get
			{
				return this.unknownReportParameterFieldSpecified;
			}
			set
			{
				this.unknownReportParameterFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public bool DisabledByUser
		{
			get
			{
				return this.disabledByUserField;
			}
			set
			{
				this.disabledByUserField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool DisabledByUserSpecified
		{
			get
			{
				return this.disabledByUserFieldSpecified;
			}
			set
			{
				this.disabledByUserFieldSpecified = value;
			}
		}
	}
}
