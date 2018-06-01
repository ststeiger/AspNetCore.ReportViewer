
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class ReportingService2010SoapClient : System.ServiceModel.ClientBase<ReportingService2010Soap>, ReportingService2010Soap
	{
		public ReportingService2010SoapClient()
		{
		}

		public ReportingService2010SoapClient(string endpointConfigurationName)
			: base(endpointConfigurationName)
		{
		}

		public ReportingService2010SoapClient(string endpointConfigurationName, string remoteAddress)
			: base(endpointConfigurationName, remoteAddress)
		{
		}

		public ReportingService2010SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress)
			: base(endpointConfigurationName, remoteAddress)
		{
		}

		public ReportingService2010SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress)
			: base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		CreateCatalogItemResponse ReportingService2010Soap.CreateCatalogItem(CreateCatalogItemRequest request)
		{
			return base.Channel.CreateCatalogItem(request);
		}

		public ServerInfoHeader CreateCatalogItem(TrustedUserHeader TrustedUserHeader, string ItemType, string Name, string Parent, bool Overwrite, byte[] Definition, Property[] Properties, out CatalogItem ItemInfo, out Warning[] Warnings)
		{
			CreateCatalogItemRequest inValue = new CreateCatalogItemRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemType = ItemType;
			inValue.Name = Name;
			inValue.Parent = Parent;
			inValue.Overwrite = Overwrite;
			inValue.Definition = Definition;
			inValue.Properties = Properties;
			CreateCatalogItemResponse retVal = ((ReportingService2010Soap)this).CreateCatalogItem(inValue);
			ItemInfo = retVal.ItemInfo;
			Warnings = retVal.Warnings;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<CreateCatalogItemResponse> CreateCatalogItemAsync(CreateCatalogItemRequest request)
		{
			return base.Channel.CreateCatalogItemAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetItemDefinitionResponse ReportingService2010Soap.SetItemDefinition(SetItemDefinitionRequest request)
		{
			return base.Channel.SetItemDefinition(request);
		}

		public ServerInfoHeader SetItemDefinition(TrustedUserHeader TrustedUserHeader, string ItemPath, byte[] Definition, Property[] Properties, out Warning[] Warnings)
		{
			SetItemDefinitionRequest inValue = new SetItemDefinitionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Definition = Definition;
			inValue.Properties = Properties;
			SetItemDefinitionResponse retVal = ((ReportingService2010Soap)this).SetItemDefinition(inValue);
			Warnings = retVal.Warnings;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetItemDefinitionResponse> ReportingService2010Soap.SetItemDefinitionAsync(SetItemDefinitionRequest request)
		{
			return base.Channel.SetItemDefinitionAsync(request);
		}

		public System.Threading.Tasks.Task<SetItemDefinitionResponse> SetItemDefinitionAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, byte[] Definition, Property[] Properties)
		{
			SetItemDefinitionRequest inValue = new SetItemDefinitionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Definition = Definition;
			inValue.Properties = Properties;
			return ((ReportingService2010Soap)this).SetItemDefinitionAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetItemDefinitionResponse ReportingService2010Soap.GetItemDefinition(GetItemDefinitionRequest request)
		{
			return base.Channel.GetItemDefinition(request);
		}

		public ServerInfoHeader GetItemDefinition(TrustedUserHeader TrustedUserHeader, string ItemPath, out byte[] Definition)
		{
			GetItemDefinitionRequest inValue = new GetItemDefinitionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			GetItemDefinitionResponse retVal = ((ReportingService2010Soap)this).GetItemDefinition(inValue);
			Definition = retVal.Definition;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetItemDefinitionResponse> ReportingService2010Soap.GetItemDefinitionAsync(GetItemDefinitionRequest request)
		{
			return base.Channel.GetItemDefinitionAsync(request);
		}

		public System.Threading.Tasks.Task<GetItemDefinitionResponse> GetItemDefinitionAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			GetItemDefinitionRequest inValue = new GetItemDefinitionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).GetItemDefinitionAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetItemTypeResponse ReportingService2010Soap.GetItemType(GetItemTypeRequest request)
		{
			return base.Channel.GetItemType(request);
		}

		public ServerInfoHeader GetItemType(TrustedUserHeader TrustedUserHeader, string ItemPath, out string Type)
		{
			GetItemTypeRequest inValue = new GetItemTypeRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			GetItemTypeResponse retVal = ((ReportingService2010Soap)this).GetItemType(inValue);
			Type = retVal.Type;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetItemTypeResponse> ReportingService2010Soap.GetItemTypeAsync(GetItemTypeRequest request)
		{
			return base.Channel.GetItemTypeAsync(request);
		}

		public System.Threading.Tasks.Task<GetItemTypeResponse> GetItemTypeAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			GetItemTypeRequest inValue = new GetItemTypeRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).GetItemTypeAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		DeleteItemResponse ReportingService2010Soap.DeleteItem(DeleteItemRequest request)
		{
			return base.Channel.DeleteItem(request);
		}

		public ServerInfoHeader DeleteItem(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			DeleteItemRequest inValue = new DeleteItemRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			DeleteItemResponse retVal = ((ReportingService2010Soap)this).DeleteItem(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<DeleteItemResponse> ReportingService2010Soap.DeleteItemAsync(DeleteItemRequest request)
		{
			return base.Channel.DeleteItemAsync(request);
		}

		public System.Threading.Tasks.Task<DeleteItemResponse> DeleteItemAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			DeleteItemRequest inValue = new DeleteItemRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).DeleteItemAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		MoveItemResponse ReportingService2010Soap.MoveItem(MoveItemRequest request)
		{
			return base.Channel.MoveItem(request);
		}

		public ServerInfoHeader MoveItem(TrustedUserHeader TrustedUserHeader, string ItemPath, string Target)
		{
			MoveItemRequest inValue = new MoveItemRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Target = Target;
			MoveItemResponse retVal = ((ReportingService2010Soap)this).MoveItem(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<MoveItemResponse> ReportingService2010Soap.MoveItemAsync(MoveItemRequest request)
		{
			return base.Channel.MoveItemAsync(request);
		}

		public System.Threading.Tasks.Task<MoveItemResponse> MoveItemAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, string Target)
		{
			MoveItemRequest inValue = new MoveItemRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Target = Target;
			return ((ReportingService2010Soap)this).MoveItemAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		InheritParentSecurityResponse ReportingService2010Soap.InheritParentSecurity(InheritParentSecurityRequest request)
		{
			return base.Channel.InheritParentSecurity(request);
		}

		public ServerInfoHeader InheritParentSecurity(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			InheritParentSecurityRequest inValue = new InheritParentSecurityRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			InheritParentSecurityResponse retVal = ((ReportingService2010Soap)this).InheritParentSecurity(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<InheritParentSecurityResponse> ReportingService2010Soap.InheritParentSecurityAsync(InheritParentSecurityRequest request)
		{
			return base.Channel.InheritParentSecurityAsync(request);
		}

		public System.Threading.Tasks.Task<InheritParentSecurityResponse> InheritParentSecurityAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			InheritParentSecurityRequest inValue = new InheritParentSecurityRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).InheritParentSecurityAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListItemHistoryResponse ReportingService2010Soap.ListItemHistory(ListItemHistoryRequest request)
		{
			return base.Channel.ListItemHistory(request);
		}

		public ServerInfoHeader ListItemHistory(TrustedUserHeader TrustedUserHeader, string ItemPath, out ItemHistorySnapshot[] ItemHistory)
		{
			ListItemHistoryRequest inValue = new ListItemHistoryRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			ListItemHistoryResponse retVal = ((ReportingService2010Soap)this).ListItemHistory(inValue);
			ItemHistory = retVal.ItemHistory;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListItemHistoryResponse> ReportingService2010Soap.ListItemHistoryAsync(ListItemHistoryRequest request)
		{
			return base.Channel.ListItemHistoryAsync(request);
		}

		public System.Threading.Tasks.Task<ListItemHistoryResponse> ListItemHistoryAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			ListItemHistoryRequest inValue = new ListItemHistoryRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).ListItemHistoryAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListChildrenResponse ReportingService2010Soap.ListChildren(ListChildrenRequest request)
		{
			return base.Channel.ListChildren(request);
		}

		public ServerInfoHeader ListChildren(TrustedUserHeader TrustedUserHeader, string ItemPath, bool Recursive, out CatalogItem[] CatalogItems)
		{
			ListChildrenRequest inValue = new ListChildrenRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Recursive = Recursive;
			ListChildrenResponse retVal = ((ReportingService2010Soap)this).ListChildren(inValue);
			CatalogItems = retVal.CatalogItems;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListChildrenResponse> ReportingService2010Soap.ListChildrenAsync(ListChildrenRequest request)
		{
			return base.Channel.ListChildrenAsync(request);
		}

		public System.Threading.Tasks.Task<ListChildrenResponse> ListChildrenAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, bool Recursive)
		{
			ListChildrenRequest inValue = new ListChildrenRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Recursive = Recursive;
			return ((ReportingService2010Soap)this).ListChildrenAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListDependentItemsResponse ReportingService2010Soap.ListDependentItems(ListDependentItemsRequest request)
		{
			return base.Channel.ListDependentItems(request);
		}

		public ServerInfoHeader ListDependentItems(TrustedUserHeader TrustedUserHeader, string ItemPath, out CatalogItem[] CatalogItems)
		{
			ListDependentItemsRequest inValue = new ListDependentItemsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			ListDependentItemsResponse retVal = ((ReportingService2010Soap)this).ListDependentItems(inValue);
			CatalogItems = retVal.CatalogItems;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListDependentItemsResponse> ReportingService2010Soap.ListDependentItemsAsync(ListDependentItemsRequest request)
		{
			return base.Channel.ListDependentItemsAsync(request);
		}

		public System.Threading.Tasks.Task<ListDependentItemsResponse> ListDependentItemsAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			ListDependentItemsRequest inValue = new ListDependentItemsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).ListDependentItemsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		FindItemsResponse ReportingService2010Soap.FindItems(FindItemsRequest request)
		{
			return base.Channel.FindItems(request);
		}

		public ServerInfoHeader FindItems(TrustedUserHeader TrustedUserHeader, string Folder, BooleanOperatorEnum BooleanOperator, Property[] SearchOptions, SearchCondition[] SearchConditions, out CatalogItem[] Items)
		{
			FindItemsRequest inValue = new FindItemsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Folder = Folder;
			inValue.BooleanOperator = BooleanOperator;
			inValue.SearchOptions = SearchOptions;
			inValue.SearchConditions = SearchConditions;
			FindItemsResponse retVal = ((ReportingService2010Soap)this).FindItems(inValue);
			Items = retVal.Items;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<FindItemsResponse> ReportingService2010Soap.FindItemsAsync(FindItemsRequest request)
		{
			return base.Channel.FindItemsAsync(request);
		}

		public System.Threading.Tasks.Task<FindItemsResponse> FindItemsAsync(TrustedUserHeader TrustedUserHeader, string Folder, BooleanOperatorEnum BooleanOperator, Property[] SearchOptions, SearchCondition[] SearchConditions)
		{
			FindItemsRequest inValue = new FindItemsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Folder = Folder;
			inValue.BooleanOperator = BooleanOperator;
			inValue.SearchOptions = SearchOptions;
			inValue.SearchConditions = SearchConditions;
			return ((ReportingService2010Soap)this).FindItemsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListParentsResponse ReportingService2010Soap.ListParents(ListParentsRequest request)
		{
			return base.Channel.ListParents(request);
		}

		public ServerInfoHeader ListParents(TrustedUserHeader TrustedUserHeader, string ItemPath, out CatalogItem[] ListParentsResult)
		{
			ListParentsRequest inValue = new ListParentsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			ListParentsResponse retVal = ((ReportingService2010Soap)this).ListParents(inValue);
			ListParentsResult = retVal.ListParentsResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListParentsResponse> ReportingService2010Soap.ListParentsAsync(ListParentsRequest request)
		{
			return base.Channel.ListParentsAsync(request);
		}

		public System.Threading.Tasks.Task<ListParentsResponse> ListParentsAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			ListParentsRequest inValue = new ListParentsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).ListParentsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		CreateFolderResponse ReportingService2010Soap.CreateFolder(CreateFolderRequest request)
		{
			return base.Channel.CreateFolder(request);
		}

		public ServerInfoHeader CreateFolder(TrustedUserHeader TrustedUserHeader, string Folder, string Parent, Property[] Properties, out CatalogItem ItemInfo)
		{
			CreateFolderRequest inValue = new CreateFolderRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Folder = Folder;
			inValue.Parent = Parent;
			inValue.Properties = Properties;
			CreateFolderResponse retVal = ((ReportingService2010Soap)this).CreateFolder(inValue);
			ItemInfo = retVal.ItemInfo;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<CreateFolderResponse> ReportingService2010Soap.CreateFolderAsync(CreateFolderRequest request)
		{
			return base.Channel.CreateFolderAsync(request);
		}

		public System.Threading.Tasks.Task<CreateFolderResponse> CreateFolderAsync(TrustedUserHeader TrustedUserHeader, string Folder, string Parent, Property[] Properties)
		{
			CreateFolderRequest inValue = new CreateFolderRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Folder = Folder;
			inValue.Parent = Parent;
			inValue.Properties = Properties;
			return ((ReportingService2010Soap)this).CreateFolderAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetPropertiesResponse ReportingService2010Soap.SetProperties(SetPropertiesRequest request)
		{
			return base.Channel.SetProperties(request);
		}

		public ServerInfoHeader SetProperties(TrustedUserHeader TrustedUserHeader, string ItemPath, Property[] Properties)
		{
			SetPropertiesRequest inValue = new SetPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Properties = Properties;
			SetPropertiesResponse retVal = ((ReportingService2010Soap)this).SetProperties(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetPropertiesResponse> ReportingService2010Soap.SetPropertiesAsync(SetPropertiesRequest request)
		{
			return base.Channel.SetPropertiesAsync(request);
		}

		public System.Threading.Tasks.Task<SetPropertiesResponse> SetPropertiesAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, Property[] Properties)
		{
			SetPropertiesRequest inValue = new SetPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Properties = Properties;
			return ((ReportingService2010Soap)this).SetPropertiesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetPropertiesResponse ReportingService2010Soap.GetProperties(GetPropertiesRequest request)
		{
			return base.Channel.GetProperties(request);
		}

		public ServerInfoHeader GetProperties(ItemNamespaceHeader ItemNamespaceHeader, TrustedUserHeader TrustedUserHeader, string ItemPath, Property[] Properties, out Property[] Values)
		{
			GetPropertiesRequest inValue = new GetPropertiesRequest();
			inValue.ItemNamespaceHeader = ItemNamespaceHeader;
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Properties = Properties;
			GetPropertiesResponse retVal = ((ReportingService2010Soap)this).GetProperties(inValue);
			Values = retVal.Values;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetPropertiesResponse> ReportingService2010Soap.GetPropertiesAsync(GetPropertiesRequest request)
		{
			return base.Channel.GetPropertiesAsync(request);
		}

		public System.Threading.Tasks.Task<GetPropertiesResponse> GetPropertiesAsync(ItemNamespaceHeader ItemNamespaceHeader, TrustedUserHeader TrustedUserHeader, string ItemPath, Property[] Properties)
		{
			GetPropertiesRequest inValue = new GetPropertiesRequest();
			inValue.ItemNamespaceHeader = ItemNamespaceHeader;
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Properties = Properties;
			return ((ReportingService2010Soap)this).GetPropertiesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetItemReferencesResponse ReportingService2010Soap.SetItemReferences(SetItemReferencesRequest request)
		{
			return base.Channel.SetItemReferences(request);
		}

		public ServerInfoHeader SetItemReferences(TrustedUserHeader TrustedUserHeader, string ItemPath, ItemReference[] ItemReferences)
		{
			SetItemReferencesRequest inValue = new SetItemReferencesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.ItemReferences = ItemReferences;
			SetItemReferencesResponse retVal = ((ReportingService2010Soap)this).SetItemReferences(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetItemReferencesResponse> ReportingService2010Soap.SetItemReferencesAsync(SetItemReferencesRequest request)
		{
			return base.Channel.SetItemReferencesAsync(request);
		}

		public System.Threading.Tasks.Task<SetItemReferencesResponse> SetItemReferencesAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, ItemReference[] ItemReferences)
		{
			SetItemReferencesRequest inValue = new SetItemReferencesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.ItemReferences = ItemReferences;
			return ((ReportingService2010Soap)this).SetItemReferencesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetItemReferencesResponse ReportingService2010Soap.GetItemReferences(GetItemReferencesRequest request)
		{
			return base.Channel.GetItemReferences(request);
		}

		public ServerInfoHeader GetItemReferences(TrustedUserHeader TrustedUserHeader, string ItemPath, string ReferenceItemType, out ItemReferenceData[] ItemReferences)
		{
			GetItemReferencesRequest inValue = new GetItemReferencesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.ReferenceItemType = ReferenceItemType;
			GetItemReferencesResponse retVal = ((ReportingService2010Soap)this).GetItemReferences(inValue);
			ItemReferences = retVal.ItemReferences;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetItemReferencesResponse> ReportingService2010Soap.GetItemReferencesAsync(GetItemReferencesRequest request)
		{
			return base.Channel.GetItemReferencesAsync(request);
		}

		public System.Threading.Tasks.Task<GetItemReferencesResponse> GetItemReferencesAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, string ReferenceItemType)
		{
			GetItemReferencesRequest inValue = new GetItemReferencesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.ReferenceItemType = ReferenceItemType;
			return ((ReportingService2010Soap)this).GetItemReferencesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListItemTypesResponse ReportingService2010Soap.ListItemTypes(ListItemTypesRequest request)
		{
			return base.Channel.ListItemTypes(request);
		}

		public ServerInfoHeader ListItemTypes(TrustedUserHeader TrustedUserHeader, out string[] ListItemTypesResult)
		{
			ListItemTypesRequest inValue = new ListItemTypesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListItemTypesResponse retVal = ((ReportingService2010Soap)this).ListItemTypes(inValue);
			ListItemTypesResult = retVal.ListItemTypesResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListItemTypesResponse> ReportingService2010Soap.ListItemTypesAsync(ListItemTypesRequest request)
		{
			return base.Channel.ListItemTypesAsync(request);
		}

		public System.Threading.Tasks.Task<ListItemTypesResponse> ListItemTypesAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListItemTypesRequest inValue = new ListItemTypesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListItemTypesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetSubscriptionPropertiesResponse ReportingService2010Soap.SetSubscriptionProperties(SetSubscriptionPropertiesRequest request)
		{
			return base.Channel.SetSubscriptionProperties(request);
		}

		public ServerInfoHeader SetSubscriptionProperties(TrustedUserHeader TrustedUserHeader, string SubscriptionID, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
		{
			SetSubscriptionPropertiesRequest inValue = new SetSubscriptionPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SubscriptionID = SubscriptionID;
			inValue.ExtensionSettings = ExtensionSettings;
			inValue.Description = Description;
			inValue.EventType = EventType;
			inValue.MatchData = MatchData;
			inValue.Parameters = Parameters;
			SetSubscriptionPropertiesResponse retVal = ((ReportingService2010Soap)this).SetSubscriptionProperties(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetSubscriptionPropertiesResponse> ReportingService2010Soap.SetSubscriptionPropertiesAsync(SetSubscriptionPropertiesRequest request)
		{
			return base.Channel.SetSubscriptionPropertiesAsync(request);
		}

		public System.Threading.Tasks.Task<SetSubscriptionPropertiesResponse> SetSubscriptionPropertiesAsync(TrustedUserHeader TrustedUserHeader, string SubscriptionID, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
		{
			SetSubscriptionPropertiesRequest inValue = new SetSubscriptionPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SubscriptionID = SubscriptionID;
			inValue.ExtensionSettings = ExtensionSettings;
			inValue.Description = Description;
			inValue.EventType = EventType;
			inValue.MatchData = MatchData;
			inValue.Parameters = Parameters;
			return ((ReportingService2010Soap)this).SetSubscriptionPropertiesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetSubscriptionPropertiesResponse ReportingService2010Soap.GetSubscriptionProperties(GetSubscriptionPropertiesRequest request)
		{
			return base.Channel.GetSubscriptionProperties(request);
		}

		public ServerInfoHeader GetSubscriptionProperties(TrustedUserHeader TrustedUserHeader, string SubscriptionID, out string Owner, out ExtensionSettings ExtensionSettings, out string Description, out ActiveState Active, out string Status, out string EventType, out string MatchData, out ParameterValue[] Parameters)
		{
			GetSubscriptionPropertiesRequest inValue = new GetSubscriptionPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SubscriptionID = SubscriptionID;
			GetSubscriptionPropertiesResponse retVal = ((ReportingService2010Soap)this).GetSubscriptionProperties(inValue);
			Owner = retVal.Owner;
			ExtensionSettings = retVal.ExtensionSettings;
			Description = retVal.Description;
			Active = retVal.Active;
			Status = retVal.Status;
			EventType = retVal.EventType;
			MatchData = retVal.MatchData;
			Parameters = retVal.Parameters;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<GetSubscriptionPropertiesResponse> GetSubscriptionPropertiesAsync(GetSubscriptionPropertiesRequest request)
		{
			return base.Channel.GetSubscriptionPropertiesAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetDataDrivenSubscriptionPropertiesResponse ReportingService2010Soap.SetDataDrivenSubscriptionProperties(SetDataDrivenSubscriptionPropertiesRequest request)
		{
			return base.Channel.SetDataDrivenSubscriptionProperties(request);
		}

		public ServerInfoHeader SetDataDrivenSubscriptionProperties(TrustedUserHeader TrustedUserHeader, string DataDrivenSubscriptionID, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters)
		{
			SetDataDrivenSubscriptionPropertiesRequest inValue = new SetDataDrivenSubscriptionPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataDrivenSubscriptionID = DataDrivenSubscriptionID;
			inValue.ExtensionSettings = ExtensionSettings;
			inValue.DataRetrievalPlan = DataRetrievalPlan;
			inValue.Description = Description;
			inValue.EventType = EventType;
			inValue.MatchData = MatchData;
			inValue.Parameters = Parameters;
			SetDataDrivenSubscriptionPropertiesResponse retVal = ((ReportingService2010Soap)this).SetDataDrivenSubscriptionProperties(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetDataDrivenSubscriptionPropertiesResponse> ReportingService2010Soap.SetDataDrivenSubscriptionPropertiesAsync(SetDataDrivenSubscriptionPropertiesRequest request)
		{
			return base.Channel.SetDataDrivenSubscriptionPropertiesAsync(request);
		}

		public System.Threading.Tasks.Task<SetDataDrivenSubscriptionPropertiesResponse> SetDataDrivenSubscriptionPropertiesAsync(TrustedUserHeader TrustedUserHeader, string DataDrivenSubscriptionID, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters)
		{
			SetDataDrivenSubscriptionPropertiesRequest inValue = new SetDataDrivenSubscriptionPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataDrivenSubscriptionID = DataDrivenSubscriptionID;
			inValue.ExtensionSettings = ExtensionSettings;
			inValue.DataRetrievalPlan = DataRetrievalPlan;
			inValue.Description = Description;
			inValue.EventType = EventType;
			inValue.MatchData = MatchData;
			inValue.Parameters = Parameters;
			return ((ReportingService2010Soap)this).SetDataDrivenSubscriptionPropertiesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetDataDrivenSubscriptionPropertiesResponse ReportingService2010Soap.GetDataDrivenSubscriptionProperties(GetDataDrivenSubscriptionPropertiesRequest request)
		{
			return base.Channel.GetDataDrivenSubscriptionProperties(request);
		}

		public ServerInfoHeader GetDataDrivenSubscriptionProperties(TrustedUserHeader TrustedUserHeader, string DataDrivenSubscriptionID, out string Owner, out ExtensionSettings ExtensionSettings, out DataRetrievalPlan DataRetrievalPlan, out string Description, out ActiveState Active, out string Status, out string EventType, out string MatchData, out ParameterValueOrFieldReference[] Parameters)
		{
			GetDataDrivenSubscriptionPropertiesRequest inValue = new GetDataDrivenSubscriptionPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataDrivenSubscriptionID = DataDrivenSubscriptionID;
			GetDataDrivenSubscriptionPropertiesResponse retVal = ((ReportingService2010Soap)this).GetDataDrivenSubscriptionProperties(inValue);
			Owner = retVal.Owner;
			ExtensionSettings = retVal.ExtensionSettings;
			DataRetrievalPlan = retVal.DataRetrievalPlan;
			Description = retVal.Description;
			Active = retVal.Active;
			Status = retVal.Status;
			EventType = retVal.EventType;
			MatchData = retVal.MatchData;
			Parameters = retVal.Parameters;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<GetDataDrivenSubscriptionPropertiesResponse> GetDataDrivenSubscriptionPropertiesAsync(GetDataDrivenSubscriptionPropertiesRequest request)
		{
			return base.Channel.GetDataDrivenSubscriptionPropertiesAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		DisableSubscriptionResponse ReportingService2010Soap.DisableSubscription(DisableSubscriptionRequest request)
		{
			return base.Channel.DisableSubscription(request);
		}

		public ServerInfoHeader DisableSubscription(TrustedUserHeader TrustedUserHeader, string SubscriptionID)
		{
			DisableSubscriptionRequest inValue = new DisableSubscriptionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SubscriptionID = SubscriptionID;
			DisableSubscriptionResponse retVal = ((ReportingService2010Soap)this).DisableSubscription(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<DisableSubscriptionResponse> ReportingService2010Soap.DisableSubscriptionAsync(DisableSubscriptionRequest request)
		{
			return base.Channel.DisableSubscriptionAsync(request);
		}

		public System.Threading.Tasks.Task<DisableSubscriptionResponse> DisableSubscriptionAsync(TrustedUserHeader TrustedUserHeader, string SubscriptionID)
		{
			DisableSubscriptionRequest inValue = new DisableSubscriptionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SubscriptionID = SubscriptionID;
			return ((ReportingService2010Soap)this).DisableSubscriptionAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		EnableSubscriptionResponse ReportingService2010Soap.EnableSubscription(EnableSubscriptionRequest request)
		{
			return base.Channel.EnableSubscription(request);
		}

		public ServerInfoHeader EnableSubscription(TrustedUserHeader TrustedUserHeader, string SubscriptionID)
		{
			EnableSubscriptionRequest inValue = new EnableSubscriptionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SubscriptionID = SubscriptionID;
			EnableSubscriptionResponse retVal = ((ReportingService2010Soap)this).EnableSubscription(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<EnableSubscriptionResponse> ReportingService2010Soap.EnableSubscriptionAsync(EnableSubscriptionRequest request)
		{
			return base.Channel.EnableSubscriptionAsync(request);
		}

		public System.Threading.Tasks.Task<EnableSubscriptionResponse> EnableSubscriptionAsync(TrustedUserHeader TrustedUserHeader, string SubscriptionID)
		{
			EnableSubscriptionRequest inValue = new EnableSubscriptionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SubscriptionID = SubscriptionID;
			return ((ReportingService2010Soap)this).EnableSubscriptionAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		DeleteSubscriptionResponse ReportingService2010Soap.DeleteSubscription(DeleteSubscriptionRequest request)
		{
			return base.Channel.DeleteSubscription(request);
		}

		public ServerInfoHeader DeleteSubscription(TrustedUserHeader TrustedUserHeader, string SubscriptionID)
		{
			DeleteSubscriptionRequest inValue = new DeleteSubscriptionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SubscriptionID = SubscriptionID;
			DeleteSubscriptionResponse retVal = ((ReportingService2010Soap)this).DeleteSubscription(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<DeleteSubscriptionResponse> ReportingService2010Soap.DeleteSubscriptionAsync(DeleteSubscriptionRequest request)
		{
			return base.Channel.DeleteSubscriptionAsync(request);
		}

		public System.Threading.Tasks.Task<DeleteSubscriptionResponse> DeleteSubscriptionAsync(TrustedUserHeader TrustedUserHeader, string SubscriptionID)
		{
			DeleteSubscriptionRequest inValue = new DeleteSubscriptionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SubscriptionID = SubscriptionID;
			return ((ReportingService2010Soap)this).DeleteSubscriptionAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		CreateSubscriptionResponse ReportingService2010Soap.CreateSubscription(CreateSubscriptionRequest request)
		{
			return base.Channel.CreateSubscription(request);
		}

		public ServerInfoHeader CreateSubscription(TrustedUserHeader TrustedUserHeader, string ItemPath, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters, out string SubscriptionID)
		{
			CreateSubscriptionRequest inValue = new CreateSubscriptionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.ExtensionSettings = ExtensionSettings;
			inValue.Description = Description;
			inValue.EventType = EventType;
			inValue.MatchData = MatchData;
			inValue.Parameters = Parameters;
			CreateSubscriptionResponse retVal = ((ReportingService2010Soap)this).CreateSubscription(inValue);
			SubscriptionID = retVal.SubscriptionID;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<CreateSubscriptionResponse> ReportingService2010Soap.CreateSubscriptionAsync(CreateSubscriptionRequest request)
		{
			return base.Channel.CreateSubscriptionAsync(request);
		}

		public System.Threading.Tasks.Task<CreateSubscriptionResponse> CreateSubscriptionAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
		{
			CreateSubscriptionRequest inValue = new CreateSubscriptionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.ExtensionSettings = ExtensionSettings;
			inValue.Description = Description;
			inValue.EventType = EventType;
			inValue.MatchData = MatchData;
			inValue.Parameters = Parameters;
			return ((ReportingService2010Soap)this).CreateSubscriptionAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		CreateDataDrivenSubscriptionResponse ReportingService2010Soap.CreateDataDrivenSubscription(CreateDataDrivenSubscriptionRequest request)
		{
			return base.Channel.CreateDataDrivenSubscription(request);
		}

		public ServerInfoHeader CreateDataDrivenSubscription(TrustedUserHeader TrustedUserHeader, string ItemPath, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters, out string SubscriptionID)
		{
			CreateDataDrivenSubscriptionRequest inValue = new CreateDataDrivenSubscriptionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.ExtensionSettings = ExtensionSettings;
			inValue.DataRetrievalPlan = DataRetrievalPlan;
			inValue.Description = Description;
			inValue.EventType = EventType;
			inValue.MatchData = MatchData;
			inValue.Parameters = Parameters;
			CreateDataDrivenSubscriptionResponse retVal = ((ReportingService2010Soap)this).CreateDataDrivenSubscription(inValue);
			SubscriptionID = retVal.SubscriptionID;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<CreateDataDrivenSubscriptionResponse> ReportingService2010Soap.CreateDataDrivenSubscriptionAsync(CreateDataDrivenSubscriptionRequest request)
		{
			return base.Channel.CreateDataDrivenSubscriptionAsync(request);
		}

		public System.Threading.Tasks.Task<CreateDataDrivenSubscriptionResponse> CreateDataDrivenSubscriptionAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters)
		{
			CreateDataDrivenSubscriptionRequest inValue = new CreateDataDrivenSubscriptionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.ExtensionSettings = ExtensionSettings;
			inValue.DataRetrievalPlan = DataRetrievalPlan;
			inValue.Description = Description;
			inValue.EventType = EventType;
			inValue.MatchData = MatchData;
			inValue.Parameters = Parameters;
			return ((ReportingService2010Soap)this).CreateDataDrivenSubscriptionAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetExtensionSettingsResponse ReportingService2010Soap.GetExtensionSettings(GetExtensionSettingsRequest request)
		{
			return base.Channel.GetExtensionSettings(request);
		}

		public ServerInfoHeader GetExtensionSettings(TrustedUserHeader TrustedUserHeader, string Extension, out ExtensionParameter[] ExtensionParameters)
		{
			GetExtensionSettingsRequest inValue = new GetExtensionSettingsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Extension = Extension;
			GetExtensionSettingsResponse retVal = ((ReportingService2010Soap)this).GetExtensionSettings(inValue);
			ExtensionParameters = retVal.ExtensionParameters;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetExtensionSettingsResponse> ReportingService2010Soap.GetExtensionSettingsAsync(GetExtensionSettingsRequest request)
		{
			return base.Channel.GetExtensionSettingsAsync(request);
		}

		public System.Threading.Tasks.Task<GetExtensionSettingsResponse> GetExtensionSettingsAsync(TrustedUserHeader TrustedUserHeader, string Extension)
		{
			GetExtensionSettingsRequest inValue = new GetExtensionSettingsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Extension = Extension;
			return ((ReportingService2010Soap)this).GetExtensionSettingsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ValidateExtensionSettingsResponse ReportingService2010Soap.ValidateExtensionSettings(ValidateExtensionSettingsRequest request)
		{
			return base.Channel.ValidateExtensionSettings(request);
		}

		public ServerInfoHeader ValidateExtensionSettings(TrustedUserHeader TrustedUserHeader, string Extension, ParameterValueOrFieldReference[] ParameterValues, string SiteUrl, out ExtensionParameter[] ParameterErrors)
		{
			ValidateExtensionSettingsRequest inValue = new ValidateExtensionSettingsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Extension = Extension;
			inValue.ParameterValues = ParameterValues;
			inValue.SiteUrl = SiteUrl;
			ValidateExtensionSettingsResponse retVal = ((ReportingService2010Soap)this).ValidateExtensionSettings(inValue);
			ParameterErrors = retVal.ParameterErrors;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ValidateExtensionSettingsResponse> ReportingService2010Soap.ValidateExtensionSettingsAsync(ValidateExtensionSettingsRequest request)
		{
			return base.Channel.ValidateExtensionSettingsAsync(request);
		}

		public System.Threading.Tasks.Task<ValidateExtensionSettingsResponse> ValidateExtensionSettingsAsync(TrustedUserHeader TrustedUserHeader, string Extension, ParameterValueOrFieldReference[] ParameterValues, string SiteUrl)
		{
			ValidateExtensionSettingsRequest inValue = new ValidateExtensionSettingsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Extension = Extension;
			inValue.ParameterValues = ParameterValues;
			inValue.SiteUrl = SiteUrl;
			return ((ReportingService2010Soap)this).ValidateExtensionSettingsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListSubscriptionsResponse ReportingService2010Soap.ListSubscriptions(ListSubscriptionsRequest request)
		{
			return base.Channel.ListSubscriptions(request);
		}

		public ServerInfoHeader ListSubscriptions(TrustedUserHeader TrustedUserHeader, string ItemPathOrSiteURL, out Subscription[] SubscriptionItems)
		{
			ListSubscriptionsRequest inValue = new ListSubscriptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPathOrSiteURL = ItemPathOrSiteURL;
			ListSubscriptionsResponse retVal = ((ReportingService2010Soap)this).ListSubscriptions(inValue);
			SubscriptionItems = retVal.SubscriptionItems;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListSubscriptionsResponse> ReportingService2010Soap.ListSubscriptionsAsync(ListSubscriptionsRequest request)
		{
			return base.Channel.ListSubscriptionsAsync(request);
		}

		public System.Threading.Tasks.Task<ListSubscriptionsResponse> ListSubscriptionsAsync(TrustedUserHeader TrustedUserHeader, string ItemPathOrSiteURL)
		{
			ListSubscriptionsRequest inValue = new ListSubscriptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPathOrSiteURL = ItemPathOrSiteURL;
			return ((ReportingService2010Soap)this).ListSubscriptionsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListMySubscriptionsResponse ReportingService2010Soap.ListMySubscriptions(ListMySubscriptionsRequest request)
		{
			return base.Channel.ListMySubscriptions(request);
		}

		public ServerInfoHeader ListMySubscriptions(TrustedUserHeader TrustedUserHeader, string ItemPathOrSiteURL, out Subscription[] SubscriptionItems)
		{
			ListMySubscriptionsRequest inValue = new ListMySubscriptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPathOrSiteURL = ItemPathOrSiteURL;
			ListMySubscriptionsResponse retVal = ((ReportingService2010Soap)this).ListMySubscriptions(inValue);
			SubscriptionItems = retVal.SubscriptionItems;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListMySubscriptionsResponse> ReportingService2010Soap.ListMySubscriptionsAsync(ListMySubscriptionsRequest request)
		{
			return base.Channel.ListMySubscriptionsAsync(request);
		}

		public System.Threading.Tasks.Task<ListMySubscriptionsResponse> ListMySubscriptionsAsync(TrustedUserHeader TrustedUserHeader, string ItemPathOrSiteURL)
		{
			ListMySubscriptionsRequest inValue = new ListMySubscriptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPathOrSiteURL = ItemPathOrSiteURL;
			return ((ReportingService2010Soap)this).ListMySubscriptionsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListSubscriptionsUsingDataSourceResponse ReportingService2010Soap.ListSubscriptionsUsingDataSource(ListSubscriptionsUsingDataSourceRequest request)
		{
			return base.Channel.ListSubscriptionsUsingDataSource(request);
		}

		public ServerInfoHeader ListSubscriptionsUsingDataSource(TrustedUserHeader TrustedUserHeader, string DataSource, out Subscription[] SubscriptionItems)
		{
			ListSubscriptionsUsingDataSourceRequest inValue = new ListSubscriptionsUsingDataSourceRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			ListSubscriptionsUsingDataSourceResponse retVal = ((ReportingService2010Soap)this).ListSubscriptionsUsingDataSource(inValue);
			SubscriptionItems = retVal.SubscriptionItems;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListSubscriptionsUsingDataSourceResponse> ReportingService2010Soap.ListSubscriptionsUsingDataSourceAsync(ListSubscriptionsUsingDataSourceRequest request)
		{
			return base.Channel.ListSubscriptionsUsingDataSourceAsync(request);
		}

		public System.Threading.Tasks.Task<ListSubscriptionsUsingDataSourceResponse> ListSubscriptionsUsingDataSourceAsync(TrustedUserHeader TrustedUserHeader, string DataSource)
		{
			ListSubscriptionsUsingDataSourceRequest inValue = new ListSubscriptionsUsingDataSourceRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			return ((ReportingService2010Soap)this).ListSubscriptionsUsingDataSourceAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ChangeSubscriptionOwnerResponse ReportingService2010Soap.ChangeSubscriptionOwner(ChangeSubscriptionOwnerRequest request)
		{
			return base.Channel.ChangeSubscriptionOwner(request);
		}

		public ServerInfoHeader ChangeSubscriptionOwner(TrustedUserHeader TrustedUserHeader, string SubscriptionID, string NewOwner)
		{
			ChangeSubscriptionOwnerRequest inValue = new ChangeSubscriptionOwnerRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SubscriptionID = SubscriptionID;
			inValue.NewOwner = NewOwner;
			ChangeSubscriptionOwnerResponse retVal = ((ReportingService2010Soap)this).ChangeSubscriptionOwner(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ChangeSubscriptionOwnerResponse> ReportingService2010Soap.ChangeSubscriptionOwnerAsync(ChangeSubscriptionOwnerRequest request)
		{
			return base.Channel.ChangeSubscriptionOwnerAsync(request);
		}

		public System.Threading.Tasks.Task<ChangeSubscriptionOwnerResponse> ChangeSubscriptionOwnerAsync(TrustedUserHeader TrustedUserHeader, string SubscriptionID, string NewOwner)
		{
			ChangeSubscriptionOwnerRequest inValue = new ChangeSubscriptionOwnerRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SubscriptionID = SubscriptionID;
			inValue.NewOwner = NewOwner;
			return ((ReportingService2010Soap)this).ChangeSubscriptionOwnerAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		CreateDataSourceResponse ReportingService2010Soap.CreateDataSource(CreateDataSourceRequest request)
		{
			return base.Channel.CreateDataSource(request);
		}

		public ServerInfoHeader CreateDataSource(TrustedUserHeader TrustedUserHeader, string DataSource, string Parent, bool Overwrite, DataSourceDefinition Definition, Property[] Properties, out CatalogItem ItemInfo)
		{
			CreateDataSourceRequest inValue = new CreateDataSourceRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			inValue.Parent = Parent;
			inValue.Overwrite = Overwrite;
			inValue.Definition = Definition;
			inValue.Properties = Properties;
			CreateDataSourceResponse retVal = ((ReportingService2010Soap)this).CreateDataSource(inValue);
			ItemInfo = retVal.ItemInfo;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<CreateDataSourceResponse> ReportingService2010Soap.CreateDataSourceAsync(CreateDataSourceRequest request)
		{
			return base.Channel.CreateDataSourceAsync(request);
		}

		public System.Threading.Tasks.Task<CreateDataSourceResponse> CreateDataSourceAsync(TrustedUserHeader TrustedUserHeader, string DataSource, string Parent, bool Overwrite, DataSourceDefinition Definition, Property[] Properties)
		{
			CreateDataSourceRequest inValue = new CreateDataSourceRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			inValue.Parent = Parent;
			inValue.Overwrite = Overwrite;
			inValue.Definition = Definition;
			inValue.Properties = Properties;
			return ((ReportingService2010Soap)this).CreateDataSourceAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		PrepareQueryResponse ReportingService2010Soap.PrepareQuery(PrepareQueryRequest request)
		{
			return base.Channel.PrepareQuery(request);
		}

		public ServerInfoHeader PrepareQuery(TrustedUserHeader TrustedUserHeader, DataSource DataSource, DataSetDefinition DataSet, out DataSetDefinition DataSettings, out bool Changed, out string[] ParameterNames)
		{
			PrepareQueryRequest inValue = new PrepareQueryRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			inValue.DataSet = DataSet;
			PrepareQueryResponse retVal = ((ReportingService2010Soap)this).PrepareQuery(inValue);
			DataSettings = retVal.DataSettings;
			Changed = retVal.Changed;
			ParameterNames = retVal.ParameterNames;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<PrepareQueryResponse> PrepareQueryAsync(PrepareQueryRequest request)
		{
			return base.Channel.PrepareQueryAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		EnableDataSourceResponse ReportingService2010Soap.EnableDataSource(EnableDataSourceRequest request)
		{
			return base.Channel.EnableDataSource(request);
		}

		public ServerInfoHeader EnableDataSource(TrustedUserHeader TrustedUserHeader, string DataSource)
		{
			EnableDataSourceRequest inValue = new EnableDataSourceRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			EnableDataSourceResponse retVal = ((ReportingService2010Soap)this).EnableDataSource(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<EnableDataSourceResponse> ReportingService2010Soap.EnableDataSourceAsync(EnableDataSourceRequest request)
		{
			return base.Channel.EnableDataSourceAsync(request);
		}

		public System.Threading.Tasks.Task<EnableDataSourceResponse> EnableDataSourceAsync(TrustedUserHeader TrustedUserHeader, string DataSource)
		{
			EnableDataSourceRequest inValue = new EnableDataSourceRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			return ((ReportingService2010Soap)this).EnableDataSourceAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		DisableDataSourceResponse ReportingService2010Soap.DisableDataSource(DisableDataSourceRequest request)
		{
			return base.Channel.DisableDataSource(request);
		}

		public ServerInfoHeader DisableDataSource(TrustedUserHeader TrustedUserHeader, string DataSource)
		{
			DisableDataSourceRequest inValue = new DisableDataSourceRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			DisableDataSourceResponse retVal = ((ReportingService2010Soap)this).DisableDataSource(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<DisableDataSourceResponse> ReportingService2010Soap.DisableDataSourceAsync(DisableDataSourceRequest request)
		{
			return base.Channel.DisableDataSourceAsync(request);
		}

		public System.Threading.Tasks.Task<DisableDataSourceResponse> DisableDataSourceAsync(TrustedUserHeader TrustedUserHeader, string DataSource)
		{
			DisableDataSourceRequest inValue = new DisableDataSourceRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			return ((ReportingService2010Soap)this).DisableDataSourceAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetDataSourceContentsResponse ReportingService2010Soap.SetDataSourceContents(SetDataSourceContentsRequest request)
		{
			return base.Channel.SetDataSourceContents(request);
		}

		public ServerInfoHeader SetDataSourceContents(TrustedUserHeader TrustedUserHeader, string DataSource, DataSourceDefinition Definition)
		{
			SetDataSourceContentsRequest inValue = new SetDataSourceContentsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			inValue.Definition = Definition;
			SetDataSourceContentsResponse retVal = ((ReportingService2010Soap)this).SetDataSourceContents(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetDataSourceContentsResponse> ReportingService2010Soap.SetDataSourceContentsAsync(SetDataSourceContentsRequest request)
		{
			return base.Channel.SetDataSourceContentsAsync(request);
		}

		public System.Threading.Tasks.Task<SetDataSourceContentsResponse> SetDataSourceContentsAsync(TrustedUserHeader TrustedUserHeader, string DataSource, DataSourceDefinition Definition)
		{
			SetDataSourceContentsRequest inValue = new SetDataSourceContentsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			inValue.Definition = Definition;
			return ((ReportingService2010Soap)this).SetDataSourceContentsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetDataSourceContentsResponse ReportingService2010Soap.GetDataSourceContents(GetDataSourceContentsRequest request)
		{
			return base.Channel.GetDataSourceContents(request);
		}

		public ServerInfoHeader GetDataSourceContents(TrustedUserHeader TrustedUserHeader, string DataSource, out DataSourceDefinition Definition)
		{
			GetDataSourceContentsRequest inValue = new GetDataSourceContentsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			GetDataSourceContentsResponse retVal = ((ReportingService2010Soap)this).GetDataSourceContents(inValue);
			Definition = retVal.Definition;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetDataSourceContentsResponse> ReportingService2010Soap.GetDataSourceContentsAsync(GetDataSourceContentsRequest request)
		{
			return base.Channel.GetDataSourceContentsAsync(request);
		}

		public System.Threading.Tasks.Task<GetDataSourceContentsResponse> GetDataSourceContentsAsync(TrustedUserHeader TrustedUserHeader, string DataSource)
		{
			GetDataSourceContentsRequest inValue = new GetDataSourceContentsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			return ((ReportingService2010Soap)this).GetDataSourceContentsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListDatabaseCredentialRetrievalOptionsResponse ReportingService2010Soap.ListDatabaseCredentialRetrievalOptions(ListDatabaseCredentialRetrievalOptionsRequest request)
		{
			return base.Channel.ListDatabaseCredentialRetrievalOptions(request);
		}

		public ServerInfoHeader ListDatabaseCredentialRetrievalOptions(TrustedUserHeader TrustedUserHeader, out string[] ListDatabaseCredentialRetrievalOptionsResult)
		{
			ListDatabaseCredentialRetrievalOptionsRequest inValue = new ListDatabaseCredentialRetrievalOptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListDatabaseCredentialRetrievalOptionsResponse retVal = ((ReportingService2010Soap)this).ListDatabaseCredentialRetrievalOptions(inValue);
			ListDatabaseCredentialRetrievalOptionsResult = retVal.ListDatabaseCredentialRetrievalOptionsResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListDatabaseCredentialRetrievalOptionsResponse> ReportingService2010Soap.ListDatabaseCredentialRetrievalOptionsAsync(ListDatabaseCredentialRetrievalOptionsRequest request)
		{
			return base.Channel.ListDatabaseCredentialRetrievalOptionsAsync(request);
		}

		public System.Threading.Tasks.Task<ListDatabaseCredentialRetrievalOptionsResponse> ListDatabaseCredentialRetrievalOptionsAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListDatabaseCredentialRetrievalOptionsRequest inValue = new ListDatabaseCredentialRetrievalOptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListDatabaseCredentialRetrievalOptionsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetItemDataSourcesResponse ReportingService2010Soap.SetItemDataSources(SetItemDataSourcesRequest request)
		{
			return base.Channel.SetItemDataSources(request);
		}

		public ServerInfoHeader SetItemDataSources(TrustedUserHeader TrustedUserHeader, string ItemPath, DataSource[] DataSources)
		{
			SetItemDataSourcesRequest inValue = new SetItemDataSourcesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.DataSources = DataSources;
			SetItemDataSourcesResponse retVal = ((ReportingService2010Soap)this).SetItemDataSources(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetItemDataSourcesResponse> ReportingService2010Soap.SetItemDataSourcesAsync(SetItemDataSourcesRequest request)
		{
			return base.Channel.SetItemDataSourcesAsync(request);
		}

		public System.Threading.Tasks.Task<SetItemDataSourcesResponse> SetItemDataSourcesAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, DataSource[] DataSources)
		{
			SetItemDataSourcesRequest inValue = new SetItemDataSourcesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.DataSources = DataSources;
			return ((ReportingService2010Soap)this).SetItemDataSourcesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetItemDataSourcesResponse ReportingService2010Soap.GetItemDataSources(GetItemDataSourcesRequest request)
		{
			return base.Channel.GetItemDataSources(request);
		}

		public ServerInfoHeader GetItemDataSources(TrustedUserHeader TrustedUserHeader, string ItemPath, out DataSource[] DataSources)
		{
			GetItemDataSourcesRequest inValue = new GetItemDataSourcesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			GetItemDataSourcesResponse retVal = ((ReportingService2010Soap)this).GetItemDataSources(inValue);
			DataSources = retVal.DataSources;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetItemDataSourcesResponse> ReportingService2010Soap.GetItemDataSourcesAsync(GetItemDataSourcesRequest request)
		{
			return base.Channel.GetItemDataSourcesAsync(request);
		}

		public System.Threading.Tasks.Task<GetItemDataSourcesResponse> GetItemDataSourcesAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			GetItemDataSourcesRequest inValue = new GetItemDataSourcesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).GetItemDataSourcesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		TestConnectForDataSourceDefinitionResponse ReportingService2010Soap.TestConnectForDataSourceDefinition(TestConnectForDataSourceDefinitionRequest request)
		{
			return base.Channel.TestConnectForDataSourceDefinition(request);
		}

		public ServerInfoHeader TestConnectForDataSourceDefinition(TrustedUserHeader TrustedUserHeader, DataSourceDefinition DataSourceDefinition, string UserName, string Password, out bool TestConnectForDataSourceDefinitionResult, out string ConnectError)
		{
			TestConnectForDataSourceDefinitionRequest inValue = new TestConnectForDataSourceDefinitionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSourceDefinition = DataSourceDefinition;
			inValue.UserName = UserName;
			inValue.Password = Password;
			TestConnectForDataSourceDefinitionResponse retVal = ((ReportingService2010Soap)this).TestConnectForDataSourceDefinition(inValue);
			TestConnectForDataSourceDefinitionResult = retVal.TestConnectForDataSourceDefinitionResult;
			ConnectError = retVal.ConnectError;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<TestConnectForDataSourceDefinitionResponse> TestConnectForDataSourceDefinitionAsync(TestConnectForDataSourceDefinitionRequest request)
		{
			return base.Channel.TestConnectForDataSourceDefinitionAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		TestConnectForItemDataSourceResponse ReportingService2010Soap.TestConnectForItemDataSource(TestConnectForItemDataSourceRequest request)
		{
			return base.Channel.TestConnectForItemDataSource(request);
		}

		public ServerInfoHeader TestConnectForItemDataSource(TrustedUserHeader TrustedUserHeader, string ItemPath, string DataSourceName, string UserName, string Password, out bool TestConnectForItemDataSourceResult, out string ConnectError)
		{
			TestConnectForItemDataSourceRequest inValue = new TestConnectForItemDataSourceRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.DataSourceName = DataSourceName;
			inValue.UserName = UserName;
			inValue.Password = Password;
			TestConnectForItemDataSourceResponse retVal = ((ReportingService2010Soap)this).TestConnectForItemDataSource(inValue);
			TestConnectForItemDataSourceResult = retVal.TestConnectForItemDataSourceResult;
			ConnectError = retVal.ConnectError;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<TestConnectForItemDataSourceResponse> TestConnectForItemDataSourceAsync(TestConnectForItemDataSourceRequest request)
		{
			return base.Channel.TestConnectForItemDataSourceAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		CreateRoleResponse ReportingService2010Soap.CreateRole(CreateRoleRequest request)
		{
			return base.Channel.CreateRole(request);
		}

		public ServerInfoHeader CreateRole(TrustedUserHeader TrustedUserHeader, string Name, string Description, string[] TaskIDs)
		{
			CreateRoleRequest inValue = new CreateRoleRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Name = Name;
			inValue.Description = Description;
			inValue.TaskIDs = TaskIDs;
			CreateRoleResponse retVal = ((ReportingService2010Soap)this).CreateRole(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<CreateRoleResponse> ReportingService2010Soap.CreateRoleAsync(CreateRoleRequest request)
		{
			return base.Channel.CreateRoleAsync(request);
		}

		public System.Threading.Tasks.Task<CreateRoleResponse> CreateRoleAsync(TrustedUserHeader TrustedUserHeader, string Name, string Description, string[] TaskIDs)
		{
			CreateRoleRequest inValue = new CreateRoleRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Name = Name;
			inValue.Description = Description;
			inValue.TaskIDs = TaskIDs;
			return ((ReportingService2010Soap)this).CreateRoleAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetRolePropertiesResponse ReportingService2010Soap.SetRoleProperties(SetRolePropertiesRequest request)
		{
			return base.Channel.SetRoleProperties(request);
		}

		public ServerInfoHeader SetRoleProperties(TrustedUserHeader TrustedUserHeader, string Name, string Description, string[] TaskIDs)
		{
			SetRolePropertiesRequest inValue = new SetRolePropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Name = Name;
			inValue.Description = Description;
			inValue.TaskIDs = TaskIDs;
			SetRolePropertiesResponse retVal = ((ReportingService2010Soap)this).SetRoleProperties(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetRolePropertiesResponse> ReportingService2010Soap.SetRolePropertiesAsync(SetRolePropertiesRequest request)
		{
			return base.Channel.SetRolePropertiesAsync(request);
		}

		public System.Threading.Tasks.Task<SetRolePropertiesResponse> SetRolePropertiesAsync(TrustedUserHeader TrustedUserHeader, string Name, string Description, string[] TaskIDs)
		{
			SetRolePropertiesRequest inValue = new SetRolePropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Name = Name;
			inValue.Description = Description;
			inValue.TaskIDs = TaskIDs;
			return ((ReportingService2010Soap)this).SetRolePropertiesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetRolePropertiesResponse ReportingService2010Soap.GetRoleProperties(GetRolePropertiesRequest request)
		{
			return base.Channel.GetRoleProperties(request);
		}

		public ServerInfoHeader GetRoleProperties(TrustedUserHeader TrustedUserHeader, string Name, string SiteUrl, out string[] TaskIDs, out string Description)
		{
			GetRolePropertiesRequest inValue = new GetRolePropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Name = Name;
			inValue.SiteUrl = SiteUrl;
			GetRolePropertiesResponse retVal = ((ReportingService2010Soap)this).GetRoleProperties(inValue);
			TaskIDs = retVal.TaskIDs;
			Description = retVal.Description;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<GetRolePropertiesResponse> GetRolePropertiesAsync(GetRolePropertiesRequest request)
		{
			return base.Channel.GetRolePropertiesAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		DeleteRoleResponse ReportingService2010Soap.DeleteRole(DeleteRoleRequest request)
		{
			return base.Channel.DeleteRole(request);
		}

		public ServerInfoHeader DeleteRole(TrustedUserHeader TrustedUserHeader, string Name)
		{
			DeleteRoleRequest inValue = new DeleteRoleRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Name = Name;
			DeleteRoleResponse retVal = ((ReportingService2010Soap)this).DeleteRole(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<DeleteRoleResponse> ReportingService2010Soap.DeleteRoleAsync(DeleteRoleRequest request)
		{
			return base.Channel.DeleteRoleAsync(request);
		}

		public System.Threading.Tasks.Task<DeleteRoleResponse> DeleteRoleAsync(TrustedUserHeader TrustedUserHeader, string Name)
		{
			DeleteRoleRequest inValue = new DeleteRoleRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Name = Name;
			return ((ReportingService2010Soap)this).DeleteRoleAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListRolesResponse ReportingService2010Soap.ListRoles(ListRolesRequest request)
		{
			return base.Channel.ListRoles(request);
		}

		public ServerInfoHeader ListRoles(TrustedUserHeader TrustedUserHeader, string SecurityScope, string SiteUrl, out Role[] Roles)
		{
			ListRolesRequest inValue = new ListRolesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SecurityScope = SecurityScope;
			inValue.SiteUrl = SiteUrl;
			ListRolesResponse retVal = ((ReportingService2010Soap)this).ListRoles(inValue);
			Roles = retVal.Roles;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListRolesResponse> ReportingService2010Soap.ListRolesAsync(ListRolesRequest request)
		{
			return base.Channel.ListRolesAsync(request);
		}

		public System.Threading.Tasks.Task<ListRolesResponse> ListRolesAsync(TrustedUserHeader TrustedUserHeader, string SecurityScope, string SiteUrl)
		{
			ListRolesRequest inValue = new ListRolesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SecurityScope = SecurityScope;
			inValue.SiteUrl = SiteUrl;
			return ((ReportingService2010Soap)this).ListRolesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListTasksResponse ReportingService2010Soap.ListTasks(ListTasksRequest request)
		{
			return base.Channel.ListTasks(request);
		}

		public ServerInfoHeader ListTasks(TrustedUserHeader TrustedUserHeader, string SecurityScope, out Task[] Tasks)
		{
			ListTasksRequest inValue = new ListTasksRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SecurityScope = SecurityScope;
			ListTasksResponse retVal = ((ReportingService2010Soap)this).ListTasks(inValue);
			Tasks = retVal.Tasks;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListTasksResponse> ReportingService2010Soap.ListTasksAsync(ListTasksRequest request)
		{
			return base.Channel.ListTasksAsync(request);
		}

		public System.Threading.Tasks.Task<ListTasksResponse> ListTasksAsync(TrustedUserHeader TrustedUserHeader, string SecurityScope)
		{
			ListTasksRequest inValue = new ListTasksRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SecurityScope = SecurityScope;
			return ((ReportingService2010Soap)this).ListTasksAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetPoliciesResponse ReportingService2010Soap.SetPolicies(SetPoliciesRequest request)
		{
			return base.Channel.SetPolicies(request);
		}

		public ServerInfoHeader SetPolicies(TrustedUserHeader TrustedUserHeader, string ItemPath, Policy[] Policies)
		{
			SetPoliciesRequest inValue = new SetPoliciesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Policies = Policies;
			SetPoliciesResponse retVal = ((ReportingService2010Soap)this).SetPolicies(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetPoliciesResponse> ReportingService2010Soap.SetPoliciesAsync(SetPoliciesRequest request)
		{
			return base.Channel.SetPoliciesAsync(request);
		}

		public System.Threading.Tasks.Task<SetPoliciesResponse> SetPoliciesAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, Policy[] Policies)
		{
			SetPoliciesRequest inValue = new SetPoliciesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Policies = Policies;
			return ((ReportingService2010Soap)this).SetPoliciesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetPoliciesResponse ReportingService2010Soap.GetPolicies(GetPoliciesRequest request)
		{
			return base.Channel.GetPolicies(request);
		}

		public ServerInfoHeader GetPolicies(TrustedUserHeader TrustedUserHeader, string ItemPath, out Policy[] Policies, out bool InheritParent)
		{
			GetPoliciesRequest inValue = new GetPoliciesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			GetPoliciesResponse retVal = ((ReportingService2010Soap)this).GetPolicies(inValue);
			Policies = retVal.Policies;
			InheritParent = retVal.InheritParent;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<GetPoliciesResponse> GetPoliciesAsync(GetPoliciesRequest request)
		{
			return base.Channel.GetPoliciesAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetItemDataSourcePromptsResponse ReportingService2010Soap.GetItemDataSourcePrompts(GetItemDataSourcePromptsRequest request)
		{
			return base.Channel.GetItemDataSourcePrompts(request);
		}

		public ServerInfoHeader GetItemDataSourcePrompts(TrustedUserHeader TrustedUserHeader, string ItemPath, out DataSourcePrompt[] DataSourcePrompts)
		{
			GetItemDataSourcePromptsRequest inValue = new GetItemDataSourcePromptsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			GetItemDataSourcePromptsResponse retVal = ((ReportingService2010Soap)this).GetItemDataSourcePrompts(inValue);
			DataSourcePrompts = retVal.DataSourcePrompts;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetItemDataSourcePromptsResponse> ReportingService2010Soap.GetItemDataSourcePromptsAsync(GetItemDataSourcePromptsRequest request)
		{
			return base.Channel.GetItemDataSourcePromptsAsync(request);
		}

		public System.Threading.Tasks.Task<GetItemDataSourcePromptsResponse> GetItemDataSourcePromptsAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			GetItemDataSourcePromptsRequest inValue = new GetItemDataSourcePromptsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).GetItemDataSourcePromptsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GenerateModelResponse ReportingService2010Soap.GenerateModel(GenerateModelRequest request)
		{
			return base.Channel.GenerateModel(request);
		}

		public ServerInfoHeader GenerateModel(TrustedUserHeader TrustedUserHeader, string DataSource, string Model, string Parent, Property[] Properties, out CatalogItem ItemInfo, out Warning[] Warnings)
		{
			GenerateModelRequest inValue = new GenerateModelRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.DataSource = DataSource;
			inValue.Model = Model;
			inValue.Parent = Parent;
			inValue.Properties = Properties;
			GenerateModelResponse retVal = ((ReportingService2010Soap)this).GenerateModel(inValue);
			ItemInfo = retVal.ItemInfo;
			Warnings = retVal.Warnings;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<GenerateModelResponse> GenerateModelAsync(GenerateModelRequest request)
		{
			return base.Channel.GenerateModelAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetModelItemPermissionsResponse ReportingService2010Soap.GetModelItemPermissions(GetModelItemPermissionsRequest request)
		{
			return base.Channel.GetModelItemPermissions(request);
		}

		public ServerInfoHeader GetModelItemPermissions(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, out string[] Permissions)
		{
			GetModelItemPermissionsRequest inValue = new GetModelItemPermissionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			GetModelItemPermissionsResponse retVal = ((ReportingService2010Soap)this).GetModelItemPermissions(inValue);
			Permissions = retVal.Permissions;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetModelItemPermissionsResponse> ReportingService2010Soap.GetModelItemPermissionsAsync(GetModelItemPermissionsRequest request)
		{
			return base.Channel.GetModelItemPermissionsAsync(request);
		}

		public System.Threading.Tasks.Task<GetModelItemPermissionsResponse> GetModelItemPermissionsAsync(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID)
		{
			GetModelItemPermissionsRequest inValue = new GetModelItemPermissionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			return ((ReportingService2010Soap)this).GetModelItemPermissionsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetModelItemPoliciesResponse ReportingService2010Soap.SetModelItemPolicies(SetModelItemPoliciesRequest request)
		{
			return base.Channel.SetModelItemPolicies(request);
		}

		public ServerInfoHeader SetModelItemPolicies(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, Policy[] Policies)
		{
			SetModelItemPoliciesRequest inValue = new SetModelItemPoliciesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			inValue.Policies = Policies;
			SetModelItemPoliciesResponse retVal = ((ReportingService2010Soap)this).SetModelItemPolicies(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetModelItemPoliciesResponse> ReportingService2010Soap.SetModelItemPoliciesAsync(SetModelItemPoliciesRequest request)
		{
			return base.Channel.SetModelItemPoliciesAsync(request);
		}

		public System.Threading.Tasks.Task<SetModelItemPoliciesResponse> SetModelItemPoliciesAsync(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, Policy[] Policies)
		{
			SetModelItemPoliciesRequest inValue = new SetModelItemPoliciesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			inValue.Policies = Policies;
			return ((ReportingService2010Soap)this).SetModelItemPoliciesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetModelItemPoliciesResponse ReportingService2010Soap.GetModelItemPolicies(GetModelItemPoliciesRequest request)
		{
			return base.Channel.GetModelItemPolicies(request);
		}

		public ServerInfoHeader GetModelItemPolicies(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, out Policy[] Policies, out bool InheritParent)
		{
			GetModelItemPoliciesRequest inValue = new GetModelItemPoliciesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			GetModelItemPoliciesResponse retVal = ((ReportingService2010Soap)this).GetModelItemPolicies(inValue);
			Policies = retVal.Policies;
			InheritParent = retVal.InheritParent;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<GetModelItemPoliciesResponse> GetModelItemPoliciesAsync(GetModelItemPoliciesRequest request)
		{
			return base.Channel.GetModelItemPoliciesAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetUserModelResponse ReportingService2010Soap.GetUserModel(GetUserModelRequest request)
		{
			return base.Channel.GetUserModel(request);
		}

		public ServerInfoHeader GetUserModel(TrustedUserHeader TrustedUserHeader, string Model, string Perspective, out byte[] Definition)
		{
			GetUserModelRequest inValue = new GetUserModelRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.Perspective = Perspective;
			GetUserModelResponse retVal = ((ReportingService2010Soap)this).GetUserModel(inValue);
			Definition = retVal.Definition;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetUserModelResponse> ReportingService2010Soap.GetUserModelAsync(GetUserModelRequest request)
		{
			return base.Channel.GetUserModelAsync(request);
		}

		public System.Threading.Tasks.Task<GetUserModelResponse> GetUserModelAsync(TrustedUserHeader TrustedUserHeader, string Model, string Perspective)
		{
			GetUserModelRequest inValue = new GetUserModelRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.Perspective = Perspective;
			return ((ReportingService2010Soap)this).GetUserModelAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		InheritModelItemParentSecurityResponse ReportingService2010Soap.InheritModelItemParentSecurity(InheritModelItemParentSecurityRequest request)
		{
			return base.Channel.InheritModelItemParentSecurity(request);
		}

		public ServerInfoHeader InheritModelItemParentSecurity(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID)
		{
			InheritModelItemParentSecurityRequest inValue = new InheritModelItemParentSecurityRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			InheritModelItemParentSecurityResponse retVal = ((ReportingService2010Soap)this).InheritModelItemParentSecurity(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<InheritModelItemParentSecurityResponse> ReportingService2010Soap.InheritModelItemParentSecurityAsync(InheritModelItemParentSecurityRequest request)
		{
			return base.Channel.InheritModelItemParentSecurityAsync(request);
		}

		public System.Threading.Tasks.Task<InheritModelItemParentSecurityResponse> InheritModelItemParentSecurityAsync(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID)
		{
			InheritModelItemParentSecurityRequest inValue = new InheritModelItemParentSecurityRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			return ((ReportingService2010Soap)this).InheritModelItemParentSecurityAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetModelDrillthroughReportsResponse ReportingService2010Soap.SetModelDrillthroughReports(SetModelDrillthroughReportsRequest request)
		{
			return base.Channel.SetModelDrillthroughReports(request);
		}

		public ServerInfoHeader SetModelDrillthroughReports(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, ModelDrillthroughReport[] Reports)
		{
			SetModelDrillthroughReportsRequest inValue = new SetModelDrillthroughReportsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			inValue.Reports = Reports;
			SetModelDrillthroughReportsResponse retVal = ((ReportingService2010Soap)this).SetModelDrillthroughReports(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetModelDrillthroughReportsResponse> ReportingService2010Soap.SetModelDrillthroughReportsAsync(SetModelDrillthroughReportsRequest request)
		{
			return base.Channel.SetModelDrillthroughReportsAsync(request);
		}

		public System.Threading.Tasks.Task<SetModelDrillthroughReportsResponse> SetModelDrillthroughReportsAsync(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, ModelDrillthroughReport[] Reports)
		{
			SetModelDrillthroughReportsRequest inValue = new SetModelDrillthroughReportsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			inValue.Reports = Reports;
			return ((ReportingService2010Soap)this).SetModelDrillthroughReportsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListModelDrillthroughReportsResponse ReportingService2010Soap.ListModelDrillthroughReports(ListModelDrillthroughReportsRequest request)
		{
			return base.Channel.ListModelDrillthroughReports(request);
		}

		public ServerInfoHeader ListModelDrillthroughReports(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, out ModelDrillthroughReport[] Reports)
		{
			ListModelDrillthroughReportsRequest inValue = new ListModelDrillthroughReportsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			ListModelDrillthroughReportsResponse retVal = ((ReportingService2010Soap)this).ListModelDrillthroughReports(inValue);
			Reports = retVal.Reports;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListModelDrillthroughReportsResponse> ReportingService2010Soap.ListModelDrillthroughReportsAsync(ListModelDrillthroughReportsRequest request)
		{
			return base.Channel.ListModelDrillthroughReportsAsync(request);
		}

		public System.Threading.Tasks.Task<ListModelDrillthroughReportsResponse> ListModelDrillthroughReportsAsync(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID)
		{
			ListModelDrillthroughReportsRequest inValue = new ListModelDrillthroughReportsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			return ((ReportingService2010Soap)this).ListModelDrillthroughReportsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListModelItemChildrenResponse ReportingService2010Soap.ListModelItemChildren(ListModelItemChildrenRequest request)
		{
			return base.Channel.ListModelItemChildren(request);
		}

		public ServerInfoHeader ListModelItemChildren(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, bool Recursive, out ModelItem[] ModelItems)
		{
			ListModelItemChildrenRequest inValue = new ListModelItemChildrenRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			inValue.Recursive = Recursive;
			ListModelItemChildrenResponse retVal = ((ReportingService2010Soap)this).ListModelItemChildren(inValue);
			ModelItems = retVal.ModelItems;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListModelItemChildrenResponse> ReportingService2010Soap.ListModelItemChildrenAsync(ListModelItemChildrenRequest request)
		{
			return base.Channel.ListModelItemChildrenAsync(request);
		}

		public System.Threading.Tasks.Task<ListModelItemChildrenResponse> ListModelItemChildrenAsync(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, bool Recursive)
		{
			ListModelItemChildrenRequest inValue = new ListModelItemChildrenRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			inValue.ModelItemID = ModelItemID;
			inValue.Recursive = Recursive;
			return ((ReportingService2010Soap)this).ListModelItemChildrenAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListModelItemTypesResponse ReportingService2010Soap.ListModelItemTypes(ListModelItemTypesRequest request)
		{
			return base.Channel.ListModelItemTypes(request);
		}

		public ServerInfoHeader ListModelItemTypes(TrustedUserHeader TrustedUserHeader, out string[] ListModelItemTypesResult)
		{
			ListModelItemTypesRequest inValue = new ListModelItemTypesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListModelItemTypesResponse retVal = ((ReportingService2010Soap)this).ListModelItemTypes(inValue);
			ListModelItemTypesResult = retVal.ListModelItemTypesResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListModelItemTypesResponse> ReportingService2010Soap.ListModelItemTypesAsync(ListModelItemTypesRequest request)
		{
			return base.Channel.ListModelItemTypesAsync(request);
		}

		public System.Threading.Tasks.Task<ListModelItemTypesResponse> ListModelItemTypesAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListModelItemTypesRequest inValue = new ListModelItemTypesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListModelItemTypesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListModelPerspectivesResponse ReportingService2010Soap.ListModelPerspectives(ListModelPerspectivesRequest request)
		{
			return base.Channel.ListModelPerspectives(request);
		}

		public ServerInfoHeader ListModelPerspectives(TrustedUserHeader TrustedUserHeader, string Model, out ModelCatalogItem[] ModelCatalogItems)
		{
			ListModelPerspectivesRequest inValue = new ListModelPerspectivesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			ListModelPerspectivesResponse retVal = ((ReportingService2010Soap)this).ListModelPerspectives(inValue);
			ModelCatalogItems = retVal.ModelCatalogItems;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListModelPerspectivesResponse> ReportingService2010Soap.ListModelPerspectivesAsync(ListModelPerspectivesRequest request)
		{
			return base.Channel.ListModelPerspectivesAsync(request);
		}

		public System.Threading.Tasks.Task<ListModelPerspectivesResponse> ListModelPerspectivesAsync(TrustedUserHeader TrustedUserHeader, string Model)
		{
			ListModelPerspectivesRequest inValue = new ListModelPerspectivesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			return ((ReportingService2010Soap)this).ListModelPerspectivesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		RegenerateModelResponse ReportingService2010Soap.RegenerateModel(RegenerateModelRequest request)
		{
			return base.Channel.RegenerateModel(request);
		}

		public ServerInfoHeader RegenerateModel(TrustedUserHeader TrustedUserHeader, string Model, out Warning[] Warnings)
		{
			RegenerateModelRequest inValue = new RegenerateModelRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			RegenerateModelResponse retVal = ((ReportingService2010Soap)this).RegenerateModel(inValue);
			Warnings = retVal.Warnings;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<RegenerateModelResponse> ReportingService2010Soap.RegenerateModelAsync(RegenerateModelRequest request)
		{
			return base.Channel.RegenerateModelAsync(request);
		}

		public System.Threading.Tasks.Task<RegenerateModelResponse> RegenerateModelAsync(TrustedUserHeader TrustedUserHeader, string Model)
		{
			RegenerateModelRequest inValue = new RegenerateModelRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			return ((ReportingService2010Soap)this).RegenerateModelAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		RemoveAllModelItemPoliciesResponse ReportingService2010Soap.RemoveAllModelItemPolicies(RemoveAllModelItemPoliciesRequest request)
		{
			return base.Channel.RemoveAllModelItemPolicies(request);
		}

		public ServerInfoHeader RemoveAllModelItemPolicies(TrustedUserHeader TrustedUserHeader, string Model)
		{
			RemoveAllModelItemPoliciesRequest inValue = new RemoveAllModelItemPoliciesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			RemoveAllModelItemPoliciesResponse retVal = ((ReportingService2010Soap)this).RemoveAllModelItemPolicies(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<RemoveAllModelItemPoliciesResponse> ReportingService2010Soap.RemoveAllModelItemPoliciesAsync(RemoveAllModelItemPoliciesRequest request)
		{
			return base.Channel.RemoveAllModelItemPoliciesAsync(request);
		}

		public System.Threading.Tasks.Task<RemoveAllModelItemPoliciesResponse> RemoveAllModelItemPoliciesAsync(TrustedUserHeader TrustedUserHeader, string Model)
		{
			RemoveAllModelItemPoliciesRequest inValue = new RemoveAllModelItemPoliciesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Model = Model;
			return ((ReportingService2010Soap)this).RemoveAllModelItemPoliciesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		CreateScheduleResponse ReportingService2010Soap.CreateSchedule(CreateScheduleRequest request)
		{
			return base.Channel.CreateSchedule(request);
		}

		public ServerInfoHeader CreateSchedule(TrustedUserHeader TrustedUserHeader, string Name, ScheduleDefinition ScheduleDefinition, string SiteUrl, out string ScheduleID)
		{
			CreateScheduleRequest inValue = new CreateScheduleRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Name = Name;
			inValue.ScheduleDefinition = ScheduleDefinition;
			inValue.SiteUrl = SiteUrl;
			CreateScheduleResponse retVal = ((ReportingService2010Soap)this).CreateSchedule(inValue);
			ScheduleID = retVal.ScheduleID;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<CreateScheduleResponse> ReportingService2010Soap.CreateScheduleAsync(CreateScheduleRequest request)
		{
			return base.Channel.CreateScheduleAsync(request);
		}

		public System.Threading.Tasks.Task<CreateScheduleResponse> CreateScheduleAsync(TrustedUserHeader TrustedUserHeader, string Name, ScheduleDefinition ScheduleDefinition, string SiteUrl)
		{
			CreateScheduleRequest inValue = new CreateScheduleRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Name = Name;
			inValue.ScheduleDefinition = ScheduleDefinition;
			inValue.SiteUrl = SiteUrl;
			return ((ReportingService2010Soap)this).CreateScheduleAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		DeleteScheduleResponse ReportingService2010Soap.DeleteSchedule(DeleteScheduleRequest request)
		{
			return base.Channel.DeleteSchedule(request);
		}

		public ServerInfoHeader DeleteSchedule(TrustedUserHeader TrustedUserHeader, string ScheduleID)
		{
			DeleteScheduleRequest inValue = new DeleteScheduleRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ScheduleID = ScheduleID;
			DeleteScheduleResponse retVal = ((ReportingService2010Soap)this).DeleteSchedule(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<DeleteScheduleResponse> ReportingService2010Soap.DeleteScheduleAsync(DeleteScheduleRequest request)
		{
			return base.Channel.DeleteScheduleAsync(request);
		}

		public System.Threading.Tasks.Task<DeleteScheduleResponse> DeleteScheduleAsync(TrustedUserHeader TrustedUserHeader, string ScheduleID)
		{
			DeleteScheduleRequest inValue = new DeleteScheduleRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ScheduleID = ScheduleID;
			return ((ReportingService2010Soap)this).DeleteScheduleAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListSchedulesResponse ReportingService2010Soap.ListSchedules(ListSchedulesRequest request)
		{
			return base.Channel.ListSchedules(request);
		}

		public ServerInfoHeader ListSchedules(TrustedUserHeader TrustedUserHeader, string SiteUrl, out Schedule[] Schedules)
		{
			ListSchedulesRequest inValue = new ListSchedulesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SiteUrl = SiteUrl;
			ListSchedulesResponse retVal = ((ReportingService2010Soap)this).ListSchedules(inValue);
			Schedules = retVal.Schedules;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListSchedulesResponse> ReportingService2010Soap.ListSchedulesAsync(ListSchedulesRequest request)
		{
			return base.Channel.ListSchedulesAsync(request);
		}

		public System.Threading.Tasks.Task<ListSchedulesResponse> ListSchedulesAsync(TrustedUserHeader TrustedUserHeader, string SiteUrl)
		{
			ListSchedulesRequest inValue = new ListSchedulesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.SiteUrl = SiteUrl;
			return ((ReportingService2010Soap)this).ListSchedulesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetSchedulePropertiesResponse ReportingService2010Soap.GetScheduleProperties(GetSchedulePropertiesRequest request)
		{
			return base.Channel.GetScheduleProperties(request);
		}

		public ServerInfoHeader GetScheduleProperties(TrustedUserHeader TrustedUserHeader, string ScheduleID, out Schedule Schedule)
		{
			GetSchedulePropertiesRequest inValue = new GetSchedulePropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ScheduleID = ScheduleID;
			GetSchedulePropertiesResponse retVal = ((ReportingService2010Soap)this).GetScheduleProperties(inValue);
			Schedule = retVal.Schedule;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetSchedulePropertiesResponse> ReportingService2010Soap.GetSchedulePropertiesAsync(GetSchedulePropertiesRequest request)
		{
			return base.Channel.GetSchedulePropertiesAsync(request);
		}

		public System.Threading.Tasks.Task<GetSchedulePropertiesResponse> GetSchedulePropertiesAsync(TrustedUserHeader TrustedUserHeader, string ScheduleID)
		{
			GetSchedulePropertiesRequest inValue = new GetSchedulePropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ScheduleID = ScheduleID;
			return ((ReportingService2010Soap)this).GetSchedulePropertiesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListScheduleStatesResponse ReportingService2010Soap.ListScheduleStates(ListScheduleStatesRequest request)
		{
			return base.Channel.ListScheduleStates(request);
		}

		public ServerInfoHeader ListScheduleStates(TrustedUserHeader TrustedUserHeader, out string[] ListScheduleStatesResult)
		{
			ListScheduleStatesRequest inValue = new ListScheduleStatesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListScheduleStatesResponse retVal = ((ReportingService2010Soap)this).ListScheduleStates(inValue);
			ListScheduleStatesResult = retVal.ListScheduleStatesResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListScheduleStatesResponse> ReportingService2010Soap.ListScheduleStatesAsync(ListScheduleStatesRequest request)
		{
			return base.Channel.ListScheduleStatesAsync(request);
		}

		public System.Threading.Tasks.Task<ListScheduleStatesResponse> ListScheduleStatesAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListScheduleStatesRequest inValue = new ListScheduleStatesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListScheduleStatesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		PauseScheduleResponse ReportingService2010Soap.PauseSchedule(PauseScheduleRequest request)
		{
			return base.Channel.PauseSchedule(request);
		}

		public ServerInfoHeader PauseSchedule(TrustedUserHeader TrustedUserHeader, string ScheduleID)
		{
			PauseScheduleRequest inValue = new PauseScheduleRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ScheduleID = ScheduleID;
			PauseScheduleResponse retVal = ((ReportingService2010Soap)this).PauseSchedule(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<PauseScheduleResponse> ReportingService2010Soap.PauseScheduleAsync(PauseScheduleRequest request)
		{
			return base.Channel.PauseScheduleAsync(request);
		}

		public System.Threading.Tasks.Task<PauseScheduleResponse> PauseScheduleAsync(TrustedUserHeader TrustedUserHeader, string ScheduleID)
		{
			PauseScheduleRequest inValue = new PauseScheduleRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ScheduleID = ScheduleID;
			return ((ReportingService2010Soap)this).PauseScheduleAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ResumeScheduleResponse ReportingService2010Soap.ResumeSchedule(ResumeScheduleRequest request)
		{
			return base.Channel.ResumeSchedule(request);
		}

		public ServerInfoHeader ResumeSchedule(TrustedUserHeader TrustedUserHeader, string ScheduleID)
		{
			ResumeScheduleRequest inValue = new ResumeScheduleRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ScheduleID = ScheduleID;
			ResumeScheduleResponse retVal = ((ReportingService2010Soap)this).ResumeSchedule(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ResumeScheduleResponse> ReportingService2010Soap.ResumeScheduleAsync(ResumeScheduleRequest request)
		{
			return base.Channel.ResumeScheduleAsync(request);
		}

		public System.Threading.Tasks.Task<ResumeScheduleResponse> ResumeScheduleAsync(TrustedUserHeader TrustedUserHeader, string ScheduleID)
		{
			ResumeScheduleRequest inValue = new ResumeScheduleRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ScheduleID = ScheduleID;
			return ((ReportingService2010Soap)this).ResumeScheduleAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetSchedulePropertiesResponse ReportingService2010Soap.SetScheduleProperties(SetSchedulePropertiesRequest request)
		{
			return base.Channel.SetScheduleProperties(request);
		}

		public ServerInfoHeader SetScheduleProperties(TrustedUserHeader TrustedUserHeader, string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition)
		{
			SetSchedulePropertiesRequest inValue = new SetSchedulePropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Name = Name;
			inValue.ScheduleID = ScheduleID;
			inValue.ScheduleDefinition = ScheduleDefinition;
			SetSchedulePropertiesResponse retVal = ((ReportingService2010Soap)this).SetScheduleProperties(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetSchedulePropertiesResponse> ReportingService2010Soap.SetSchedulePropertiesAsync(SetSchedulePropertiesRequest request)
		{
			return base.Channel.SetSchedulePropertiesAsync(request);
		}

		public System.Threading.Tasks.Task<SetSchedulePropertiesResponse> SetSchedulePropertiesAsync(TrustedUserHeader TrustedUserHeader, string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition)
		{
			SetSchedulePropertiesRequest inValue = new SetSchedulePropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Name = Name;
			inValue.ScheduleID = ScheduleID;
			inValue.ScheduleDefinition = ScheduleDefinition;
			return ((ReportingService2010Soap)this).SetSchedulePropertiesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListScheduledItemsResponse ReportingService2010Soap.ListScheduledItems(ListScheduledItemsRequest request)
		{
			return base.Channel.ListScheduledItems(request);
		}

		public ServerInfoHeader ListScheduledItems(TrustedUserHeader TrustedUserHeader, string ScheduleID, out CatalogItem[] Items)
		{
			ListScheduledItemsRequest inValue = new ListScheduledItemsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ScheduleID = ScheduleID;
			ListScheduledItemsResponse retVal = ((ReportingService2010Soap)this).ListScheduledItems(inValue);
			Items = retVal.Items;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListScheduledItemsResponse> ReportingService2010Soap.ListScheduledItemsAsync(ListScheduledItemsRequest request)
		{
			return base.Channel.ListScheduledItemsAsync(request);
		}

		public System.Threading.Tasks.Task<ListScheduledItemsResponse> ListScheduledItemsAsync(TrustedUserHeader TrustedUserHeader, string ScheduleID)
		{
			ListScheduledItemsRequest inValue = new ListScheduledItemsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ScheduleID = ScheduleID;
			return ((ReportingService2010Soap)this).ListScheduledItemsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetItemParametersResponse ReportingService2010Soap.SetItemParameters(SetItemParametersRequest request)
		{
			return base.Channel.SetItemParameters(request);
		}

		public ServerInfoHeader SetItemParameters(TrustedUserHeader TrustedUserHeader, string ItemPath, ItemParameter[] Parameters)
		{
			SetItemParametersRequest inValue = new SetItemParametersRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Parameters = Parameters;
			SetItemParametersResponse retVal = ((ReportingService2010Soap)this).SetItemParameters(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetItemParametersResponse> ReportingService2010Soap.SetItemParametersAsync(SetItemParametersRequest request)
		{
			return base.Channel.SetItemParametersAsync(request);
		}

		public System.Threading.Tasks.Task<SetItemParametersResponse> SetItemParametersAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, ItemParameter[] Parameters)
		{
			SetItemParametersRequest inValue = new SetItemParametersRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Parameters = Parameters;
			return ((ReportingService2010Soap)this).SetItemParametersAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetItemParametersResponse ReportingService2010Soap.GetItemParameters(GetItemParametersRequest request)
		{
			return base.Channel.GetItemParameters(request);
		}

		public ServerInfoHeader GetItemParameters(TrustedUserHeader TrustedUserHeader, string ItemPath, string HistoryID, bool ForRendering, ParameterValue[] Values, DataSourceCredentials[] Credentials, out ItemParameter[] Parameters)
		{
			GetItemParametersRequest inValue = new GetItemParametersRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.HistoryID = HistoryID;
			inValue.ForRendering = ForRendering;
			inValue.Values = Values;
			inValue.Credentials = Credentials;
			GetItemParametersResponse retVal = ((ReportingService2010Soap)this).GetItemParameters(inValue);
			Parameters = retVal.Parameters;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetItemParametersResponse> ReportingService2010Soap.GetItemParametersAsync(GetItemParametersRequest request)
		{
			return base.Channel.GetItemParametersAsync(request);
		}

		public System.Threading.Tasks.Task<GetItemParametersResponse> GetItemParametersAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, string HistoryID, bool ForRendering, ParameterValue[] Values, DataSourceCredentials[] Credentials)
		{
			GetItemParametersRequest inValue = new GetItemParametersRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.HistoryID = HistoryID;
			inValue.ForRendering = ForRendering;
			inValue.Values = Values;
			inValue.Credentials = Credentials;
			return ((ReportingService2010Soap)this).GetItemParametersAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListParameterTypesResponse ReportingService2010Soap.ListParameterTypes(ListParameterTypesRequest request)
		{
			return base.Channel.ListParameterTypes(request);
		}

		public ServerInfoHeader ListParameterTypes(TrustedUserHeader TrustedUserHeader, out string[] ListParameterTypesResult)
		{
			ListParameterTypesRequest inValue = new ListParameterTypesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListParameterTypesResponse retVal = ((ReportingService2010Soap)this).ListParameterTypes(inValue);
			ListParameterTypesResult = retVal.ListParameterTypesResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListParameterTypesResponse> ReportingService2010Soap.ListParameterTypesAsync(ListParameterTypesRequest request)
		{
			return base.Channel.ListParameterTypesAsync(request);
		}

		public System.Threading.Tasks.Task<ListParameterTypesResponse> ListParameterTypesAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListParameterTypesRequest inValue = new ListParameterTypesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListParameterTypesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListParameterStatesResponse ReportingService2010Soap.ListParameterStates(ListParameterStatesRequest request)
		{
			return base.Channel.ListParameterStates(request);
		}

		public ServerInfoHeader ListParameterStates(TrustedUserHeader TrustedUserHeader, out string[] ListParameterStatesResult)
		{
			ListParameterStatesRequest inValue = new ListParameterStatesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListParameterStatesResponse retVal = ((ReportingService2010Soap)this).ListParameterStates(inValue);
			ListParameterStatesResult = retVal.ListParameterStatesResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListParameterStatesResponse> ReportingService2010Soap.ListParameterStatesAsync(ListParameterStatesRequest request)
		{
			return base.Channel.ListParameterStatesAsync(request);
		}

		public System.Threading.Tasks.Task<ListParameterStatesResponse> ListParameterStatesAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListParameterStatesRequest inValue = new ListParameterStatesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListParameterStatesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		CreateReportEditSessionResponse ReportingService2010Soap.CreateReportEditSession(CreateReportEditSessionRequest request)
		{
			return base.Channel.CreateReportEditSession(request);
		}

		public ServerInfoHeader CreateReportEditSession(TrustedUserHeader TrustedUserHeader, string Report, string Parent, byte[] Definition, out string EditSessionID, out Warning[] Warnings)
		{
			CreateReportEditSessionRequest inValue = new CreateReportEditSessionRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Report = Report;
			inValue.Parent = Parent;
			inValue.Definition = Definition;
			CreateReportEditSessionResponse retVal = ((ReportingService2010Soap)this).CreateReportEditSession(inValue);
			EditSessionID = retVal.EditSessionID;
			Warnings = retVal.Warnings;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<CreateReportEditSessionResponse> CreateReportEditSessionAsync(CreateReportEditSessionRequest request)
		{
			return base.Channel.CreateReportEditSessionAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		CreateLinkedItemResponse ReportingService2010Soap.CreateLinkedItem(CreateLinkedItemRequest request)
		{
			return base.Channel.CreateLinkedItem(request);
		}

		public ServerInfoHeader CreateLinkedItem(TrustedUserHeader TrustedUserHeader, string ItemPath, string Parent, string Link, Property[] Properties)
		{
			CreateLinkedItemRequest inValue = new CreateLinkedItemRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Parent = Parent;
			inValue.Link = Link;
			inValue.Properties = Properties;
			CreateLinkedItemResponse retVal = ((ReportingService2010Soap)this).CreateLinkedItem(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<CreateLinkedItemResponse> ReportingService2010Soap.CreateLinkedItemAsync(CreateLinkedItemRequest request)
		{
			return base.Channel.CreateLinkedItemAsync(request);
		}

		public System.Threading.Tasks.Task<CreateLinkedItemResponse> CreateLinkedItemAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, string Parent, string Link, Property[] Properties)
		{
			CreateLinkedItemRequest inValue = new CreateLinkedItemRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Parent = Parent;
			inValue.Link = Link;
			inValue.Properties = Properties;
			return ((ReportingService2010Soap)this).CreateLinkedItemAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetItemLinkResponse ReportingService2010Soap.SetItemLink(SetItemLinkRequest request)
		{
			return base.Channel.SetItemLink(request);
		}

		public ServerInfoHeader SetItemLink(TrustedUserHeader TrustedUserHeader, string ItemPath, string Link)
		{
			SetItemLinkRequest inValue = new SetItemLinkRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Link = Link;
			SetItemLinkResponse retVal = ((ReportingService2010Soap)this).SetItemLink(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetItemLinkResponse> ReportingService2010Soap.SetItemLinkAsync(SetItemLinkRequest request)
		{
			return base.Channel.SetItemLinkAsync(request);
		}

		public System.Threading.Tasks.Task<SetItemLinkResponse> SetItemLinkAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, string Link)
		{
			SetItemLinkRequest inValue = new SetItemLinkRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Link = Link;
			return ((ReportingService2010Soap)this).SetItemLinkAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetItemLinkResponse ReportingService2010Soap.GetItemLink(GetItemLinkRequest request)
		{
			return base.Channel.GetItemLink(request);
		}

		public ServerInfoHeader GetItemLink(TrustedUserHeader TrustedUserHeader, string ItemPath, out string Link)
		{
			GetItemLinkRequest inValue = new GetItemLinkRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			GetItemLinkResponse retVal = ((ReportingService2010Soap)this).GetItemLink(inValue);
			Link = retVal.Link;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetItemLinkResponse> ReportingService2010Soap.GetItemLinkAsync(GetItemLinkRequest request)
		{
			return base.Channel.GetItemLinkAsync(request);
		}

		public System.Threading.Tasks.Task<GetItemLinkResponse> GetItemLinkAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			GetItemLinkRequest inValue = new GetItemLinkRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).GetItemLinkAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListExecutionSettingsResponse ReportingService2010Soap.ListExecutionSettings(ListExecutionSettingsRequest request)
		{
			return base.Channel.ListExecutionSettings(request);
		}

		public ServerInfoHeader ListExecutionSettings(TrustedUserHeader TrustedUserHeader, out string[] ListExecutionSettingsResult)
		{
			ListExecutionSettingsRequest inValue = new ListExecutionSettingsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListExecutionSettingsResponse retVal = ((ReportingService2010Soap)this).ListExecutionSettings(inValue);
			ListExecutionSettingsResult = retVal.ListExecutionSettingsResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListExecutionSettingsResponse> ReportingService2010Soap.ListExecutionSettingsAsync(ListExecutionSettingsRequest request)
		{
			return base.Channel.ListExecutionSettingsAsync(request);
		}

		public System.Threading.Tasks.Task<ListExecutionSettingsResponse> ListExecutionSettingsAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListExecutionSettingsRequest inValue = new ListExecutionSettingsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListExecutionSettingsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetExecutionOptionsResponse ReportingService2010Soap.SetExecutionOptions(SetExecutionOptionsRequest request)
		{
			return base.Channel.SetExecutionOptions(request);
		}

		public ServerInfoHeader SetExecutionOptions(TrustedUserHeader TrustedUserHeader, string ItemPath, string ExecutionSetting, ScheduleDefinitionOrReference Item)
		{
			SetExecutionOptionsRequest inValue = new SetExecutionOptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.ExecutionSetting = ExecutionSetting;
			inValue.Item = Item;
			SetExecutionOptionsResponse retVal = ((ReportingService2010Soap)this).SetExecutionOptions(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetExecutionOptionsResponse> ReportingService2010Soap.SetExecutionOptionsAsync(SetExecutionOptionsRequest request)
		{
			return base.Channel.SetExecutionOptionsAsync(request);
		}

		public System.Threading.Tasks.Task<SetExecutionOptionsResponse> SetExecutionOptionsAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, string ExecutionSetting, ScheduleDefinitionOrReference Item)
		{
			SetExecutionOptionsRequest inValue = new SetExecutionOptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.ExecutionSetting = ExecutionSetting;
			inValue.Item = Item;
			return ((ReportingService2010Soap)this).SetExecutionOptionsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetExecutionOptionsResponse ReportingService2010Soap.GetExecutionOptions(GetExecutionOptionsRequest request)
		{
			return base.Channel.GetExecutionOptions(request);
		}

		public ServerInfoHeader GetExecutionOptions(TrustedUserHeader TrustedUserHeader, string ItemPath, out string ExecutionSetting, out ScheduleDefinitionOrReference Item)
		{
			GetExecutionOptionsRequest inValue = new GetExecutionOptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			GetExecutionOptionsResponse retVal = ((ReportingService2010Soap)this).GetExecutionOptions(inValue);
			ExecutionSetting = retVal.ExecutionSetting;
			Item = retVal.Item;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<GetExecutionOptionsResponse> GetExecutionOptionsAsync(GetExecutionOptionsRequest request)
		{
			return base.Channel.GetExecutionOptionsAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		UpdateItemExecutionSnapshotResponse ReportingService2010Soap.UpdateItemExecutionSnapshot(UpdateItemExecutionSnapshotRequest request)
		{
			return base.Channel.UpdateItemExecutionSnapshot(request);
		}

		public ServerInfoHeader UpdateItemExecutionSnapshot(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			UpdateItemExecutionSnapshotRequest inValue = new UpdateItemExecutionSnapshotRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			UpdateItemExecutionSnapshotResponse retVal = ((ReportingService2010Soap)this).UpdateItemExecutionSnapshot(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<UpdateItemExecutionSnapshotResponse> ReportingService2010Soap.UpdateItemExecutionSnapshotAsync(UpdateItemExecutionSnapshotRequest request)
		{
			return base.Channel.UpdateItemExecutionSnapshotAsync(request);
		}

		public System.Threading.Tasks.Task<UpdateItemExecutionSnapshotResponse> UpdateItemExecutionSnapshotAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			UpdateItemExecutionSnapshotRequest inValue = new UpdateItemExecutionSnapshotRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).UpdateItemExecutionSnapshotAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetCacheOptionsResponse ReportingService2010Soap.SetCacheOptions(SetCacheOptionsRequest request)
		{
			return base.Channel.SetCacheOptions(request);
		}

		public ServerInfoHeader SetCacheOptions(TrustedUserHeader TrustedUserHeader, string ItemPath, bool CacheItem, ExpirationDefinition Item)
		{
			SetCacheOptionsRequest inValue = new SetCacheOptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.CacheItem = CacheItem;
			inValue.Item = Item;
			SetCacheOptionsResponse retVal = ((ReportingService2010Soap)this).SetCacheOptions(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetCacheOptionsResponse> ReportingService2010Soap.SetCacheOptionsAsync(SetCacheOptionsRequest request)
		{
			return base.Channel.SetCacheOptionsAsync(request);
		}

		public System.Threading.Tasks.Task<SetCacheOptionsResponse> SetCacheOptionsAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, bool CacheItem, ExpirationDefinition Item)
		{
			SetCacheOptionsRequest inValue = new SetCacheOptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.CacheItem = CacheItem;
			inValue.Item = Item;
			return ((ReportingService2010Soap)this).SetCacheOptionsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetCacheOptionsResponse ReportingService2010Soap.GetCacheOptions(GetCacheOptionsRequest request)
		{
			return base.Channel.GetCacheOptions(request);
		}

		public ServerInfoHeader GetCacheOptions(TrustedUserHeader TrustedUserHeader, string ItemPath, out bool CacheItem, out ExpirationDefinition Item)
		{
			GetCacheOptionsRequest inValue = new GetCacheOptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			GetCacheOptionsResponse retVal = ((ReportingService2010Soap)this).GetCacheOptions(inValue);
			CacheItem = retVal.CacheItem;
			Item = retVal.Item;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<GetCacheOptionsResponse> GetCacheOptionsAsync(GetCacheOptionsRequest request)
		{
			return base.Channel.GetCacheOptionsAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		FlushCacheResponse ReportingService2010Soap.FlushCache(FlushCacheRequest request)
		{
			return base.Channel.FlushCache(request);
		}

		public ServerInfoHeader FlushCache(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			FlushCacheRequest inValue = new FlushCacheRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			FlushCacheResponse retVal = ((ReportingService2010Soap)this).FlushCache(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<FlushCacheResponse> ReportingService2010Soap.FlushCacheAsync(FlushCacheRequest request)
		{
			return base.Channel.FlushCacheAsync(request);
		}

		public System.Threading.Tasks.Task<FlushCacheResponse> FlushCacheAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			FlushCacheRequest inValue = new FlushCacheRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).FlushCacheAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		CreateItemHistorySnapshotResponse ReportingService2010Soap.CreateItemHistorySnapshot(CreateItemHistorySnapshotRequest request)
		{
			return base.Channel.CreateItemHistorySnapshot(request);
		}

		public ServerInfoHeader CreateItemHistorySnapshot(TrustedUserHeader TrustedUserHeader, string ItemPath, out string HistoryID, out Warning[] Warnings)
		{
			CreateItemHistorySnapshotRequest inValue = new CreateItemHistorySnapshotRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			CreateItemHistorySnapshotResponse retVal = ((ReportingService2010Soap)this).CreateItemHistorySnapshot(inValue);
			HistoryID = retVal.HistoryID;
			Warnings = retVal.Warnings;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<CreateItemHistorySnapshotResponse> CreateItemHistorySnapshotAsync(CreateItemHistorySnapshotRequest request)
		{
			return base.Channel.CreateItemHistorySnapshotAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		DeleteItemHistorySnapshotResponse ReportingService2010Soap.DeleteItemHistorySnapshot(DeleteItemHistorySnapshotRequest request)
		{
			return base.Channel.DeleteItemHistorySnapshot(request);
		}

		public ServerInfoHeader DeleteItemHistorySnapshot(TrustedUserHeader TrustedUserHeader, string ItemPath, string HistoryID)
		{
			DeleteItemHistorySnapshotRequest inValue = new DeleteItemHistorySnapshotRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.HistoryID = HistoryID;
			DeleteItemHistorySnapshotResponse retVal = ((ReportingService2010Soap)this).DeleteItemHistorySnapshot(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<DeleteItemHistorySnapshotResponse> ReportingService2010Soap.DeleteItemHistorySnapshotAsync(DeleteItemHistorySnapshotRequest request)
		{
			return base.Channel.DeleteItemHistorySnapshotAsync(request);
		}

		public System.Threading.Tasks.Task<DeleteItemHistorySnapshotResponse> DeleteItemHistorySnapshotAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, string HistoryID)
		{
			DeleteItemHistorySnapshotRequest inValue = new DeleteItemHistorySnapshotRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.HistoryID = HistoryID;
			return ((ReportingService2010Soap)this).DeleteItemHistorySnapshotAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetItemHistoryLimitResponse ReportingService2010Soap.SetItemHistoryLimit(SetItemHistoryLimitRequest request)
		{
			return base.Channel.SetItemHistoryLimit(request);
		}

		public ServerInfoHeader SetItemHistoryLimit(TrustedUserHeader TrustedUserHeader, string ItemPath, bool UseSystem, int HistoryLimit)
		{
			SetItemHistoryLimitRequest inValue = new SetItemHistoryLimitRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.UseSystem = UseSystem;
			inValue.HistoryLimit = HistoryLimit;
			SetItemHistoryLimitResponse retVal = ((ReportingService2010Soap)this).SetItemHistoryLimit(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetItemHistoryLimitResponse> ReportingService2010Soap.SetItemHistoryLimitAsync(SetItemHistoryLimitRequest request)
		{
			return base.Channel.SetItemHistoryLimitAsync(request);
		}

		public System.Threading.Tasks.Task<SetItemHistoryLimitResponse> SetItemHistoryLimitAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, bool UseSystem, int HistoryLimit)
		{
			SetItemHistoryLimitRequest inValue = new SetItemHistoryLimitRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.UseSystem = UseSystem;
			inValue.HistoryLimit = HistoryLimit;
			return ((ReportingService2010Soap)this).SetItemHistoryLimitAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetItemHistoryLimitResponse ReportingService2010Soap.GetItemHistoryLimit(GetItemHistoryLimitRequest request)
		{
			return base.Channel.GetItemHistoryLimit(request);
		}

		public ServerInfoHeader GetItemHistoryLimit(TrustedUserHeader TrustedUserHeader, string ItemPath, out int HistoryLimit, out bool IsSystem, out int SystemLimit)
		{
			GetItemHistoryLimitRequest inValue = new GetItemHistoryLimitRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			GetItemHistoryLimitResponse retVal = ((ReportingService2010Soap)this).GetItemHistoryLimit(inValue);
			HistoryLimit = retVal.HistoryLimit;
			IsSystem = retVal.IsSystem;
			SystemLimit = retVal.SystemLimit;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<GetItemHistoryLimitResponse> GetItemHistoryLimitAsync(GetItemHistoryLimitRequest request)
		{
			return base.Channel.GetItemHistoryLimitAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetItemHistoryOptionsResponse ReportingService2010Soap.SetItemHistoryOptions(SetItemHistoryOptionsRequest request)
		{
			return base.Channel.SetItemHistoryOptions(request);
		}

		public ServerInfoHeader SetItemHistoryOptions(TrustedUserHeader TrustedUserHeader, string ItemPath, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, ScheduleDefinitionOrReference Item)
		{
			SetItemHistoryOptionsRequest inValue = new SetItemHistoryOptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.EnableManualSnapshotCreation = EnableManualSnapshotCreation;
			inValue.KeepExecutionSnapshots = KeepExecutionSnapshots;
			inValue.Item = Item;
			SetItemHistoryOptionsResponse retVal = ((ReportingService2010Soap)this).SetItemHistoryOptions(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetItemHistoryOptionsResponse> ReportingService2010Soap.SetItemHistoryOptionsAsync(SetItemHistoryOptionsRequest request)
		{
			return base.Channel.SetItemHistoryOptionsAsync(request);
		}

		public System.Threading.Tasks.Task<SetItemHistoryOptionsResponse> SetItemHistoryOptionsAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, ScheduleDefinitionOrReference Item)
		{
			SetItemHistoryOptionsRequest inValue = new SetItemHistoryOptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.EnableManualSnapshotCreation = EnableManualSnapshotCreation;
			inValue.KeepExecutionSnapshots = KeepExecutionSnapshots;
			inValue.Item = Item;
			return ((ReportingService2010Soap)this).SetItemHistoryOptionsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetItemHistoryOptionsResponse ReportingService2010Soap.GetItemHistoryOptions(GetItemHistoryOptionsRequest request)
		{
			return base.Channel.GetItemHistoryOptions(request);
		}

		public ServerInfoHeader GetItemHistoryOptions(TrustedUserHeader TrustedUserHeader, string ItemPath, out bool EnableManualSnapshotCreation, out bool KeepExecutionSnapshots, out ScheduleDefinitionOrReference Item)
		{
			GetItemHistoryOptionsRequest inValue = new GetItemHistoryOptionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			GetItemHistoryOptionsResponse retVal = ((ReportingService2010Soap)this).GetItemHistoryOptions(inValue);
			EnableManualSnapshotCreation = retVal.EnableManualSnapshotCreation;
			KeepExecutionSnapshots = retVal.KeepExecutionSnapshots;
			Item = retVal.Item;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<GetItemHistoryOptionsResponse> GetItemHistoryOptionsAsync(GetItemHistoryOptionsRequest request)
		{
			return base.Channel.GetItemHistoryOptionsAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetReportServerConfigInfoResponse ReportingService2010Soap.GetReportServerConfigInfo(GetReportServerConfigInfoRequest request)
		{
			return base.Channel.GetReportServerConfigInfo(request);
		}

		public ServerInfoHeader GetReportServerConfigInfo(TrustedUserHeader TrustedUserHeader, bool ScaleOut, out string ServerConfigInfo)
		{
			GetReportServerConfigInfoRequest inValue = new GetReportServerConfigInfoRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ScaleOut = ScaleOut;
			GetReportServerConfigInfoResponse retVal = ((ReportingService2010Soap)this).GetReportServerConfigInfo(inValue);
			ServerConfigInfo = retVal.ServerConfigInfo;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetReportServerConfigInfoResponse> ReportingService2010Soap.GetReportServerConfigInfoAsync(GetReportServerConfigInfoRequest request)
		{
			return base.Channel.GetReportServerConfigInfoAsync(request);
		}

		public System.Threading.Tasks.Task<GetReportServerConfigInfoResponse> GetReportServerConfigInfoAsync(TrustedUserHeader TrustedUserHeader, bool ScaleOut)
		{
			GetReportServerConfigInfoRequest inValue = new GetReportServerConfigInfoRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ScaleOut = ScaleOut;
			return ((ReportingService2010Soap)this).GetReportServerConfigInfoAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		IsSSLRequiredResponse ReportingService2010Soap.IsSSLRequired(IsSSLRequiredRequest request)
		{
			return base.Channel.IsSSLRequired(request);
		}

		public ServerInfoHeader IsSSLRequired(TrustedUserHeader TrustedUserHeader, out bool IsSSLRequiredResult)
		{
			IsSSLRequiredRequest inValue = new IsSSLRequiredRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			IsSSLRequiredResponse retVal = ((ReportingService2010Soap)this).IsSSLRequired(inValue);
			IsSSLRequiredResult = retVal.IsSSLRequiredResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<IsSSLRequiredResponse> ReportingService2010Soap.IsSSLRequiredAsync(IsSSLRequiredRequest request)
		{
			return base.Channel.IsSSLRequiredAsync(request);
		}

		public System.Threading.Tasks.Task<IsSSLRequiredResponse> IsSSLRequiredAsync(TrustedUserHeader TrustedUserHeader)
		{
			IsSSLRequiredRequest inValue = new IsSSLRequiredRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).IsSSLRequiredAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetSystemPropertiesResponse ReportingService2010Soap.SetSystemProperties(SetSystemPropertiesRequest request)
		{
			return base.Channel.SetSystemProperties(request);
		}

		public ServerInfoHeader SetSystemProperties(TrustedUserHeader TrustedUserHeader, Property[] Properties)
		{
			SetSystemPropertiesRequest inValue = new SetSystemPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Properties = Properties;
			SetSystemPropertiesResponse retVal = ((ReportingService2010Soap)this).SetSystemProperties(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetSystemPropertiesResponse> ReportingService2010Soap.SetSystemPropertiesAsync(SetSystemPropertiesRequest request)
		{
			return base.Channel.SetSystemPropertiesAsync(request);
		}

		public System.Threading.Tasks.Task<SetSystemPropertiesResponse> SetSystemPropertiesAsync(TrustedUserHeader TrustedUserHeader, Property[] Properties)
		{
			SetSystemPropertiesRequest inValue = new SetSystemPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Properties = Properties;
			return ((ReportingService2010Soap)this).SetSystemPropertiesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetSystemPropertiesResponse ReportingService2010Soap.GetSystemProperties(GetSystemPropertiesRequest request)
		{
			return base.Channel.GetSystemProperties(request);
		}

		public ServerInfoHeader GetSystemProperties(TrustedUserHeader TrustedUserHeader, Property[] Properties, out Property[] Values)
		{
			GetSystemPropertiesRequest inValue = new GetSystemPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Properties = Properties;
			GetSystemPropertiesResponse retVal = ((ReportingService2010Soap)this).GetSystemProperties(inValue);
			Values = retVal.Values;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetSystemPropertiesResponse> ReportingService2010Soap.GetSystemPropertiesAsync(GetSystemPropertiesRequest request)
		{
			return base.Channel.GetSystemPropertiesAsync(request);
		}

		public System.Threading.Tasks.Task<GetSystemPropertiesResponse> GetSystemPropertiesAsync(TrustedUserHeader TrustedUserHeader, Property[] Properties)
		{
			GetSystemPropertiesRequest inValue = new GetSystemPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Properties = Properties;
			return ((ReportingService2010Soap)this).GetSystemPropertiesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetUserSettingsResponse ReportingService2010Soap.SetUserSettings(SetUserSettingsRequest request)
		{
			return base.Channel.SetUserSettings(request);
		}

		public ServerInfoHeader SetUserSettings(TrustedUserHeader TrustedUserHeader, Property[] Properties)
		{
			SetUserSettingsRequest inValue = new SetUserSettingsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Properties = Properties;
			SetUserSettingsResponse retVal = ((ReportingService2010Soap)this).SetUserSettings(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetUserSettingsResponse> ReportingService2010Soap.SetUserSettingsAsync(SetUserSettingsRequest request)
		{
			return base.Channel.SetUserSettingsAsync(request);
		}

		public System.Threading.Tasks.Task<SetUserSettingsResponse> SetUserSettingsAsync(TrustedUserHeader TrustedUserHeader, Property[] Properties)
		{
			SetUserSettingsRequest inValue = new SetUserSettingsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Properties = Properties;
			return ((ReportingService2010Soap)this).SetUserSettingsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetUserSettingsResponse ReportingService2010Soap.GetUserSettings(GetUserSettingsRequest request)
		{
			return base.Channel.GetUserSettings(request);
		}

		public ServerInfoHeader GetUserSettings(TrustedUserHeader TrustedUserHeader, Property[] Properties, out Property[] Values)
		{
			GetUserSettingsRequest inValue = new GetUserSettingsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Properties = Properties;
			GetUserSettingsResponse retVal = ((ReportingService2010Soap)this).GetUserSettings(inValue);
			Values = retVal.Values;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetUserSettingsResponse> ReportingService2010Soap.GetUserSettingsAsync(GetUserSettingsRequest request)
		{
			return base.Channel.GetUserSettingsAsync(request);
		}

		public System.Threading.Tasks.Task<GetUserSettingsResponse> GetUserSettingsAsync(TrustedUserHeader TrustedUserHeader, Property[] Properties)
		{
			GetUserSettingsRequest inValue = new GetUserSettingsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Properties = Properties;
			return ((ReportingService2010Soap)this).GetUserSettingsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetSystemPoliciesResponse ReportingService2010Soap.SetSystemPolicies(SetSystemPoliciesRequest request)
		{
			return base.Channel.SetSystemPolicies(request);
		}

		public ServerInfoHeader SetSystemPolicies(TrustedUserHeader TrustedUserHeader, Policy[] Policies)
		{
			SetSystemPoliciesRequest inValue = new SetSystemPoliciesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Policies = Policies;
			SetSystemPoliciesResponse retVal = ((ReportingService2010Soap)this).SetSystemPolicies(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetSystemPoliciesResponse> ReportingService2010Soap.SetSystemPoliciesAsync(SetSystemPoliciesRequest request)
		{
			return base.Channel.SetSystemPoliciesAsync(request);
		}

		public System.Threading.Tasks.Task<SetSystemPoliciesResponse> SetSystemPoliciesAsync(TrustedUserHeader TrustedUserHeader, Policy[] Policies)
		{
			SetSystemPoliciesRequest inValue = new SetSystemPoliciesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.Policies = Policies;
			return ((ReportingService2010Soap)this).SetSystemPoliciesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetSystemPoliciesResponse ReportingService2010Soap.GetSystemPolicies(GetSystemPoliciesRequest request)
		{
			return base.Channel.GetSystemPolicies(request);
		}

		public ServerInfoHeader GetSystemPolicies(TrustedUserHeader TrustedUserHeader, out Policy[] Policies)
		{
			GetSystemPoliciesRequest inValue = new GetSystemPoliciesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			GetSystemPoliciesResponse retVal = ((ReportingService2010Soap)this).GetSystemPolicies(inValue);
			Policies = retVal.Policies;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetSystemPoliciesResponse> ReportingService2010Soap.GetSystemPoliciesAsync(GetSystemPoliciesRequest request)
		{
			return base.Channel.GetSystemPoliciesAsync(request);
		}

		public System.Threading.Tasks.Task<GetSystemPoliciesResponse> GetSystemPoliciesAsync(TrustedUserHeader TrustedUserHeader)
		{
			GetSystemPoliciesRequest inValue = new GetSystemPoliciesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).GetSystemPoliciesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListExtensionsResponse ReportingService2010Soap.ListExtensions(ListExtensionsRequest request)
		{
			return base.Channel.ListExtensions(request);
		}

		public ServerInfoHeader ListExtensions(TrustedUserHeader TrustedUserHeader, string ExtensionType, out Extension[] Extensions)
		{
			ListExtensionsRequest inValue = new ListExtensionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ExtensionType = ExtensionType;
			ListExtensionsResponse retVal = ((ReportingService2010Soap)this).ListExtensions(inValue);
			Extensions = retVal.Extensions;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListExtensionsResponse> ReportingService2010Soap.ListExtensionsAsync(ListExtensionsRequest request)
		{
			return base.Channel.ListExtensionsAsync(request);
		}

		public System.Threading.Tasks.Task<ListExtensionsResponse> ListExtensionsAsync(TrustedUserHeader TrustedUserHeader, string ExtensionType)
		{
			ListExtensionsRequest inValue = new ListExtensionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ExtensionType = ExtensionType;
			return ((ReportingService2010Soap)this).ListExtensionsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListExtensionTypesResponse ReportingService2010Soap.ListExtensionTypes(ListExtensionTypesRequest request)
		{
			return base.Channel.ListExtensionTypes(request);
		}

		public ServerInfoHeader ListExtensionTypes(TrustedUserHeader TrustedUserHeader, out string[] ListExtensionTypesResult)
		{
			ListExtensionTypesRequest inValue = new ListExtensionTypesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListExtensionTypesResponse retVal = ((ReportingService2010Soap)this).ListExtensionTypes(inValue);
			ListExtensionTypesResult = retVal.ListExtensionTypesResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListExtensionTypesResponse> ReportingService2010Soap.ListExtensionTypesAsync(ListExtensionTypesRequest request)
		{
			return base.Channel.ListExtensionTypesAsync(request);
		}

		public System.Threading.Tasks.Task<ListExtensionTypesResponse> ListExtensionTypesAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListExtensionTypesRequest inValue = new ListExtensionTypesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListExtensionTypesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListEventsResponse ReportingService2010Soap.ListEvents(ListEventsRequest request)
		{
			return base.Channel.ListEvents(request);
		}

		public ServerInfoHeader ListEvents(TrustedUserHeader TrustedUserHeader, out Event[] Events)
		{
			ListEventsRequest inValue = new ListEventsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListEventsResponse retVal = ((ReportingService2010Soap)this).ListEvents(inValue);
			Events = retVal.Events;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListEventsResponse> ReportingService2010Soap.ListEventsAsync(ListEventsRequest request)
		{
			return base.Channel.ListEventsAsync(request);
		}

		public System.Threading.Tasks.Task<ListEventsResponse> ListEventsAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListEventsRequest inValue = new ListEventsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListEventsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		FireEventResponse ReportingService2010Soap.FireEvent(FireEventRequest request)
		{
			return base.Channel.FireEvent(request);
		}

		public ServerInfoHeader FireEvent(TrustedUserHeader TrustedUserHeader, string EventType, string EventData, string SiteUrl)
		{
			FireEventRequest inValue = new FireEventRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.EventType = EventType;
			inValue.EventData = EventData;
			inValue.SiteUrl = SiteUrl;
			FireEventResponse retVal = ((ReportingService2010Soap)this).FireEvent(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<FireEventResponse> ReportingService2010Soap.FireEventAsync(FireEventRequest request)
		{
			return base.Channel.FireEventAsync(request);
		}

		public System.Threading.Tasks.Task<FireEventResponse> FireEventAsync(TrustedUserHeader TrustedUserHeader, string EventType, string EventData, string SiteUrl)
		{
			FireEventRequest inValue = new FireEventRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.EventType = EventType;
			inValue.EventData = EventData;
			inValue.SiteUrl = SiteUrl;
			return ((ReportingService2010Soap)this).FireEventAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListJobsResponse ReportingService2010Soap.ListJobs(ListJobsRequest request)
		{
			return base.Channel.ListJobs(request);
		}

		public ServerInfoHeader ListJobs(TrustedUserHeader TrustedUserHeader, out Job[] Jobs)
		{
			ListJobsRequest inValue = new ListJobsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListJobsResponse retVal = ((ReportingService2010Soap)this).ListJobs(inValue);
			Jobs = retVal.Jobs;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListJobsResponse> ReportingService2010Soap.ListJobsAsync(ListJobsRequest request)
		{
			return base.Channel.ListJobsAsync(request);
		}

		public System.Threading.Tasks.Task<ListJobsResponse> ListJobsAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListJobsRequest inValue = new ListJobsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListJobsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListJobTypesResponse ReportingService2010Soap.ListJobTypes(ListJobTypesRequest request)
		{
			return base.Channel.ListJobTypes(request);
		}

		public ServerInfoHeader ListJobTypes(TrustedUserHeader TrustedUserHeader, out string[] ListJobTypesResult)
		{
			ListJobTypesRequest inValue = new ListJobTypesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListJobTypesResponse retVal = ((ReportingService2010Soap)this).ListJobTypes(inValue);
			ListJobTypesResult = retVal.ListJobTypesResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListJobTypesResponse> ReportingService2010Soap.ListJobTypesAsync(ListJobTypesRequest request)
		{
			return base.Channel.ListJobTypesAsync(request);
		}

		public System.Threading.Tasks.Task<ListJobTypesResponse> ListJobTypesAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListJobTypesRequest inValue = new ListJobTypesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListJobTypesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListJobActionsResponse ReportingService2010Soap.ListJobActions(ListJobActionsRequest request)
		{
			return base.Channel.ListJobActions(request);
		}

		public ServerInfoHeader ListJobActions(TrustedUserHeader TrustedUserHeader, out string[] ListJobActionsResult)
		{
			ListJobActionsRequest inValue = new ListJobActionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListJobActionsResponse retVal = ((ReportingService2010Soap)this).ListJobActions(inValue);
			ListJobActionsResult = retVal.ListJobActionsResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListJobActionsResponse> ReportingService2010Soap.ListJobActionsAsync(ListJobActionsRequest request)
		{
			return base.Channel.ListJobActionsAsync(request);
		}

		public System.Threading.Tasks.Task<ListJobActionsResponse> ListJobActionsAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListJobActionsRequest inValue = new ListJobActionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListJobActionsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListJobStatesResponse ReportingService2010Soap.ListJobStates(ListJobStatesRequest request)
		{
			return base.Channel.ListJobStates(request);
		}

		public ServerInfoHeader ListJobStates(TrustedUserHeader TrustedUserHeader, out string[] ListJobStatesResult)
		{
			ListJobStatesRequest inValue = new ListJobStatesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListJobStatesResponse retVal = ((ReportingService2010Soap)this).ListJobStates(inValue);
			ListJobStatesResult = retVal.ListJobStatesResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListJobStatesResponse> ReportingService2010Soap.ListJobStatesAsync(ListJobStatesRequest request)
		{
			return base.Channel.ListJobStatesAsync(request);
		}

		public System.Threading.Tasks.Task<ListJobStatesResponse> ListJobStatesAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListJobStatesRequest inValue = new ListJobStatesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListJobStatesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		CancelJobResponse ReportingService2010Soap.CancelJob(CancelJobRequest request)
		{
			return base.Channel.CancelJob(request);
		}

		public ServerInfoHeader CancelJob(TrustedUserHeader TrustedUserHeader, string JobID, out bool CancelJobResult)
		{
			CancelJobRequest inValue = new CancelJobRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.JobID = JobID;
			CancelJobResponse retVal = ((ReportingService2010Soap)this).CancelJob(inValue);
			CancelJobResult = retVal.CancelJobResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<CancelJobResponse> ReportingService2010Soap.CancelJobAsync(CancelJobRequest request)
		{
			return base.Channel.CancelJobAsync(request);
		}

		public System.Threading.Tasks.Task<CancelJobResponse> CancelJobAsync(TrustedUserHeader TrustedUserHeader, string JobID)
		{
			CancelJobRequest inValue = new CancelJobRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.JobID = JobID;
			return ((ReportingService2010Soap)this).CancelJobAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		CreateCacheRefreshPlanResponse ReportingService2010Soap.CreateCacheRefreshPlan(CreateCacheRefreshPlanRequest request)
		{
			return base.Channel.CreateCacheRefreshPlan(request);
		}

		public ServerInfoHeader CreateCacheRefreshPlan(TrustedUserHeader TrustedUserHeader, string ItemPath, string Description, string EventType, string MatchData, ParameterValue[] Parameters, out string CacheRefreshPlanID)
		{
			CreateCacheRefreshPlanRequest inValue = new CreateCacheRefreshPlanRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Description = Description;
			inValue.EventType = EventType;
			inValue.MatchData = MatchData;
			inValue.Parameters = Parameters;
			CreateCacheRefreshPlanResponse retVal = ((ReportingService2010Soap)this).CreateCacheRefreshPlan(inValue);
			CacheRefreshPlanID = retVal.CacheRefreshPlanID;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<CreateCacheRefreshPlanResponse> ReportingService2010Soap.CreateCacheRefreshPlanAsync(CreateCacheRefreshPlanRequest request)
		{
			return base.Channel.CreateCacheRefreshPlanAsync(request);
		}

		public System.Threading.Tasks.Task<CreateCacheRefreshPlanResponse> CreateCacheRefreshPlanAsync(TrustedUserHeader TrustedUserHeader, string ItemPath, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
		{
			CreateCacheRefreshPlanRequest inValue = new CreateCacheRefreshPlanRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			inValue.Description = Description;
			inValue.EventType = EventType;
			inValue.MatchData = MatchData;
			inValue.Parameters = Parameters;
			return ((ReportingService2010Soap)this).CreateCacheRefreshPlanAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		SetCacheRefreshPlanPropertiesResponse ReportingService2010Soap.SetCacheRefreshPlanProperties(SetCacheRefreshPlanPropertiesRequest request)
		{
			return base.Channel.SetCacheRefreshPlanProperties(request);
		}

		public ServerInfoHeader SetCacheRefreshPlanProperties(TrustedUserHeader TrustedUserHeader, string CacheRefreshPlanID, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
		{
			SetCacheRefreshPlanPropertiesRequest inValue = new SetCacheRefreshPlanPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.CacheRefreshPlanID = CacheRefreshPlanID;
			inValue.Description = Description;
			inValue.EventType = EventType;
			inValue.MatchData = MatchData;
			inValue.Parameters = Parameters;
			SetCacheRefreshPlanPropertiesResponse retVal = ((ReportingService2010Soap)this).SetCacheRefreshPlanProperties(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<SetCacheRefreshPlanPropertiesResponse> ReportingService2010Soap.SetCacheRefreshPlanPropertiesAsync(SetCacheRefreshPlanPropertiesRequest request)
		{
			return base.Channel.SetCacheRefreshPlanPropertiesAsync(request);
		}

		public System.Threading.Tasks.Task<SetCacheRefreshPlanPropertiesResponse> SetCacheRefreshPlanPropertiesAsync(TrustedUserHeader TrustedUserHeader, string CacheRefreshPlanID, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
		{
			SetCacheRefreshPlanPropertiesRequest inValue = new SetCacheRefreshPlanPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.CacheRefreshPlanID = CacheRefreshPlanID;
			inValue.Description = Description;
			inValue.EventType = EventType;
			inValue.MatchData = MatchData;
			inValue.Parameters = Parameters;
			return ((ReportingService2010Soap)this).SetCacheRefreshPlanPropertiesAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetCacheRefreshPlanPropertiesResponse ReportingService2010Soap.GetCacheRefreshPlanProperties(GetCacheRefreshPlanPropertiesRequest request)
		{
			return base.Channel.GetCacheRefreshPlanProperties(request);
		}

		public ServerInfoHeader GetCacheRefreshPlanProperties(TrustedUserHeader TrustedUserHeader, string CacheRefreshPlanID, out string Description, out string LastRunStatus, out CacheRefreshPlanState State, out string EventType, out string MatchData, out ParameterValue[] Parameters)
		{
			GetCacheRefreshPlanPropertiesRequest inValue = new GetCacheRefreshPlanPropertiesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.CacheRefreshPlanID = CacheRefreshPlanID;
			GetCacheRefreshPlanPropertiesResponse retVal = ((ReportingService2010Soap)this).GetCacheRefreshPlanProperties(inValue);
			Description = retVal.Description;
			LastRunStatus = retVal.LastRunStatus;
			State = retVal.State;
			EventType = retVal.EventType;
			MatchData = retVal.MatchData;
			Parameters = retVal.Parameters;
			return retVal.ServerInfoHeader;
		}

		public System.Threading.Tasks.Task<GetCacheRefreshPlanPropertiesResponse> GetCacheRefreshPlanPropertiesAsync(GetCacheRefreshPlanPropertiesRequest request)
		{
			return base.Channel.GetCacheRefreshPlanPropertiesAsync(request);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		DeleteCacheRefreshPlanResponse ReportingService2010Soap.DeleteCacheRefreshPlan(DeleteCacheRefreshPlanRequest request)
		{
			return base.Channel.DeleteCacheRefreshPlan(request);
		}

		public ServerInfoHeader DeleteCacheRefreshPlan(TrustedUserHeader TrustedUserHeader, string CacheRefreshPlanID)
		{
			DeleteCacheRefreshPlanRequest inValue = new DeleteCacheRefreshPlanRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.CacheRefreshPlanID = CacheRefreshPlanID;
			DeleteCacheRefreshPlanResponse retVal = ((ReportingService2010Soap)this).DeleteCacheRefreshPlan(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<DeleteCacheRefreshPlanResponse> ReportingService2010Soap.DeleteCacheRefreshPlanAsync(DeleteCacheRefreshPlanRequest request)
		{
			return base.Channel.DeleteCacheRefreshPlanAsync(request);
		}

		public System.Threading.Tasks.Task<DeleteCacheRefreshPlanResponse> DeleteCacheRefreshPlanAsync(TrustedUserHeader TrustedUserHeader, string CacheRefreshPlanID)
		{
			DeleteCacheRefreshPlanRequest inValue = new DeleteCacheRefreshPlanRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.CacheRefreshPlanID = CacheRefreshPlanID;
			return ((ReportingService2010Soap)this).DeleteCacheRefreshPlanAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListCacheRefreshPlansResponse ReportingService2010Soap.ListCacheRefreshPlans(ListCacheRefreshPlansRequest request)
		{
			return base.Channel.ListCacheRefreshPlans(request);
		}

		public ServerInfoHeader ListCacheRefreshPlans(TrustedUserHeader TrustedUserHeader, string ItemPath, out CacheRefreshPlan[] CacheRefreshPlans)
		{
			ListCacheRefreshPlansRequest inValue = new ListCacheRefreshPlansRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			ListCacheRefreshPlansResponse retVal = ((ReportingService2010Soap)this).ListCacheRefreshPlans(inValue);
			CacheRefreshPlans = retVal.CacheRefreshPlans;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListCacheRefreshPlansResponse> ReportingService2010Soap.ListCacheRefreshPlansAsync(ListCacheRefreshPlansRequest request)
		{
			return base.Channel.ListCacheRefreshPlansAsync(request);
		}

		public System.Threading.Tasks.Task<ListCacheRefreshPlansResponse> ListCacheRefreshPlansAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			ListCacheRefreshPlansRequest inValue = new ListCacheRefreshPlansRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).ListCacheRefreshPlansAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		LogonUserResponse ReportingService2010Soap.LogonUser(LogonUserRequest request)
		{
			return base.Channel.LogonUser(request);
		}

		public ServerInfoHeader LogonUser(TrustedUserHeader TrustedUserHeader, string userName, string password, string authority)
		{
			LogonUserRequest inValue = new LogonUserRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.userName = userName;
			inValue.password = password;
			inValue.authority = authority;
			LogonUserResponse retVal = ((ReportingService2010Soap)this).LogonUser(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<LogonUserResponse> ReportingService2010Soap.LogonUserAsync(LogonUserRequest request)
		{
			return base.Channel.LogonUserAsync(request);
		}

		public System.Threading.Tasks.Task<LogonUserResponse> LogonUserAsync(TrustedUserHeader TrustedUserHeader, string userName, string password, string authority)
		{
			LogonUserRequest inValue = new LogonUserRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.userName = userName;
			inValue.password = password;
			inValue.authority = authority;
			return ((ReportingService2010Soap)this).LogonUserAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		LogoffResponse ReportingService2010Soap.Logoff(LogoffRequest request)
		{
			return base.Channel.Logoff(request);
		}

		public ServerInfoHeader Logoff(TrustedUserHeader TrustedUserHeader)
		{
			LogoffRequest inValue = new LogoffRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			LogoffResponse retVal = ((ReportingService2010Soap)this).Logoff(inValue);
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<LogoffResponse> ReportingService2010Soap.LogoffAsync(LogoffRequest request)
		{
			return base.Channel.LogoffAsync(request);
		}

		public System.Threading.Tasks.Task<LogoffResponse> LogoffAsync(TrustedUserHeader TrustedUserHeader)
		{
			LogoffRequest inValue = new LogoffRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).LogoffAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetPermissionsResponse ReportingService2010Soap.GetPermissions(GetPermissionsRequest request)
		{
			return base.Channel.GetPermissions(request);
		}

		public ServerInfoHeader GetPermissions(TrustedUserHeader TrustedUserHeader, string ItemPath, out string[] Permissions)
		{
			GetPermissionsRequest inValue = new GetPermissionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			GetPermissionsResponse retVal = ((ReportingService2010Soap)this).GetPermissions(inValue);
			Permissions = retVal.Permissions;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetPermissionsResponse> ReportingService2010Soap.GetPermissionsAsync(GetPermissionsRequest request)
		{
			return base.Channel.GetPermissionsAsync(request);
		}

		public System.Threading.Tasks.Task<GetPermissionsResponse> GetPermissionsAsync(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			GetPermissionsRequest inValue = new GetPermissionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			inValue.ItemPath = ItemPath;
			return ((ReportingService2010Soap)this).GetPermissionsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		GetSystemPermissionsResponse ReportingService2010Soap.GetSystemPermissions(GetSystemPermissionsRequest request)
		{
			return base.Channel.GetSystemPermissions(request);
		}

		public ServerInfoHeader GetSystemPermissions(TrustedUserHeader TrustedUserHeader, out string[] Permissions)
		{
			GetSystemPermissionsRequest inValue = new GetSystemPermissionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			GetSystemPermissionsResponse retVal = ((ReportingService2010Soap)this).GetSystemPermissions(inValue);
			Permissions = retVal.Permissions;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<GetSystemPermissionsResponse> ReportingService2010Soap.GetSystemPermissionsAsync(GetSystemPermissionsRequest request)
		{
			return base.Channel.GetSystemPermissionsAsync(request);
		}

		public System.Threading.Tasks.Task<GetSystemPermissionsResponse> GetSystemPermissionsAsync(TrustedUserHeader TrustedUserHeader)
		{
			GetSystemPermissionsRequest inValue = new GetSystemPermissionsRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).GetSystemPermissionsAsync(inValue);
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		ListSecurityScopesResponse ReportingService2010Soap.ListSecurityScopes(ListSecurityScopesRequest request)
		{
			return base.Channel.ListSecurityScopes(request);
		}

		public ServerInfoHeader ListSecurityScopes(TrustedUserHeader TrustedUserHeader, out string[] ListSecurityScopesResult)
		{
			ListSecurityScopesRequest inValue = new ListSecurityScopesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			ListSecurityScopesResponse retVal = ((ReportingService2010Soap)this).ListSecurityScopes(inValue);
			ListSecurityScopesResult = retVal.ListSecurityScopesResult;
			return retVal.ServerInfoHeader;
		}

		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<ListSecurityScopesResponse> ReportingService2010Soap.ListSecurityScopesAsync(ListSecurityScopesRequest request)
		{
			return base.Channel.ListSecurityScopesAsync(request);
		}

		public System.Threading.Tasks.Task<ListSecurityScopesResponse> ListSecurityScopesAsync(TrustedUserHeader TrustedUserHeader)
		{
			ListSecurityScopesRequest inValue = new ListSecurityScopesRequest();
			inValue.TrustedUserHeader = TrustedUserHeader;
			return ((ReportingService2010Soap)this).ListSecurityScopesAsync(inValue);
		}
	}
}