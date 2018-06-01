

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
	public class Extension
	{
		private string extensionTypeNameField;

		private string nameField;

		private string localizedNameField;

		private bool visibleField;

		private bool isModelGenerationSupportedField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string ExtensionTypeName
		{
			get
			{
				return this.extensionTypeNameField;
			}
			set
			{
				this.extensionTypeNameField = value;
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
		public string LocalizedName
		{
			get
			{
				return this.localizedNameField;
			}
			set
			{
				this.localizedNameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public bool Visible
		{
			get
			{
				return this.visibleField;
			}
			set
			{
				this.visibleField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public bool IsModelGenerationSupported
		{
			get
			{
				return this.isModelGenerationSupportedField;
			}
			set
			{
				this.isModelGenerationSupportedField = value;
			}
		}
	}
}
