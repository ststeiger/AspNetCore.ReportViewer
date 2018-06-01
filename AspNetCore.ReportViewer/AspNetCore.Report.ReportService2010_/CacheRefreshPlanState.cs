
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
	public class CacheRefreshPlanState
	{
		private bool missingParameterValueField;

		private bool invalidParameterValueField;

		private bool unknownItemParameterField;

		private bool cachingNotEnabledOnItemField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public bool MissingParameterValue
		{
			get
			{
				return this.missingParameterValueField;
			}
			set
			{
				this.missingParameterValueField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public bool InvalidParameterValue
		{
			get
			{
				return this.invalidParameterValueField;
			}
			set
			{
				this.invalidParameterValueField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public bool UnknownItemParameter
		{
			get
			{
				return this.unknownItemParameterField;
			}
			set
			{
				this.unknownItemParameterField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public bool CachingNotEnabledOnItem
		{
			get
			{
				return this.cachingNotEnabledOnItemField;
			}
			set
			{
				this.cachingNotEnabledOnItemField = value;
			}
		}
	}
}
