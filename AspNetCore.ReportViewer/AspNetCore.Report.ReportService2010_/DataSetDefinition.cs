
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
	public class DataSetDefinition
	{
		private Field[] fieldsField;

		private QueryDefinition queryField;

		private SensitivityEnum caseSensitivityField;

		private bool caseSensitivityFieldSpecified;

		private string collationField;

		private SensitivityEnum accentSensitivityField;

		private bool accentSensitivityFieldSpecified;

		private SensitivityEnum kanatypeSensitivityField;

		private bool kanatypeSensitivityFieldSpecified;

		private SensitivityEnum widthSensitivityField;

		private bool widthSensitivityFieldSpecified;

		private string nameField;

		/// <remarks />
		[XmlArray(Order = 0)]
		public Field[] Fields
		{
			get
			{
				return this.fieldsField;
			}
			set
			{
				this.fieldsField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public QueryDefinition Query
		{
			get
			{
				return this.queryField;
			}
			set
			{
				this.queryField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public SensitivityEnum CaseSensitivity
		{
			get
			{
				return this.caseSensitivityField;
			}
			set
			{
				this.caseSensitivityField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool CaseSensitivitySpecified
		{
			get
			{
				return this.caseSensitivityFieldSpecified;
			}
			set
			{
				this.caseSensitivityFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public string Collation
		{
			get
			{
				return this.collationField;
			}
			set
			{
				this.collationField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public SensitivityEnum AccentSensitivity
		{
			get
			{
				return this.accentSensitivityField;
			}
			set
			{
				this.accentSensitivityField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool AccentSensitivitySpecified
		{
			get
			{
				return this.accentSensitivityFieldSpecified;
			}
			set
			{
				this.accentSensitivityFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public SensitivityEnum KanatypeSensitivity
		{
			get
			{
				return this.kanatypeSensitivityField;
			}
			set
			{
				this.kanatypeSensitivityField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool KanatypeSensitivitySpecified
		{
			get
			{
				return this.kanatypeSensitivityFieldSpecified;
			}
			set
			{
				this.kanatypeSensitivityFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 6)]
		public SensitivityEnum WidthSensitivity
		{
			get
			{
				return this.widthSensitivityField;
			}
			set
			{
				this.widthSensitivityField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool WidthSensitivitySpecified
		{
			get
			{
				return this.widthSensitivityFieldSpecified;
			}
			set
			{
				this.widthSensitivityFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 7)]
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
