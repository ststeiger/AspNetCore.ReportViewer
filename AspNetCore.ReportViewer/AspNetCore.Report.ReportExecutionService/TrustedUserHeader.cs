
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
	public class TrustedUserHeader
	{
		private string userNameField;

		private byte[] userTokenField;

		/// <remarks />
		[XmlElement(Order = 0)]
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
		[XmlElement(DataType = "base64Binary", Order = 1)]
		public byte[] UserToken
		{
			get
			{
				return this.userTokenField;
			}
			set
			{
				this.userTokenField = value;
			}
		}
	}
}