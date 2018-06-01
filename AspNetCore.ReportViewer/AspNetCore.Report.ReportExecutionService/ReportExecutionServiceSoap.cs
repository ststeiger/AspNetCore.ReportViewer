
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportExecutionService
{
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[ServiceContract(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ConfigurationName = "ReportExecutionServiceSoap")]
	public interface ReportExecutionServiceSoap
	{
		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/ListSecureMethods", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		System.Threading.Tasks.Task<ListSecureMethodsResponse> ListSecureMethodsAsync(ListSecureMethodsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/LoadReport", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<LoadReportResponse> LoadReportAsync(LoadReportRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/LoadReport3", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<LoadReport3Response> LoadReport3Async(LoadReport3Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/LoadReport2", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<LoadReport2Response> LoadReport2Async(LoadReport2Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/LoadReportDefinition", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<LoadReportDefinitionResponse> LoadReportDefinitionAsync(LoadReportDefinitionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/LoadReportDefinition2", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<LoadReportDefinition2Response> LoadReportDefinition2Async(LoadReportDefinition2Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/LoadReportDefinition3", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<LoadReportDefinition3Response> LoadReportDefinition3Async(LoadReportDefinition3Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/SetExecutionCredentials", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<SetExecutionCredentialsResponse> SetExecutionCredentialsAsync(SetExecutionCredentialsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/SetExecutionCredentials2", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<SetExecutionCredentials2Response> SetExecutionCredentials2Async(SetExecutionCredentials2Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/SetExecutionCredentials3", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<SetExecutionCredentials3Response> SetExecutionCredentials3Async(SetExecutionCredentials3Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/SetExecutionParameters", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<SetExecutionParametersResponse> SetExecutionParametersAsync(SetExecutionParametersRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/SetExecutionParameters2", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<SetExecutionParameters2Response> SetExecutionParameters2Async(SetExecutionParameters2Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/SetExecutionParameters3", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<SetExecutionParameters3Response> SetExecutionParameters3Async(SetExecutionParameters3Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/ResetExecution", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<ResetExecutionResponse> ResetExecutionAsync(ResetExecutionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/ResetExecution2", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<ResetExecution2Response> ResetExecution2Async(ResetExecution2Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/ResetExecution3", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<ResetExecution3Response> ResetExecution3Async(ResetExecution3Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Render", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<RenderResponse> RenderAsync(RenderRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Render2", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<Render2Response> Render2Async(Render2Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/DeliverReportItem", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<DeliverReportItemResponse> DeliverReportItemAsync(DeliverReportItemRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/RenderStream", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<RenderStreamResponse> RenderStreamAsync(RenderStreamRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/GetExecutionInfo", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<GetExecutionInfoResponse> GetExecutionInfoAsync(GetExecutionInfoRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/GetExecutionInfo2", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<GetExecutionInfo2Response> GetExecutionInfo2Async(GetExecutionInfo2Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/GetExecutionInfo3", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<GetExecutionInfo3Response> GetExecutionInfo3Async(GetExecutionInfo3Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/GetDocumentMap", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<GetDocumentMapResponse> GetDocumentMapAsync(GetDocumentMapRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/LoadDrillthroughTarget", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<LoadDrillthroughTargetResponse> LoadDrillthroughTargetAsync(LoadDrillthroughTargetRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/LoadDrillthroughTarget2", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<LoadDrillthroughTarget2Response> LoadDrillthroughTarget2Async(LoadDrillthroughTarget2Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/LoadDrillthroughTarget3", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<LoadDrillthroughTarget3Response> LoadDrillthroughTarget3Async(LoadDrillthroughTarget3Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/ToggleItem", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<ToggleItemResponse> ToggleItemAsync(ToggleItemRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/NavigateDocumentMap", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<NavigateDocumentMapResponse> NavigateDocumentMapAsync(NavigateDocumentMapRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/NavigateBookmark", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<NavigateBookmarkResponse> NavigateBookmarkAsync(NavigateBookmarkRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/FindString", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<FindStringResponse> FindStringAsync(FindStringRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Sort", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<SortResponse> SortAsync(SortRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Sort2", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<Sort2Response> Sort2Async(Sort2Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Sort3", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<Sort3Response> Sort3Async(Sort3Request request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/GetRenderResource", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<GetRenderResourceResponse> GetRenderResourceAsync(GetRenderResourceRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/ListRenderingExtensions", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<ListRenderingExtensionsResponse> ListRenderingExtensionsAsync(ListRenderingExtensionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/LogonUser", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<LogonUserResponse> LogonUserAsync(LogonUserRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Logoff", ReplyAction = "*")]
		[XmlSerializerFormat(SupportFaults = true)]
		[ServiceKnownType(typeof(ParameterValueOrFieldReference))]
		System.Threading.Tasks.Task<LogoffResponse> LogoffAsync(LogoffRequest request);
	}
}