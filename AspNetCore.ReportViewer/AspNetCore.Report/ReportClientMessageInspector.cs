namespace AspNetCore.Report
{
	internal class ReportClientMessageInspector : System.ServiceModel.Dispatcher.IClientMessageInspector
	{
		private AspNetCore.Report.ReportExecutionService.ReportExecutionServiceSoapClient client;

		public ReportClientMessageInspector(AspNetCore.Report.ReportExecutionService.ReportExecutionServiceSoapClient client)
		{
			this.client = client;
		}

		public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
		{
		}

		public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel)
		{
			request.Headers.Add(new ReportMessageHeader(this.client.ExecutionHeader.ExecutionID));
			return null;
		}
	}
}
