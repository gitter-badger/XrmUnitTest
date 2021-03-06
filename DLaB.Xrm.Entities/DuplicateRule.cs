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
	public enum DuplicateRuleState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 1,
	}
	
	/// <summary>
	/// Rule used to identify potential duplicates.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("duplicaterule")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0001.0117")]
	public partial class DuplicateRule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string BaseEntityMatchCodeTable = "baseentitymatchcodetable";
			public const string BaseEntityName = "baseentityname";
			public const string BaseEntityTypeCode = "baseentitytypecode";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string DuplicateRuleId = "duplicateruleid";
			public const string Id = "duplicateruleid";
			public const string ExcludeInactiveRecords = "excludeinactiverecords";
			public const string IsCaseSensitive = "iscasesensitive";
			public const string MatchingEntityMatchCodeTable = "matchingentitymatchcodetable";
			public const string MatchingEntityName = "matchingentityname";
			public const string MatchingEntityTypeCode = "matchingentitytypecode";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string BusinessUnit_DuplicateRules = "owningbusinessunit";
			public const string lk_duplicaterule_createdonbehalfby = "createdonbehalfby";
			public const string lk_duplicaterule_modifiedonbehalfby = "modifiedonbehalfby";
			public const string lk_duplicaterulebase_createdby = "createdby";
			public const string lk_duplicaterulebase_modifiedby = "modifiedby";
			public const string SystemUser_DuplicateRules = "owninguser";
			public const string team_DuplicateRules = "owningteam";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public DuplicateRule() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "duplicaterule";
		
		public const int EntityTypeCode = 4414;
		
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
		/// Database table that stores match codes for the record type being evaluated for potential duplicates.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseentitymatchcodetable")]
		public string BaseEntityMatchCodeTable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("baseentitymatchcodetable");
			}
		}
		
		/// <summary>
		/// Record type of the record being evaluated for potential duplicates.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseentityname")]
		public string BaseEntityName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("baseentityname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BaseEntityName");
				this.SetAttributeValue("baseentityname", value);
				this.OnPropertyChanged("BaseEntityName");
			}
		}
		
		/// <summary>
		/// Record type of the record being evaluated for potential duplicates.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseentitytypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue BaseEntityTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("baseentitytypecode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the duplicate detection rule.
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
		/// Date and time when the duplicate detection rule was created.
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
		/// Unique identifier of the delegate user who created the duplicaterule.
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
		/// Description of the duplicate detection rule.
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
		/// Unique identifier of the duplicate detection rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicateruleid")]
		public System.Nullable<System.Guid> DuplicateRuleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("duplicateruleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DuplicateRuleId");
				this.SetAttributeValue("duplicateruleid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("DuplicateRuleId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicateruleid")]
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
				this.DuplicateRuleId = value;
			}
		}
		
		/// <summary>
		/// Determines whether to flag inactive records as duplicates
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("excludeinactiverecords")]
		public System.Nullable<bool> ExcludeInactiveRecords
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("excludeinactiverecords");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ExcludeInactiveRecords");
				this.SetAttributeValue("excludeinactiverecords", value);
				this.OnPropertyChanged("ExcludeInactiveRecords");
			}
		}
		
		/// <summary>
		/// Indicates if the operator is case-sensitive.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscasesensitive")]
		public System.Nullable<bool> IsCaseSensitive
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("iscasesensitive");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsCaseSensitive");
				this.SetAttributeValue("iscasesensitive", value);
				this.OnPropertyChanged("IsCaseSensitive");
			}
		}
		
		/// <summary>
		/// Database table that stores match codes for potential duplicate records.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("matchingentitymatchcodetable")]
		public string MatchingEntityMatchCodeTable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("matchingentitymatchcodetable");
			}
		}
		
		/// <summary>
		/// Record type of the records being evaluated as potential duplicates.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("matchingentityname")]
		public string MatchingEntityName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("matchingentityname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MatchingEntityName");
				this.SetAttributeValue("matchingentityname", value);
				this.OnPropertyChanged("MatchingEntityName");
			}
		}
		
		/// <summary>
		/// Record type of the records being evaluated as potential duplicates.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("matchingentitytypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue MatchingEntityTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("matchingentitytypecode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the duplicate detection rule.
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
		/// Date and time when the duplicate detection rule was last modified.
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
		/// Unique identifier of the delegate user who last modified the duplicaterule.
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
		/// Name of the duplicate detection rule.
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
		/// Unique identifier of the user or team who owns the duplicate detection rule.
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
		/// Unique identifier of the business unit that owns duplicate detection rule.
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
		/// Unique identifier of the team who owns the duplicate detection rule.
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
		/// Unique identifier of the user who owns the duplicate detection rule.
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
		/// Status of the duplicate detection rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<DLaB.Xrm.Entities.DuplicateRuleState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((DLaB.Xrm.Entities.DuplicateRuleState)(System.Enum.ToObject(typeof(DLaB.Xrm.Entities.DuplicateRuleState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// Reason for the status of the duplicate detection rule.
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
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// 1:N DuplicateRule_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DuplicateRule_Annotation")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.Annotation> DuplicateRule_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.Annotation>("DuplicateRule_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DuplicateRule_Annotation");
				this.SetRelatedEntities<DLaB.Xrm.Entities.Annotation>("DuplicateRule_Annotation", null, value);
				this.OnPropertyChanged("DuplicateRule_Annotation");
			}
		}
		
		/// <summary>
		/// 1:N DuplicateRule_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DuplicateRule_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.DuplicateRecord> DuplicateRule_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.DuplicateRecord>("DuplicateRule_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DuplicateRule_DuplicateBaseRecord");
				this.SetRelatedEntities<DLaB.Xrm.Entities.DuplicateRecord>("DuplicateRule_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("DuplicateRule_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N DuplicateRule_DuplicateRuleConditions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DuplicateRule_DuplicateRuleConditions")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.DuplicateRuleCondition> DuplicateRule_DuplicateRuleConditions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.DuplicateRuleCondition>("DuplicateRule_DuplicateRuleConditions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DuplicateRule_DuplicateRuleConditions");
				this.SetRelatedEntities<DLaB.Xrm.Entities.DuplicateRuleCondition>("DuplicateRule_DuplicateRuleConditions", null, value);
				this.OnPropertyChanged("DuplicateRule_DuplicateRuleConditions");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_duplicaterule
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_duplicaterule")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.UserEntityInstanceData> userentityinstancedata_duplicaterule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_duplicaterule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_duplicaterule");
				this.SetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_duplicaterule", null, value);
				this.OnPropertyChanged("userentityinstancedata_duplicaterule");
			}
		}
		
		/// <summary>
		/// N:1 BusinessUnit_DuplicateRules
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_DuplicateRules")]
		public DLaB.Xrm.Entities.BusinessUnit BusinessUnit_DuplicateRules
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("BusinessUnit_DuplicateRules", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_duplicaterule_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterule_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_duplicaterule_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_duplicaterule_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_duplicaterule_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterule_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_duplicaterule_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_duplicaterule_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_duplicaterulebase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulebase_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_duplicaterulebase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_duplicaterulebase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_duplicaterulebase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulebase_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_duplicaterulebase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_duplicaterulebase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 SystemUser_DuplicateRules
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_DuplicateRules")]
		public DLaB.Xrm.Entities.SystemUser SystemUser_DuplicateRules
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("SystemUser_DuplicateRules", null);
			}
		}
		
		/// <summary>
		/// N:1 team_DuplicateRules
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_DuplicateRules")]
		public DLaB.Xrm.Entities.Team team_DuplicateRules
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Team>("team_DuplicateRules", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public DuplicateRule(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                if (p.PropertyType == typeof(System.Guid))
                {
                    // Type is Guid, must be Id
                    base.Id = (System.Guid)value;
                    Attributes["duplicateruleid"] = base.Id;
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