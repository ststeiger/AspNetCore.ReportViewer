namespace AspNetCore.Report
{
	internal class ReportMessageHeader : System.ServiceModel.Channels.MessageHeader
	{
		private readonly string _value;

		private const string _name = "ExecutionHeader";

		private const string _nameSpace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices";

		public override string Name => "ExecutionHeader";

		public override string Namespace => "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices";

		public ReportMessageHeader(string value)
		{
			this._value = value;
		}

		protected override void OnWriteHeaderContents(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion)
		{
			writer.WriteElementString("ExecutionID", this._value);
		}
	}
}
