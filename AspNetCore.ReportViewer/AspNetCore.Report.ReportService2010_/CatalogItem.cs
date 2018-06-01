
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
	public class CatalogItem
	{
		private string idField;

		private string nameField;

		private string pathField;

		private string virtualPathField;

		private string typeNameField;

		private int sizeField;

		private bool sizeFieldSpecified;

		private string descriptionField;

		private bool hiddenField;

		private bool hiddenFieldSpecified;

		private System.DateTime creationDateField;

		private bool creationDateFieldSpecified;

		private System.DateTime modifiedDateField;

		private bool modifiedDateFieldSpecified;

		private string createdByField;

		private string modifiedByField;

		private Property[] itemMetadataField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
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
		public string TypeName
		{
			get
			{
				return this.typeNameField;
			}
			set
			{
				this.typeNameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public int Size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool SizeSpecified
		{
			get
			{
				return this.sizeFieldSpecified;
			}
			set
			{
				this.sizeFieldSpecified = value;
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
		public bool Hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool HiddenSpecified
		{
			get
			{
				return this.hiddenFieldSpecified;
			}
			set
			{
				this.hiddenFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 8)]
		public System.DateTime CreationDate
		{
			get
			{
				return this.creationDateField;
			}
			set
			{
				this.creationDateField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool CreationDateSpecified
		{
			get
			{
				return this.creationDateFieldSpecified;
			}
			set
			{
				this.creationDateFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 9)]
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
		[XmlIgnore]
		public bool ModifiedDateSpecified
		{
			get
			{
				return this.modifiedDateFieldSpecified;
			}
			set
			{
				this.modifiedDateFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 10)]
		public string CreatedBy
		{
			get
			{
				return this.createdByField;
			}
			set
			{
				this.createdByField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 11)]
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
		[XmlArray(Order = 12)]
		public Property[] ItemMetadata
		{
			get
			{
				return this.itemMetadataField;
			}
			set
			{
				this.itemMetadataField = value;
			}
		}
	}
}
