//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLaB.Xrm.Entities
{
	
	/// <summary>
	/// Instance of a property with its value.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("dynamicpropertyinstance")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0001.0117")]
	public partial class DynamicPropertyInstance : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DMTImportState = "dmtimportstate";
			public const string DynamicPropertyId = "dynamicpropertyid";
			public const string DynamicPropertyInstanceid = "dynamicpropertyinstanceid";
			public const string Id = "dynamicpropertyinstanceid";
			public const string ExchangeRate = "exchangerate";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string RegardingObjectId = "regardingobjectid";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string validationstatus = "validationstatus";
			public const string ValueDecimal = "valuedecimal";
			public const string ValueDouble = "valuedouble";
			public const string ValueInteger = "valueinteger";
			public const string ValueString = "valuestring";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_dynamicproperyinstance = "owningbusinessunit";
			public const string DynamicProperty_DynamicPropertyInstance = "dynamicpropertyid";
			public const string Dynamicpropertyinsatance_createdby = "createdby";
			public const string InvoiceDetail_Dynamicpropertyinstance = "regardingobjectid";
			public const string lk_Dynamicpropertyinsatanceattribute_createdonbehalfby = "createdonbehalfby";
			public const string lk_Dynamicpropertyinsatanceattribute_ModifiedBy = "modifiedby";
			public const string lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OpportunityProduct_Dynamicpropertyinstance = "regardingobjectid";
			public const string OwningUser_Dynamicpropertyinsatance = "dynamicpropertyinstanceid";
			public const string QuoteDetail_Dynamicpropertyinstance = "regardingobjectid";
			public const string SalesOrderDetail_Dynamicpropertyinstance = "regardingobjectid";
			public const string team_DynamicPropertyInstance = "owningteam";
			public const string TransactionCurrency_Dynamicpropertyinsatance = "dynamicpropertyinstanceid";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public DynamicPropertyInstance() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "dynamicpropertyinstance";
		
		public const int EntityTypeCode = 1333;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Shows who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Internal Use Only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dmtimportstate")]
		public System.Nullable<int> DMTImportState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("dmtimportstate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DMTImportState");
				this.SetAttributeValue("dmtimportstate", value);
				this.OnPropertyChanged("DMTImportState");
			}
		}
		
		/// <summary>
		/// Shows the property that this record is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
		public Microsoft.Xrm.Sdk.EntityReference DynamicPropertyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("dynamicpropertyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DynamicPropertyId");
				this.SetAttributeValue("dynamicpropertyid", value);
				this.OnPropertyChanged("DynamicPropertyId");
			}
		}
		
		/// <summary>
		/// Shows the unique identifier of the property instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyinstanceid")]
		public System.Nullable<System.Guid> DynamicPropertyInstanceid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("dynamicpropertyinstanceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DynamicPropertyInstanceid");
				this.SetAttributeValue("dynamicpropertyinstanceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("DynamicPropertyInstanceid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyinstanceid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.DynamicPropertyInstanceid = value;
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was last updated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Shows the business unit that the record owner belongs to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Shows the team who owns the property instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Shows the user who owns the property instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Shows the object that the property is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RegardingObjectId");
				this.SetAttributeValue("regardingobjectid", value);
				this.OnPropertyChanged("RegardingObjectId");
			}
		}
		
		/// <summary>
		/// Shows the currency associated with the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Shows whether the property value is valid.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("validationstatus")]
		public System.Nullable<bool> validationstatus
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("validationstatus");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("validationstatus");
				this.SetAttributeValue("validationstatus", value);
				this.OnPropertyChanged("validationstatus");
			}
		}
		
		/// <summary>
		/// Shows the decimal value of the property.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("valuedecimal")]
		public System.Nullable<decimal> ValueDecimal
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("valuedecimal");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ValueDecimal");
				this.SetAttributeValue("valuedecimal", value);
				this.OnPropertyChanged("ValueDecimal");
			}
		}
		
		/// <summary>
		/// Shows the double value of the property.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("valuedouble")]
		public System.Nullable<double> ValueDouble
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("valuedouble");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ValueDouble");
				this.SetAttributeValue("valuedouble", value);
				this.OnPropertyChanged("ValueDouble");
			}
		}
		
		/// <summary>
		/// Shows the integer value of the property.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("valueinteger")]
		public System.Nullable<int> ValueInteger
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("valueinteger");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ValueInteger");
				this.SetAttributeValue("valueinteger", value);
				this.OnPropertyChanged("ValueInteger");
			}
		}
		
		/// <summary>
		/// Shows the string value of the property.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("valuestring")]
		public string ValueString
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("valuestring");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ValueString");
				this.SetAttributeValue("valuestring", value);
				this.OnPropertyChanged("ValueString");
			}
		}
		
		/// <summary>
		/// Shows the version number of the property instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_dynamicproperyinstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_dynamicproperyinstance")]
		public DLaB.Xrm.Entities.BusinessUnit business_unit_dynamicproperyinstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_dynamicproperyinstance", null);
			}
		}
		
		/// <summary>
		/// N:1 DynamicProperty_DynamicPropertyInstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicProperty_DynamicPropertyInstance")]
		public DLaB.Xrm.Entities.DynamicProperty DynamicProperty_DynamicPropertyInstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.DynamicProperty>("DynamicProperty_DynamicPropertyInstance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DynamicProperty_DynamicPropertyInstance");
				this.SetRelatedEntity<DLaB.Xrm.Entities.DynamicProperty>("DynamicProperty_DynamicPropertyInstance", null, value);
				this.OnPropertyChanged("DynamicProperty_DynamicPropertyInstance");
			}
		}
		
		/// <summary>
		/// N:1 Dynamicpropertyinsatance_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Dynamicpropertyinsatance_createdby")]
		public DLaB.Xrm.Entities.SystemUser Dynamicpropertyinsatance_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("Dynamicpropertyinsatance_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 InvoiceDetail_Dynamicpropertyinstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("InvoiceDetail_Dynamicpropertyinstance")]
		public DLaB.Xrm.Entities.InvoiceDetail InvoiceDetail_Dynamicpropertyinstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.InvoiceDetail>("InvoiceDetail_Dynamicpropertyinstance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InvoiceDetail_Dynamicpropertyinstance");
				this.SetRelatedEntity<DLaB.Xrm.Entities.InvoiceDetail>("InvoiceDetail_Dynamicpropertyinstance", null, value);
				this.OnPropertyChanged("InvoiceDetail_Dynamicpropertyinstance");
			}
		}
		
		/// <summary>
		/// N:1 lk_Dynamicpropertyinsatanceattribute_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_Dynamicpropertyinsatanceattribute_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_Dynamicpropertyinsatanceattribute_ModifiedBy
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_Dynamicpropertyinsatanceattribute_ModifiedBy")]
		public DLaB.Xrm.Entities.SystemUser lk_Dynamicpropertyinsatanceattribute_ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_Dynamicpropertyinsatanceattribute_ModifiedBy", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy")]
		public DLaB.Xrm.Entities.SystemUser lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy", null);
			}
		}
		
		/// <summary>
		/// N:1 OpportunityProduct_Dynamicpropertyinstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityProduct_Dynamicpropertyinstance")]
		public DLaB.Xrm.Entities.OpportunityProduct OpportunityProduct_Dynamicpropertyinstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.OpportunityProduct>("OpportunityProduct_Dynamicpropertyinstance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OpportunityProduct_Dynamicpropertyinstance");
				this.SetRelatedEntity<DLaB.Xrm.Entities.OpportunityProduct>("OpportunityProduct_Dynamicpropertyinstance", null, value);
				this.OnPropertyChanged("OpportunityProduct_Dynamicpropertyinstance");
			}
		}
		
		/// <summary>
		/// N:1 OwningUser_Dynamicpropertyinsatance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyinstanceid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OwningUser_Dynamicpropertyinsatance")]
		public DLaB.Xrm.Entities.SystemUser OwningUser_Dynamicpropertyinsatance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("OwningUser_Dynamicpropertyinsatance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningUser_Dynamicpropertyinsatance");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("OwningUser_Dynamicpropertyinsatance", null, value);
				this.OnPropertyChanged("OwningUser_Dynamicpropertyinsatance");
			}
		}
		
		/// <summary>
		/// N:1 QuoteDetail_Dynamicpropertyinstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteDetail_Dynamicpropertyinstance")]
		public DLaB.Xrm.Entities.QuoteDetail QuoteDetail_Dynamicpropertyinstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.QuoteDetail>("QuoteDetail_Dynamicpropertyinstance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("QuoteDetail_Dynamicpropertyinstance");
				this.SetRelatedEntity<DLaB.Xrm.Entities.QuoteDetail>("QuoteDetail_Dynamicpropertyinstance", null, value);
				this.OnPropertyChanged("QuoteDetail_Dynamicpropertyinstance");
			}
		}
		
		/// <summary>
		/// N:1 SalesOrderDetail_Dynamicpropertyinstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrderDetail_Dynamicpropertyinstance")]
		public DLaB.Xrm.Entities.SalesOrderDetail SalesOrderDetail_Dynamicpropertyinstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SalesOrderDetail>("SalesOrderDetail_Dynamicpropertyinstance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SalesOrderDetail_Dynamicpropertyinstance");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SalesOrderDetail>("SalesOrderDetail_Dynamicpropertyinstance", null, value);
				this.OnPropertyChanged("SalesOrderDetail_Dynamicpropertyinstance");
			}
		}
		
		/// <summary>
		/// N:1 team_DynamicPropertyInstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_DynamicPropertyInstance")]
		public DLaB.Xrm.Entities.Team team_DynamicPropertyInstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Team>("team_DynamicPropertyInstance", null);
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_Dynamicpropertyinsatance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyinstanceid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Dynamicpropertyinsatance")]
		public DLaB.Xrm.Entities.TransactionCurrency TransactionCurrency_Dynamicpropertyinsatance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.TransactionCurrency>("TransactionCurrency_Dynamicpropertyinsatance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrency_Dynamicpropertyinsatance");
				this.SetRelatedEntity<DLaB.Xrm.Entities.TransactionCurrency>("TransactionCurrency_Dynamicpropertyinsatance", null, value);
				this.OnPropertyChanged("TransactionCurrency_Dynamicpropertyinsatance");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public DynamicPropertyInstance(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                if (p.PropertyType == typeof(System.Guid))
                {
                    // Type is Guid, must be Id
                    base.Id = (System.Guid)value;
                    Attributes["dynamicpropertyinstanceid"] = base.Id;
                }
                else if (p.Name == "FormattedValues")
                {
                    // Add Support for FormattedValues
                    FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                }
                else
                {
                    Attributes[p.Name.ToLower()] = value;
                }
            }
		}
	}
}