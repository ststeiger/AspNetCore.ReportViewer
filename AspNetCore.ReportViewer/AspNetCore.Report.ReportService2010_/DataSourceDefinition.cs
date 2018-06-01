
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
	public class DataSourceDefinition : DataSourceDefinitionOrReference
	{
		private string extensionField;

		private string connectStringField;

		private bool useOriginalConnectStringField;

		private bool originalConnectStringExpressionBasedField;

		private CredentialRetrievalEnum credentialRetrievalField;

		private bool windowsCredentialsField;

		private bool impersonateUserField;

		private bool impersonateUserFieldSpecified;

		private string promptField;

		private string userNameField;

		private string passwordField;

		private bool enabledField;

		private bool enabledFieldSpecified;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string Extension
		{
			get
			{
				return this.extensionField;
			}
			set
			{
				this.extensionField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public string ConnectString
		{
			get
			{
				return this.connectStringField;
			}
			set
			{
				this.connectStringField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public bool UseOriginalConnectString
		{
			get
			{
				return this.useOriginalConnectStringField;
			}
			set
			{
				this.useOriginalConnectStringField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public bool OriginalConnectStringExpressionBased
		{
			get
			{
				return this.originalConnectStringExpressionBasedField;
			}
			set
			{
				this.originalConnectStringExpressionBasedField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public CredentialRetrievalEnum CredentialRetrieval
		{
			get
			{
				return this.credentialRetrievalField;
			}
			set
			{
				this.credentialRetrievalField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public bool WindowsCredentials
		{
			get
			{
				return this.windowsCredentialsField;
			}
			set
			{
				this.windowsCredentialsField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 6)]
		public bool ImpersonateUser
		{
			get
			{
				return this.impersonateUserField;
			}
			set
			{
				this.impersonateUserField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool ImpersonateUserSpecified
		{
			get
			{
				return this.impersonateUserFieldSpecified;
			}
			set
			{
				this.impersonateUserFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 7)]
		public string Prompt
		{
			get
			{
				return this.promptField;
			}
			set
			{
				this.promptField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 8)]
		public string UserName
		{
			get
			{
				return this.userNameField;
			}
			set
			{
				this.userNameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 9)]
		public string Password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 10)]
		public bool Enabled
		{
			get
			{
				return this.enabledField;
			}
			set
			{
				this.enabledField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool EnabledSpecified
		{
			get
			{
				return this.enabledFieldSpecified;
			}
			set
			{
				this.enabledFieldSpecified = value;
			}
		}
	}
}
