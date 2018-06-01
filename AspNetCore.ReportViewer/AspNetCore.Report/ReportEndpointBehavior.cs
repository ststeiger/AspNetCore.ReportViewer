namespace AspNetCore.Report
{
	internal class ReportEndpointBehavior : System.ServiceModel.Description.IEndpointBehavior
	{
		private ReportClientMessageInspector inspector;

		public ReportEndpointBehavior(AspNetCore.Report.ReportExecutionService.ReportExecutionServiceSoapClient client)
		{
			this.inspector = new ReportClientMessageInspector(client);
		}

		public void AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
		{
		}

		public void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
		{
			clientRuntime.ClientMessageInspectors.Add(this.inspector);
		}

		public void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
		{
		}

		public void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint)
		{
		}
	}
}
