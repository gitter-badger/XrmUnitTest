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
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0001.0117")]
	public enum UoMScheduleState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Grouping of units.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uomschedule")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0001.0117")]
	public partial class UoMSchedule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string BaseUoMName = "baseuomname";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string UoMScheduleId = "uomscheduleid";
			public const string Id = "uomscheduleid";
			public const string VersionNumber = "versionnumber";
			public const string lk_uomschedule_createdonbehalfby = "createdonbehalfby";
			public const string lk_uomschedule_modifiedonbehalfby = "modifiedonbehalfby";
			public const string lk_uomschedulebase_createdby = "createdby";
			public const string lk_uomschedulebase_modifiedby = "modifiedby";
			public const string organization_uof_schedules = "organizationid";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public UoMSchedule() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "uomschedule";
		
		public const int EntityTypeCode = 1056;
		
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
		/// Name of the base unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseuomname")]
		public string BaseUoMName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("baseuomname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BaseUoMName");
				this.SetAttributeValue("baseuomname", value);
				this.OnPropertyChanged("BaseUoMName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the unit group.
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
		/// Date and time when the unit group was created.
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
		/// Unique identifier of the delegate user who created the uomschedule.
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
		/// Description of the unit group.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
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
		/// Unique identifier of the user who last modified the unit group.
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
		/// Date and time when the unit group was last modified.
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
		/// Unique identifier of the delegate user who last modified the uomschedule.
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
		/// Name of the unit group.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the unit group.
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
		/// Date and time that the record was migrated.
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
		/// Status of the Unit Group.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<DLaB.Xrm.Entities.UoMScheduleState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((DLaB.Xrm.Entities.UoMScheduleState)(System.Enum.ToObject(typeof(DLaB.Xrm.Entities.UoMScheduleState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// Reason for the status of the Unit Group.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// Unique identifier for the unit group.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
		public System.Nullable<System.Guid> UoMScheduleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("uomscheduleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UoMScheduleId");
				this.SetAttributeValue("uomscheduleid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("UoMScheduleId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
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
				this.UoMScheduleId = value;
			}
		}
		
		/// <summary>
		/// Version number of the unit group.
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
		/// 1:N contract_detail_unit_of_measure_schedule
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_detail_unit_of_measure_schedule")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.ContractDetail> contract_detail_unit_of_measure_schedule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.ContractDetail>("contract_detail_unit_of_measure_schedule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("contract_detail_unit_of_measure_schedule");
				this.SetRelatedEntities<DLaB.Xrm.Entities.ContractDetail>("contract_detail_unit_of_measure_schedule", null, value);
				this.OnPropertyChanged("contract_detail_unit_of_measure_schedule");
			}
		}
		
		/// <summary>
		/// 1:N unit_of_measure_schedule_conversions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measure_schedule_conversions")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.UoM> unit_of_measure_schedule_conversions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.UoM>("unit_of_measure_schedule_conversions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("unit_of_measure_schedule_conversions");
				this.SetRelatedEntities<DLaB.Xrm.Entities.UoM>("unit_of_measure_schedule_conversions", null, value);
				this.OnPropertyChanged("unit_of_measure_schedule_conversions");
			}
		}
		
		/// <summary>
		/// 1:N unit_of_measure_schedule_product_price_level
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measure_schedule_product_price_level")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.ProductPriceLevel> unit_of_measure_schedule_product_price_level
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.ProductPriceLevel>("unit_of_measure_schedule_product_price_level", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("unit_of_measure_schedule_product_price_level");
				this.SetRelatedEntities<DLaB.Xrm.Entities.ProductPriceLevel>("unit_of_measure_schedule_product_price_level", null, value);
				this.OnPropertyChanged("unit_of_measure_schedule_product_price_level");
			}
		}
		
		/// <summary>
		/// 1:N unit_of_measurement_schedule_products
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_schedule_products")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.Product> unit_of_measurement_schedule_products
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.Product>("unit_of_measurement_schedule_products", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("unit_of_measurement_schedule_products");
				this.SetRelatedEntities<DLaB.Xrm.Entities.Product>("unit_of_measurement_schedule_products", null, value);
				this.OnPropertyChanged("unit_of_measurement_schedule_products");
			}
		}
		
		/// <summary>
		/// 1:N UoMSchedule_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UoMSchedule_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.AsyncOperation> UoMSchedule_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("UoMSchedule_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UoMSchedule_AsyncOperations");
				this.SetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("UoMSchedule_AsyncOperations", null, value);
				this.OnPropertyChanged("UoMSchedule_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N UoMSchedule_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UoMSchedule_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.BulkDeleteFailure> UoMSchedule_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("UoMSchedule_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UoMSchedule_BulkDeleteFailures");
				this.SetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("UoMSchedule_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("UoMSchedule_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_uomschedule
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_uomschedule")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.UserEntityInstanceData> userentityinstancedata_uomschedule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_uomschedule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_uomschedule");
				this.SetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_uomschedule", null, value);
				this.OnPropertyChanged("userentityinstancedata_uomschedule");
			}
		}
		
		/// <summary>
		/// N:1 lk_uomschedule_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_uomschedule_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_uomschedule_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_uomschedule_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_uomschedule_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_uomschedule_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_uomschedulebase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_uomschedulebase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_uomschedulebase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_uomschedulebase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_uomschedulebase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_uomschedulebase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 organization_uof_schedules
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_uof_schedules")]
		public DLaB.Xrm.Entities.Organization organization_uof_schedules
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Organization>("organization_uof_schedules", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public UoMSchedule(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                if (p.PropertyType == typeof(System.Guid))
                {
                    // Type is Guid, must be Id
                    base.Id = (System.Guid)value;
                    Attributes["uomscheduleid"] = base.Id;
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