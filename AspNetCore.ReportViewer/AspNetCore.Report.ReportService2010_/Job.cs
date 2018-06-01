
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
	public class Job
	{
		private string jobIDField;

		private string nameField;

		private string pathField;

		private string descriptionField;

		private string machineField;

		private string userField;

		private System.DateTime startDateTimeField;

		private string jobActionNameField;

		private string jobTypeNameField;

		private string jobStatusNameField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string JobID
		{
			get
			{
				return this.jobIDField;
			}
			set
			{
				this.jobIDField = value;
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
		public string Machine
		{
			get
			{
				return this.machineField;
			}
			set
			{
				this.machineField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public string User
		{
			get
			{
				return this.userField;
			}
			set
			{
				this.userField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 6)]
		public System.DateTime StartDateTime
		{
			get
			{
				return this.startDateTimeField;
			}
			set
			{
				this.startDateTimeField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 7)]
		public string JobActionName
		{
			get
			{
				return this.jobActionNameField;
			}
			set
			{
				this.jobActionNameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 8)]
		public string JobTypeName
		{
			get
			{
				return this.jobTypeNameField;
			}
			set
			{
				this.jobTypeNameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 9)]
		public string JobStatusName
		{
			get
			{
				return this.jobStatusNameField;
			}
			set
			{
				this.jobStatusNameField = value;
			}
		}
	}
}