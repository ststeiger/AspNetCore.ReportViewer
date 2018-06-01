
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;


namespace AspNetCore.Report.ReportExecutionService
{
	/// <remarks />
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
	public class Extension
	{
		private ExtensionTypeEnum extensionTypeField;

		private string nameField;

		private string localizedNameField;

		private bool visibleField;

		private bool isModelGenerationSupportedField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public ExtensionTypeEnum ExtensionType
		{
			get
			{
				return this.extensionTypeField;
			}
			set
			{
				this.extensionTypeField = value;
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