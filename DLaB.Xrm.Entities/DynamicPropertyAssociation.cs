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
	/// Association of a property definition with another entity in the system.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("dynamicpropertyassociation")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0001.0117")]
	public partial class DynamicPropertyAssociation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string AssociationStatus = "associationstatus";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DMTImportState = "dmtimportstate";
			public const string DynamicPropertyAssociationId = "dynamicpropertyassociationid";
			public const string Id = "dynamicpropertyassociationid";
			public const string DynamicPropertyId = "dynamicpropertyid";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string InheritanceState = "inheritancestate";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string RegardingObjectid = "regardingobjectid";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string VersionNumber = "versionnumber";
			public const string Dynamicproperty_DynamicPropertyAssociation = "dynamicpropertyid";
			public const string DynamicPropertyAssociation_organization = "organizationid";
			public const string DynamicPropertyAssociation_TransactionCurrency = "transactioncurrencyid";
			public const string lk_DynamicPropertyAssociationattribute_createdby = "createdby";
			public const string lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy = "createdonbehalfby";
			public const string lk_DynamicPropertyAssociationattribute_ModifiedBy = "modifiedby";
			public const string lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Product_DynamicPropertyAssociation = "regardingobjectid";
			public const string ProductAssociation_DynamicPropertyAssociation = "regardingobjectid";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public DynamicPropertyAssociation() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "dynamicpropertyassociation";
		
		public const int EntityTypeCode = 1235;
		
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
		/// Shows the status of the property association.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("associationstatus")]
		public Microsoft.Xrm.Sdk.OptionSetValue AssociationStatus
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("associationstatus");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AssociationStatus");
				this.SetAttributeValue("associationstatus", value);
				this.OnPropertyChanged("AssociationStatus");
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
		/// Shows the unique identifier of the property association.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyassociationid")]
		public System.Nullable<System.Guid> DynamicPropertyAssociationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("dynamicpropertyassociationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DynamicPropertyAssociationId");
				this.SetAttributeValue("dynamicpropertyassociationid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("DynamicPropertyAssociationId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyassociationid")]
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
				this.DynamicPropertyAssociationId = value;
			}
		}
		
		/// <summary>
		/// Shows the property that uses this option set item.
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
		/// Shows the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Shows the inheritance state in relationship to the parent property.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inheritancestate")]
		public Microsoft.Xrm.Sdk.OptionSetValue InheritanceState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("inheritancestate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InheritanceState");
				this.SetAttributeValue("inheritancestate", value);
				this.OnPropertyChanged("InheritanceState");
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
		/// Shows the organization associated with the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Shows the date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Shows the object that the property is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RegardingObjectid");
				this.SetAttributeValue("regardingobjectid", value);
				this.OnPropertyChanged("RegardingObjectid");
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
		/// Shows the version number of the property association.
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
		/// N:1 Dynamicproperty_DynamicPropertyAssociation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Dynamicproperty_DynamicPropertyAssociation")]
		public DLaB.Xrm.Entities.DynamicProperty Dynamicproperty_DynamicPropertyAssociation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.DynamicProperty>("Dynamicproperty_DynamicPropertyAssociation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Dynamicproperty_DynamicPropertyAssociation");
				this.SetRelatedEntity<DLaB.Xrm.Entities.DynamicProperty>("Dynamicproperty_DynamicPropertyAssociation", null, value);
				this.OnPropertyChanged("Dynamicproperty_DynamicPropertyAssociation");
			}
		}
		
		/// <summary>
		/// N:1 DynamicPropertyAssociation_organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicPropertyAssociation_organization")]
		public DLaB.Xrm.Entities.Organization DynamicPropertyAssociation_organization
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Organization>("DynamicPropertyAssociation_organization", null);
			}
		}
		
		/// <summary>
		/// N:1 DynamicPropertyAssociation_TransactionCurrency
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicPropertyAssociation_TransactionCurrency")]
		public DLaB.Xrm.Entities.TransactionCurrency DynamicPropertyAssociation_TransactionCurrency
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.TransactionCurrency>("DynamicPropertyAssociation_TransactionCurrency", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DynamicPropertyAssociation_TransactionCurrency");
				this.SetRelatedEntity<DLaB.Xrm.Entities.TransactionCurrency>("DynamicPropertyAssociation_TransactionCurrency", null, value);
				this.OnPropertyChanged("DynamicPropertyAssociation_TransactionCurrency");
			}
		}
		
		/// <summary>
		/// N:1 lk_DynamicPropertyAssociationattribute_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyAssociationattribute_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_DynamicPropertyAssociationattribute_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_DynamicPropertyAssociationattribute_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy")]
		public DLaB.Xrm.Entities.SystemUser lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_DynamicPropertyAssociationattribute_ModifiedBy
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyAssociationattribute_ModifiedBy")]
		public DLaB.Xrm.Entities.SystemUser lk_DynamicPropertyAssociationattribute_ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_DynamicPropertyAssociationattribute_ModifiedBy", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy")]
		public DLaB.Xrm.Entities.SystemUser lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy", null);
			}
		}
		
		/// <summary>
		/// N:1 Product_DynamicPropertyAssociation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_DynamicPropertyAssociation")]
		public DLaB.Xrm.Entities.Product Product_DynamicPropertyAssociation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Product>("Product_DynamicPropertyAssociation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Product_DynamicPropertyAssociation");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Product>("Product_DynamicPropertyAssociation", null, value);
				this.OnPropertyChanged("Product_DynamicPropertyAssociation");
			}
		}
		
		/// <summary>
		/// N:1 ProductAssociation_DynamicPropertyAssociation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductAssociation_DynamicPropertyAssociation")]
		public DLaB.Xrm.Entities.ProductAssociation ProductAssociation_DynamicPropertyAssociation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.ProductAssociation>("ProductAssociation_DynamicPropertyAssociation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProductAssociation_DynamicPropertyAssociation");
				this.SetRelatedEntity<DLaB.Xrm.Entities.ProductAssociation>("ProductAssociation_DynamicPropertyAssociation", null, value);
				this.OnPropertyChanged("ProductAssociation_DynamicPropertyAssociation");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public DynamicPropertyAssociation(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                if (p.PropertyType == typeof(System.Guid))
                {
                    // Type is Guid, must be Id
                    base.Id = (System.Guid)value;
                    Attributes["dynamicpropertyassociationid"] = base.Id;
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
		
		public virtual dynamicpropertyassociation_associationstatus? AssociationStatusEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((dynamicpropertyassociation_associationstatus?)(EntityOptionSetEnum.GetEnum(this, "associationstatus")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				AssociationStatus = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		public virtual dynamicpropertyassociation_inheritancestate? InheritanceStateEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((dynamicpropertyassociation_inheritancestate?)(EntityOptionSetEnum.GetEnum(this, "inheritancestate")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				InheritanceState = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}