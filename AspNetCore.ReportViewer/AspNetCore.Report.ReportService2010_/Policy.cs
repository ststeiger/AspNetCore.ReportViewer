
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
	public class Policy
	{
		private string groupUserNameField;

		private Role[] rolesField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string GroupUserName
		{
			get
			{
				return this.groupUserNameField;
			}
			set
			{
				this.groupUserNameField = value;
			}
		}

		/// <remarks />
		[XmlArray(Order = 1)]
		public Role[] Roles
		{
			get
			{
				return this.rolesField;
			}
			set
			{
				this.rolesField = value;
			}
		}
	}
}