
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[ServiceContract(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ConfigurationName = "ReportingService2010Soap")]
	public interface ReportingService2010Soap
	{
		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateCatalogItem", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		CreateCatalogItemResponse CreateCatalogItem(CreateCatalogItemRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateCatalogItem", ReplyAction = "*")]
		System.Threading.Tasks.Task<CreateCatalogItemResponse> CreateCatalogItemAsync(CreateCatalogItemRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemDefinition", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetItemDefinitionResponse SetItemDefinition(SetItemDefinitionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemDefinition", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetItemDefinitionResponse> SetItemDefinitionAsync(SetItemDefinitionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemDefinition", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetItemDefinitionResponse GetItemDefinition(GetItemDefinitionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemDefinition", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetItemDefinitionResponse> GetItemDefinitionAsync(GetItemDefinitionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemType", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetItemTypeResponse GetItemType(GetItemTypeRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemType", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetItemTypeResponse> GetItemTypeAsync(GetItemTypeRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteItem", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		DeleteItemResponse DeleteItem(DeleteItemRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteItem", ReplyAction = "*")]
		System.Threading.Tasks.Task<DeleteItemResponse> DeleteItemAsync(DeleteItemRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/MoveItem", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		MoveItemResponse MoveItem(MoveItemRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/MoveItem", ReplyAction = "*")]
		System.Threading.Tasks.Task<MoveItemResponse> MoveItemAsync(MoveItemRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/InheritParentSecurity", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		InheritParentSecurityResponse InheritParentSecurity(InheritParentSecurityRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/InheritParentSecurity", ReplyAction = "*")]
		System.Threading.Tasks.Task<InheritParentSecurityResponse> InheritParentSecurityAsync(InheritParentSecurityRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListItemHistory", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListItemHistoryResponse ListItemHistory(ListItemHistoryRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListItemHistory", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListItemHistoryResponse> ListItemHistoryAsync(ListItemHistoryRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListChildren", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListChildrenResponse ListChildren(ListChildrenRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListChildren", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListChildrenResponse> ListChildrenAsync(ListChildrenRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListDependentItems", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListDependentItemsResponse ListDependentItems(ListDependentItemsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListDependentItems", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListDependentItemsResponse> ListDependentItemsAsync(ListDependentItemsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/FindItems", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		FindItemsResponse FindItems(FindItemsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/FindItems", ReplyAction = "*")]
		System.Threading.Tasks.Task<FindItemsResponse> FindItemsAsync(FindItemsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListParents", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListParentsResponse ListParents(ListParentsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListParents", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListParentsResponse> ListParentsAsync(ListParentsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateFolder", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		CreateFolderResponse CreateFolder(CreateFolderRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateFolder", ReplyAction = "*")]
		System.Threading.Tasks.Task<CreateFolderResponse> CreateFolderAsync(CreateFolderRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetPropertiesResponse SetProperties(SetPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetPropertiesResponse> SetPropertiesAsync(SetPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetPropertiesResponse GetProperties(GetPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetPropertiesResponse> GetPropertiesAsync(GetPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemReferences", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetItemReferencesResponse SetItemReferences(SetItemReferencesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemReferences", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetItemReferencesResponse> SetItemReferencesAsync(SetItemReferencesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemReferences", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetItemReferencesResponse GetItemReferences(GetItemReferencesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemReferences", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetItemReferencesResponse> GetItemReferencesAsync(GetItemReferencesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListItemTypes", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListItemTypesResponse ListItemTypes(ListItemTypesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListItemTypes", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListItemTypesResponse> ListItemTypesAsync(ListItemTypesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSubscriptionProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetSubscriptionPropertiesResponse SetSubscriptionProperties(SetSubscriptionPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSubscriptionProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetSubscriptionPropertiesResponse> SetSubscriptionPropertiesAsync(SetSubscriptionPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSubscriptionProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetSubscriptionPropertiesResponse GetSubscriptionProperties(GetSubscriptionPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSubscriptionProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetSubscriptionPropertiesResponse> GetSubscriptionPropertiesAsync(GetSubscriptionPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetDataDrivenSubscriptionProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetDataDrivenSubscriptionPropertiesResponse SetDataDrivenSubscriptionProperties(SetDataDrivenSubscriptionPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetDataDrivenSubscriptionProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetDataDrivenSubscriptionPropertiesResponse> SetDataDrivenSubscriptionPropertiesAsync(SetDataDrivenSubscriptionPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetDataDrivenSubscriptionProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetDataDrivenSubscriptionPropertiesResponse GetDataDrivenSubscriptionProperties(GetDataDrivenSubscriptionPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetDataDrivenSubscriptionProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetDataDrivenSubscriptionPropertiesResponse> GetDataDrivenSubscriptionPropertiesAsync(GetDataDrivenSubscriptionPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DisableSubscription", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		DisableSubscriptionResponse DisableSubscription(DisableSubscriptionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DisableSubscription", ReplyAction = "*")]
		System.Threading.Tasks.Task<DisableSubscriptionResponse> DisableSubscriptionAsync(DisableSubscriptionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/EnableSubscription", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		EnableSubscriptionResponse EnableSubscription(EnableSubscriptionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/EnableSubscription", ReplyAction = "*")]
		System.Threading.Tasks.Task<EnableSubscriptionResponse> EnableSubscriptionAsync(EnableSubscriptionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteSubscription", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		DeleteSubscriptionResponse DeleteSubscription(DeleteSubscriptionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteSubscription", ReplyAction = "*")]
		System.Threading.Tasks.Task<DeleteSubscriptionResponse> DeleteSubscriptionAsync(DeleteSubscriptionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateSubscription", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateSubscription", ReplyAction = "*")]
		System.Threading.Tasks.Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateDataDrivenSubscription", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		CreateDataDrivenSubscriptionResponse CreateDataDrivenSubscription(CreateDataDrivenSubscriptionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateDataDrivenSubscription", ReplyAction = "*")]
		System.Threading.Tasks.Task<CreateDataDrivenSubscriptionResponse> CreateDataDrivenSubscriptionAsync(CreateDataDrivenSubscriptionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetExtensionSettings", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetExtensionSettingsResponse GetExtensionSettings(GetExtensionSettingsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetExtensionSettings", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetExtensionSettingsResponse> GetExtensionSettingsAsync(GetExtensionSettingsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ValidateExtensionSettings", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ValidateExtensionSettingsResponse ValidateExtensionSettings(ValidateExtensionSettingsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ValidateExtensionSettings", ReplyAction = "*")]
		System.Threading.Tasks.Task<ValidateExtensionSettingsResponse> ValidateExtensionSettingsAsync(ValidateExtensionSettingsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSubscriptions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSubscriptions", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListMySubscriptions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListMySubscriptionsResponse ListMySubscriptions(ListMySubscriptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListMySubscriptions", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListMySubscriptionsResponse> ListMySubscriptionsAsync(ListMySubscriptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSubscriptionsUsingDataSource", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListSubscriptionsUsingDataSourceResponse ListSubscriptionsUsingDataSource(ListSubscriptionsUsingDataSourceRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSubscriptionsUsingDataSource", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListSubscriptionsUsingDataSourceResponse> ListSubscriptionsUsingDataSourceAsync(ListSubscriptionsUsingDataSourceRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ChangeSubscriptionOwner", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ChangeSubscriptionOwnerResponse ChangeSubscriptionOwner(ChangeSubscriptionOwnerRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ChangeSubscriptionOwner", ReplyAction = "*")]
		System.Threading.Tasks.Task<ChangeSubscriptionOwnerResponse> ChangeSubscriptionOwnerAsync(ChangeSubscriptionOwnerRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateDataSource", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateDataSource", ReplyAction = "*")]
		System.Threading.Tasks.Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/PrepareQuery", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		PrepareQueryResponse PrepareQuery(PrepareQueryRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/PrepareQuery", ReplyAction = "*")]
		System.Threading.Tasks.Task<PrepareQueryResponse> PrepareQueryAsync(PrepareQueryRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/EnableDataSource", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		EnableDataSourceResponse EnableDataSource(EnableDataSourceRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/EnableDataSource", ReplyAction = "*")]
		System.Threading.Tasks.Task<EnableDataSourceResponse> EnableDataSourceAsync(EnableDataSourceRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DisableDataSource", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		DisableDataSourceResponse DisableDataSource(DisableDataSourceRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DisableDataSource", ReplyAction = "*")]
		System.Threading.Tasks.Task<DisableDataSourceResponse> DisableDataSourceAsync(DisableDataSourceRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetDataSourceContents", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetDataSourceContentsResponse SetDataSourceContents(SetDataSourceContentsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetDataSourceContents", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetDataSourceContentsResponse> SetDataSourceContentsAsync(SetDataSourceContentsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetDataSourceContents", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetDataSourceContentsResponse GetDataSourceContents(GetDataSourceContentsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetDataSourceContents", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetDataSourceContentsResponse> GetDataSourceContentsAsync(GetDataSourceContentsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListDatabaseCredentialRetrievalOptions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListDatabaseCredentialRetrievalOptionsResponse ListDatabaseCredentialRetrievalOptions(ListDatabaseCredentialRetrievalOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListDatabaseCredentialRetrievalOptions", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListDatabaseCredentialRetrievalOptionsResponse> ListDatabaseCredentialRetrievalOptionsAsync(ListDatabaseCredentialRetrievalOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemDataSources", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetItemDataSourcesResponse SetItemDataSources(SetItemDataSourcesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemDataSources", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetItemDataSourcesResponse> SetItemDataSourcesAsync(SetItemDataSourcesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemDataSources", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetItemDataSourcesResponse GetItemDataSources(GetItemDataSourcesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemDataSources", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetItemDataSourcesResponse> GetItemDataSourcesAsync(GetItemDataSourcesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/TestConnectForDataSourceDefinition", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		TestConnectForDataSourceDefinitionResponse TestConnectForDataSourceDefinition(TestConnectForDataSourceDefinitionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/TestConnectForDataSourceDefinition", ReplyAction = "*")]
		System.Threading.Tasks.Task<TestConnectForDataSourceDefinitionResponse> TestConnectForDataSourceDefinitionAsync(TestConnectForDataSourceDefinitionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/TestConnectForItemDataSource", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		TestConnectForItemDataSourceResponse TestConnectForItemDataSource(TestConnectForItemDataSourceRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/TestConnectForItemDataSource", ReplyAction = "*")]
		System.Threading.Tasks.Task<TestConnectForItemDataSourceResponse> TestConnectForItemDataSourceAsync(TestConnectForItemDataSourceRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateRole", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		CreateRoleResponse CreateRole(CreateRoleRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateRole", ReplyAction = "*")]
		System.Threading.Tasks.Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetRoleProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetRolePropertiesResponse SetRoleProperties(SetRolePropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetRoleProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetRolePropertiesResponse> SetRolePropertiesAsync(SetRolePropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetRoleProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetRolePropertiesResponse GetRoleProperties(GetRolePropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetRoleProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetRolePropertiesResponse> GetRolePropertiesAsync(GetRolePropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteRole", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		DeleteRoleResponse DeleteRole(DeleteRoleRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteRole", ReplyAction = "*")]
		System.Threading.Tasks.Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListRoles", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListRolesResponse ListRoles(ListRolesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListRoles", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListTasks", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListTasksResponse ListTasks(ListTasksRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListTasks", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetPolicies", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetPoliciesResponse SetPolicies(SetPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetPolicies", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetPoliciesResponse> SetPoliciesAsync(SetPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetPolicies", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetPoliciesResponse GetPolicies(GetPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetPolicies", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetPoliciesResponse> GetPoliciesAsync(GetPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemDataSourcePrompts", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetItemDataSourcePromptsResponse GetItemDataSourcePrompts(GetItemDataSourcePromptsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemDataSourcePrompts", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetItemDataSourcePromptsResponse> GetItemDataSourcePromptsAsync(GetItemDataSourcePromptsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GenerateModel", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GenerateModelResponse GenerateModel(GenerateModelRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GenerateModel", ReplyAction = "*")]
		System.Threading.Tasks.Task<GenerateModelResponse> GenerateModelAsync(GenerateModelRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetModelItemPermissions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetModelItemPermissionsResponse GetModelItemPermissions(GetModelItemPermissionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetModelItemPermissions", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetModelItemPermissionsResponse> GetModelItemPermissionsAsync(GetModelItemPermissionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetModelItemPolicies", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetModelItemPoliciesResponse SetModelItemPolicies(SetModelItemPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetModelItemPolicies", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetModelItemPoliciesResponse> SetModelItemPoliciesAsync(SetModelItemPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetModelItemPolicies", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetModelItemPoliciesResponse GetModelItemPolicies(GetModelItemPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetModelItemPolicies", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetModelItemPoliciesResponse> GetModelItemPoliciesAsync(GetModelItemPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetUserModel", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetUserModelResponse GetUserModel(GetUserModelRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetUserModel", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetUserModelResponse> GetUserModelAsync(GetUserModelRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/InheritModelItemParentSecurity", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		InheritModelItemParentSecurityResponse InheritModelItemParentSecurity(InheritModelItemParentSecurityRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/InheritModelItemParentSecurity", ReplyAction = "*")]
		System.Threading.Tasks.Task<InheritModelItemParentSecurityResponse> InheritModelItemParentSecurityAsync(InheritModelItemParentSecurityRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetModelDrillthroughReports", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetModelDrillthroughReportsResponse SetModelDrillthroughReports(SetModelDrillthroughReportsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetModelDrillthroughReports", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetModelDrillthroughReportsResponse> SetModelDrillthroughReportsAsync(SetModelDrillthroughReportsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListModelDrillthroughReports", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListModelDrillthroughReportsResponse ListModelDrillthroughReports(ListModelDrillthroughReportsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListModelDrillthroughReports", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListModelDrillthroughReportsResponse> ListModelDrillthroughReportsAsync(ListModelDrillthroughReportsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListModelItemChildren", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListModelItemChildrenResponse ListModelItemChildren(ListModelItemChildrenRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListModelItemChildren", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListModelItemChildrenResponse> ListModelItemChildrenAsync(ListModelItemChildrenRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListModelItemTypes", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListModelItemTypesResponse ListModelItemTypes(ListModelItemTypesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListModelItemTypes", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListModelItemTypesResponse> ListModelItemTypesAsync(ListModelItemTypesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListModelPerspectives", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListModelPerspectivesResponse ListModelPerspectives(ListModelPerspectivesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListModelPerspectives", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListModelPerspectivesResponse> ListModelPerspectivesAsync(ListModelPerspectivesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/RegenerateModel", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		RegenerateModelResponse RegenerateModel(RegenerateModelRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/RegenerateModel", ReplyAction = "*")]
		System.Threading.Tasks.Task<RegenerateModelResponse> RegenerateModelAsync(RegenerateModelRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/RemoveAllModelItemPolicies", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		RemoveAllModelItemPoliciesResponse RemoveAllModelItemPolicies(RemoveAllModelItemPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/RemoveAllModelItemPolicies", ReplyAction = "*")]
		System.Threading.Tasks.Task<RemoveAllModelItemPoliciesResponse> RemoveAllModelItemPoliciesAsync(RemoveAllModelItemPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateSchedule", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		CreateScheduleResponse CreateSchedule(CreateScheduleRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateSchedule", ReplyAction = "*")]
		System.Threading.Tasks.Task<CreateScheduleResponse> CreateScheduleAsync(CreateScheduleRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteSchedule", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		DeleteScheduleResponse DeleteSchedule(DeleteScheduleRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteSchedule", ReplyAction = "*")]
		System.Threading.Tasks.Task<DeleteScheduleResponse> DeleteScheduleAsync(DeleteScheduleRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSchedules", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListSchedulesResponse ListSchedules(ListSchedulesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSchedules", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListSchedulesResponse> ListSchedulesAsync(ListSchedulesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetScheduleProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetSchedulePropertiesResponse GetScheduleProperties(GetSchedulePropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetScheduleProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetSchedulePropertiesResponse> GetSchedulePropertiesAsync(GetSchedulePropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListScheduleStates", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListScheduleStatesResponse ListScheduleStates(ListScheduleStatesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListScheduleStates", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListScheduleStatesResponse> ListScheduleStatesAsync(ListScheduleStatesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/PauseSchedule", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		PauseScheduleResponse PauseSchedule(PauseScheduleRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/PauseSchedule", ReplyAction = "*")]
		System.Threading.Tasks.Task<PauseScheduleResponse> PauseScheduleAsync(PauseScheduleRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ResumeSchedule", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ResumeScheduleResponse ResumeSchedule(ResumeScheduleRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ResumeSchedule", ReplyAction = "*")]
		System.Threading.Tasks.Task<ResumeScheduleResponse> ResumeScheduleAsync(ResumeScheduleRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetScheduleProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetSchedulePropertiesResponse SetScheduleProperties(SetSchedulePropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetScheduleProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetSchedulePropertiesResponse> SetSchedulePropertiesAsync(SetSchedulePropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListScheduledItems", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListScheduledItemsResponse ListScheduledItems(ListScheduledItemsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListScheduledItems", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListScheduledItemsResponse> ListScheduledItemsAsync(ListScheduledItemsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemParameters", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetItemParametersResponse SetItemParameters(SetItemParametersRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemParameters", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetItemParametersResponse> SetItemParametersAsync(SetItemParametersRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemParameters", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetItemParametersResponse GetItemParameters(GetItemParametersRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemParameters", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetItemParametersResponse> GetItemParametersAsync(GetItemParametersRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListParameterTypes", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListParameterTypesResponse ListParameterTypes(ListParameterTypesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListParameterTypes", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListParameterTypesResponse> ListParameterTypesAsync(ListParameterTypesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListParameterStates", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListParameterStatesResponse ListParameterStates(ListParameterStatesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListParameterStates", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListParameterStatesResponse> ListParameterStatesAsync(ListParameterStatesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateReportEditSession", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		CreateReportEditSessionResponse CreateReportEditSession(CreateReportEditSessionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateReportEditSession", ReplyAction = "*")]
		System.Threading.Tasks.Task<CreateReportEditSessionResponse> CreateReportEditSessionAsync(CreateReportEditSessionRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateLinkedItem", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		CreateLinkedItemResponse CreateLinkedItem(CreateLinkedItemRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateLinkedItem", ReplyAction = "*")]
		System.Threading.Tasks.Task<CreateLinkedItemResponse> CreateLinkedItemAsync(CreateLinkedItemRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemLink", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetItemLinkResponse SetItemLink(SetItemLinkRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemLink", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetItemLinkResponse> SetItemLinkAsync(SetItemLinkRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemLink", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetItemLinkResponse GetItemLink(GetItemLinkRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemLink", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetItemLinkResponse> GetItemLinkAsync(GetItemLinkRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListExecutionSettings", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListExecutionSettingsResponse ListExecutionSettings(ListExecutionSettingsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListExecutionSettings", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListExecutionSettingsResponse> ListExecutionSettingsAsync(ListExecutionSettingsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetExecutionOptions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetExecutionOptionsResponse SetExecutionOptions(SetExecutionOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetExecutionOptions", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetExecutionOptionsResponse> SetExecutionOptionsAsync(SetExecutionOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetExecutionOptions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetExecutionOptionsResponse GetExecutionOptions(GetExecutionOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetExecutionOptions", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetExecutionOptionsResponse> GetExecutionOptionsAsync(GetExecutionOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/UpdateItemExecutionSnapshot", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		UpdateItemExecutionSnapshotResponse UpdateItemExecutionSnapshot(UpdateItemExecutionSnapshotRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/UpdateItemExecutionSnapshot", ReplyAction = "*")]
		System.Threading.Tasks.Task<UpdateItemExecutionSnapshotResponse> UpdateItemExecutionSnapshotAsync(UpdateItemExecutionSnapshotRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetCacheOptions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetCacheOptionsResponse SetCacheOptions(SetCacheOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetCacheOptions", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetCacheOptionsResponse> SetCacheOptionsAsync(SetCacheOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetCacheOptions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetCacheOptionsResponse GetCacheOptions(GetCacheOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetCacheOptions", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetCacheOptionsResponse> GetCacheOptionsAsync(GetCacheOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/FlushCache", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		FlushCacheResponse FlushCache(FlushCacheRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/FlushCache", ReplyAction = "*")]
		System.Threading.Tasks.Task<FlushCacheResponse> FlushCacheAsync(FlushCacheRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateItemHistorySnapshot", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		CreateItemHistorySnapshotResponse CreateItemHistorySnapshot(CreateItemHistorySnapshotRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateItemHistorySnapshot", ReplyAction = "*")]
		System.Threading.Tasks.Task<CreateItemHistorySnapshotResponse> CreateItemHistorySnapshotAsync(CreateItemHistorySnapshotRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteItemHistorySnapshot", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		DeleteItemHistorySnapshotResponse DeleteItemHistorySnapshot(DeleteItemHistorySnapshotRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteItemHistorySnapshot", ReplyAction = "*")]
		System.Threading.Tasks.Task<DeleteItemHistorySnapshotResponse> DeleteItemHistorySnapshotAsync(DeleteItemHistorySnapshotRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemHistoryLimit", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetItemHistoryLimitResponse SetItemHistoryLimit(SetItemHistoryLimitRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemHistoryLimit", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetItemHistoryLimitResponse> SetItemHistoryLimitAsync(SetItemHistoryLimitRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemHistoryLimit", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetItemHistoryLimitResponse GetItemHistoryLimit(GetItemHistoryLimitRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemHistoryLimit", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetItemHistoryLimitResponse> GetItemHistoryLimitAsync(GetItemHistoryLimitRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemHistoryOptions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetItemHistoryOptionsResponse SetItemHistoryOptions(SetItemHistoryOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemHistoryOptions", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetItemHistoryOptionsResponse> SetItemHistoryOptionsAsync(SetItemHistoryOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemHistoryOptions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetItemHistoryOptionsResponse GetItemHistoryOptions(GetItemHistoryOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemHistoryOptions", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetItemHistoryOptionsResponse> GetItemHistoryOptionsAsync(GetItemHistoryOptionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetReportServerConfigInfo", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetReportServerConfigInfoResponse GetReportServerConfigInfo(GetReportServerConfigInfoRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetReportServerConfigInfo", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetReportServerConfigInfoResponse> GetReportServerConfigInfoAsync(GetReportServerConfigInfoRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/IsSSLRequired", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		IsSSLRequiredResponse IsSSLRequired(IsSSLRequiredRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/IsSSLRequired", ReplyAction = "*")]
		System.Threading.Tasks.Task<IsSSLRequiredResponse> IsSSLRequiredAsync(IsSSLRequiredRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSystemProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetSystemPropertiesResponse SetSystemProperties(SetSystemPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSystemProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetSystemPropertiesResponse> SetSystemPropertiesAsync(SetSystemPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSystemProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetSystemPropertiesResponse GetSystemProperties(GetSystemPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSystemProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetSystemPropertiesResponse> GetSystemPropertiesAsync(GetSystemPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetUserSettings", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetUserSettingsResponse SetUserSettings(SetUserSettingsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetUserSettings", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetUserSettingsResponse> SetUserSettingsAsync(SetUserSettingsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetUserSettings", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetUserSettingsResponse GetUserSettings(GetUserSettingsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetUserSettings", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetUserSettingsResponse> GetUserSettingsAsync(GetUserSettingsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSystemPolicies", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetSystemPoliciesResponse SetSystemPolicies(SetSystemPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSystemPolicies", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetSystemPoliciesResponse> SetSystemPoliciesAsync(SetSystemPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSystemPolicies", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetSystemPoliciesResponse GetSystemPolicies(GetSystemPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSystemPolicies", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetSystemPoliciesResponse> GetSystemPoliciesAsync(GetSystemPoliciesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListExtensions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListExtensionsResponse ListExtensions(ListExtensionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListExtensions", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListExtensionsResponse> ListExtensionsAsync(ListExtensionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListExtensionTypes", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListExtensionTypesResponse ListExtensionTypes(ListExtensionTypesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListExtensionTypes", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListExtensionTypesResponse> ListExtensionTypesAsync(ListExtensionTypesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListEvents", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListEventsResponse ListEvents(ListEventsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListEvents", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListEventsResponse> ListEventsAsync(ListEventsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/FireEvent", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		FireEventResponse FireEvent(FireEventRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/FireEvent", ReplyAction = "*")]
		System.Threading.Tasks.Task<FireEventResponse> FireEventAsync(FireEventRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobs", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListJobsResponse ListJobs(ListJobsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobs", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobTypes", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListJobTypesResponse ListJobTypes(ListJobTypesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobTypes", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListJobTypesResponse> ListJobTypesAsync(ListJobTypesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobActions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListJobActionsResponse ListJobActions(ListJobActionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobActions", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListJobActionsResponse> ListJobActionsAsync(ListJobActionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobStates", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListJobStatesResponse ListJobStates(ListJobStatesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobStates", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListJobStatesResponse> ListJobStatesAsync(ListJobStatesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CancelJob", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		CancelJobResponse CancelJob(CancelJobRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CancelJob", ReplyAction = "*")]
		System.Threading.Tasks.Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateCacheRefreshPlan", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		CreateCacheRefreshPlanResponse CreateCacheRefreshPlan(CreateCacheRefreshPlanRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateCacheRefreshPlan", ReplyAction = "*")]
		System.Threading.Tasks.Task<CreateCacheRefreshPlanResponse> CreateCacheRefreshPlanAsync(CreateCacheRefreshPlanRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetCacheRefreshPlanProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		SetCacheRefreshPlanPropertiesResponse SetCacheRefreshPlanProperties(SetCacheRefreshPlanPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetCacheRefreshPlanProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<SetCacheRefreshPlanPropertiesResponse> SetCacheRefreshPlanPropertiesAsync(SetCacheRefreshPlanPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetCacheRefreshPlanProperties", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetCacheRefreshPlanPropertiesResponse GetCacheRefreshPlanProperties(GetCacheRefreshPlanPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetCacheRefreshPlanProperties", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetCacheRefreshPlanPropertiesResponse> GetCacheRefreshPlanPropertiesAsync(GetCacheRefreshPlanPropertiesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteCacheRefreshPlan", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		DeleteCacheRefreshPlanResponse DeleteCacheRefreshPlan(DeleteCacheRefreshPlanRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteCacheRefreshPlan", ReplyAction = "*")]
		System.Threading.Tasks.Task<DeleteCacheRefreshPlanResponse> DeleteCacheRefreshPlanAsync(DeleteCacheRefreshPlanRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListCacheRefreshPlans", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListCacheRefreshPlansResponse ListCacheRefreshPlans(ListCacheRefreshPlansRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListCacheRefreshPlans", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListCacheRefreshPlansResponse> ListCacheRefreshPlansAsync(ListCacheRefreshPlansRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/LogonUser", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		LogonUserResponse LogonUser(LogonUserRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/LogonUser", ReplyAction = "*")]
		System.Threading.Tasks.Task<LogonUserResponse> LogonUserAsync(LogonUserRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/Logoff", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		LogoffResponse Logoff(LogoffRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/Logoff", ReplyAction = "*")]
		System.Threading.Tasks.Task<LogoffResponse> LogoffAsync(LogoffRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetPermissions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetPermissionsResponse GetPermissions(GetPermissionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetPermissions", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetPermissionsResponse> GetPermissionsAsync(GetPermissionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSystemPermissions", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		GetSystemPermissionsResponse GetSystemPermissions(GetSystemPermissionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSystemPermissions", ReplyAction = "*")]
		System.Threading.Tasks.Task<GetSystemPermissionsResponse> GetSystemPermissionsAsync(GetSystemPermissionsRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSecurityScopes", ReplyAction = "*")]
		[XmlSerializerFormat]
		[ServiceKnownType(typeof(ExpirationDefinition))]
		[ServiceKnownType(typeof(RecurrencePattern))]
		[ServiceKnownType(typeof(ScheduleDefinitionOrReference))]
		[ServiceKnownType(typeof(DataSourceDefinitionOrReference))]
		ListSecurityScopesResponse ListSecurityScopes(ListSecurityScopesRequest request);

		[OperationContract(Action = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSecurityScopes", ReplyAction = "*")]
		System.Threading.Tasks.Task<ListSecurityScopesResponse> ListSecurityScopesAsync(ListSecurityScopesRequest request);
	}
}