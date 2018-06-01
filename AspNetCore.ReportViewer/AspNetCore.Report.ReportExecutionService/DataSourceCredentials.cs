
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
