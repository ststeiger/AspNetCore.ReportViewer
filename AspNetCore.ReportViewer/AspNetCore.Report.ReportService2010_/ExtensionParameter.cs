
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
	public class ExtensionParameter
	{
		private string nameField;

		private string displayNameField;

		private bool requiredField;

		private bool requiredFieldSpecified;

		private bool readOnlyField;

		private string valueField;

		private string errorField;

		private bool encryptedField;

		private bool isPasswordField;

		private ValidValue[] validValuesField;

		/// <remarks />
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public string DisplayName
		{
			get
			{
				return this.displayNameField;
			}
			set
			{
				this.displayNameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public bool Required
		{
			get
			{
				return this.requiredField;
			}
			set
			{
				this.requiredField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool RequiredSpecified
		{
			get
			{
				return this.requiredFieldSpecified;
			}
			set
			{
				this.requiredFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public bool ReadOnly
		{
			get
			{
				return this.readOnlyField;
			}
			set
			{
				this.readOnlyField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public string Error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 6)]
		public bool Encrypted
		{
			get
			{
				return this.encryptedField;
			}
			set
			{
				this.encryptedField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 7)]
		public bool IsPassword
		{
			get
			{
				return this.isPasswordField;
			}
			set
			{
				this.isPasswordField = value;
			}
		}

		/// <remarks />
		[XmlArray(Order = 8)]
		[XmlArrayItem("Value")]
		public ValidValue[] ValidValues
		{
			get
			{
				return this.validValuesField;
			}
			set
			{
				this.validValuesField = value;
			}
		}
	}
}