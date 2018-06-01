

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
	public class DataSourceCredentials
	{
		private string dataSourceNameField;

		private string userNameField;

		private string passwordField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string DataSourceName
		{
			get
			{
				return this.dataSourceNameField;
			}
			set
			{
				this.dataSourceNameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
	}
}
