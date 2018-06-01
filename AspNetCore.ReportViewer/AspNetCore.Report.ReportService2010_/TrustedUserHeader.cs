

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
