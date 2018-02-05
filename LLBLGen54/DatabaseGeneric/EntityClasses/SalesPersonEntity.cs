﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.4.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.v54.HelperClasses;
using AdventureWorks.Dal.Adapter.v54.FactoryClasses;
using AdventureWorks.Dal.Adapter.v54.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v54.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'SalesPerson'.<br/><br/></summary>
	[Serializable]
	public partial class SalesPersonEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders;
		private EntityCollection<SalesPersonQuotaHistoryEntity> _salesPersonQuotaHistories;
		private EntityCollection<SalesTerritoryHistoryEntity> _salesTerritoryHistories;
		private EntityCollection<StoreEntity> _stores;
		private SalesTerritoryEntity _salesTerritory;
		private EmployeeEntity _employee;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static SalesPersonEntityStaticMetaData _staticMetaData = new SalesPersonEntityStaticMetaData();
		private static SalesPersonRelations _relationsFactory = new SalesPersonRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SalesTerritory</summary>
			public static readonly string SalesTerritory = "SalesTerritory";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name SalesPersonQuotaHistories</summary>
			public static readonly string SalesPersonQuotaHistories = "SalesPersonQuotaHistories";
			/// <summary>Member name SalesTerritoryHistories</summary>
			public static readonly string SalesTerritoryHistories = "SalesTerritoryHistories";
			/// <summary>Member name Stores</summary>
			public static readonly string Stores = "Stores";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class SalesPersonEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public SalesPersonEntityStaticMetaData()
			{
				SetEntityCoreInfo("SalesPersonEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.SalesPersonEntity, typeof(SalesPersonEntity), typeof(SalesPersonEntityFactory), false);
				AddNavigatorMetaData<SalesPersonEntity, EntityCollection<SalesOrderHeaderEntity>>("SalesOrderHeaders", a => a._salesOrderHeaders, (a, b) => a._salesOrderHeaders = b, a => a.SalesOrderHeaders, () => new SalesPersonRelations().SalesOrderHeaderEntityUsingSalesPersonId, typeof(SalesOrderHeaderEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.SalesOrderHeaderEntity);
				AddNavigatorMetaData<SalesPersonEntity, EntityCollection<SalesPersonQuotaHistoryEntity>>("SalesPersonQuotaHistories", a => a._salesPersonQuotaHistories, (a, b) => a._salesPersonQuotaHistories = b, a => a.SalesPersonQuotaHistories, () => new SalesPersonRelations().SalesPersonQuotaHistoryEntityUsingSalesPersonId, typeof(SalesPersonQuotaHistoryEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.SalesPersonQuotaHistoryEntity);
				AddNavigatorMetaData<SalesPersonEntity, EntityCollection<SalesTerritoryHistoryEntity>>("SalesTerritoryHistories", a => a._salesTerritoryHistories, (a, b) => a._salesTerritoryHistories = b, a => a.SalesTerritoryHistories, () => new SalesPersonRelations().SalesTerritoryHistoryEntityUsingSalesPersonId, typeof(SalesTerritoryHistoryEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.SalesTerritoryHistoryEntity);
				AddNavigatorMetaData<SalesPersonEntity, EntityCollection<StoreEntity>>("Stores", a => a._stores, (a, b) => a._stores = b, a => a.Stores, () => new SalesPersonRelations().StoreEntityUsingSalesPersonId, typeof(StoreEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.StoreEntity);
				AddNavigatorMetaData<SalesPersonEntity, SalesTerritoryEntity>("SalesTerritory", "SalesPeople", (a, b) => a._salesTerritory = b, a => a._salesTerritory, (a, b) => a.SalesTerritory = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticSalesPersonRelations.SalesTerritoryEntityUsingTerritoryIdStatic, ()=>new SalesPersonRelations().SalesTerritoryEntityUsingTerritoryId, null, new int[] { (int)SalesPersonFieldIndex.TerritoryId }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.SalesTerritoryEntity);
				AddNavigatorMetaData<SalesPersonEntity, EmployeeEntity>("Employee", "SalesPerson", (a, b) => a._employee = b, a => a._employee, (a, b) => a.Employee = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticSalesPersonRelations.EmployeeEntityUsingSalesPersonIdStatic, ()=>new SalesPersonRelations().EmployeeEntityUsingSalesPersonId, null, new int[] { (int)SalesPersonFieldIndex.SalesPersonId }, null, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.EmployeeEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static SalesPersonEntity()
		{
		}

		/// <summary> CTor</summary>
		public SalesPersonEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SalesPersonEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SalesPersonEntity</param>
		public SalesPersonEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="salesPersonId">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		public SalesPersonEntity(System.Int32 salesPersonId) : this(salesPersonId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="salesPersonId">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <param name="validator">The custom validator object for this SalesPersonEntity</param>
		public SalesPersonEntity(System.Int32 salesPersonId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.SalesPersonId = salesPersonId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesPersonEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders() { return CreateRelationInfoForNavigator("SalesOrderHeaders"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesPersonQuotaHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPersonQuotaHistories() { return CreateRelationInfoForNavigator("SalesPersonQuotaHistories"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritoryHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritoryHistories() { return CreateRelationInfoForNavigator("SalesTerritoryHistories"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Store' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStores() { return CreateRelationInfoForNavigator("Stores"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SalesTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritory() { return CreateRelationInfoForNavigator("SalesTerritory"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee() { return CreateRelationInfoForNavigator("Employee"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SalesPersonEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static SalesPersonRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaders	{ get { return _staticMetaData.GetPrefetchPathElement("SalesOrderHeaders", CommonEntityBase.CreateEntityCollection<SalesOrderHeaderEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPersonQuotaHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPersonQuotaHistories	{ get { return _staticMetaData.GetPrefetchPathElement("SalesPersonQuotaHistories", CommonEntityBase.CreateEntityCollection<SalesPersonQuotaHistoryEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritoryHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritoryHistories	{ get { return _staticMetaData.GetPrefetchPathElement("SalesTerritoryHistories", CommonEntityBase.CreateEntityCollection<SalesTerritoryHistoryEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Store' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStores	{ get { return _staticMetaData.GetPrefetchPathElement("Stores", CommonEntityBase.CreateEntityCollection<StoreEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritory { get { return _staticMetaData.GetPrefetchPathElement("SalesTerritory", CommonEntityBase.CreateEntityCollection<SalesTerritoryEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee { get { return _staticMetaData.GetPrefetchPathElement("Employee", CommonEntityBase.CreateEntityCollection<EmployeeEntity>()); } }

		/// <summary>The Bonus property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."Bonus".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Bonus
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.Bonus, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.Bonus, value); }
		}

		/// <summary>The CommissionPct property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."CommissionPct".<br/>Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CommissionPct
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.CommissionPct, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.CommissionPct, value); }
		}

		/// <summary>The ModifiedDate property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesPersonFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Rowguid property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesPersonFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.Rowguid, value); }
		}

		/// <summary>The SalesLastYear property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."SalesLastYear".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesLastYear
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.SalesLastYear, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesLastYear, value); }
		}

		/// <summary>The SalesPersonId property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."BusinessEntityID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SalesPersonId
		{
			get { return (System.Int32)GetValue((int)SalesPersonFieldIndex.SalesPersonId, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesPersonId, value); }
		}

		/// <summary>The SalesQuota property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."SalesQuota".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> SalesQuota
		{
			get { return (Nullable<System.Decimal>)GetValue((int)SalesPersonFieldIndex.SalesQuota, false); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesQuota, value); }
		}

		/// <summary>The SalesYtd property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."SalesYTD".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesYtd
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.SalesYtd, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesYtd, value); }
		}

		/// <summary>The TerritoryId property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."TerritoryID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TerritoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesPersonFieldIndex.TerritoryId, false); }
			set	{ SetValue((int)SalesPersonFieldIndex.TerritoryId, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders { get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("SalesPerson", true, false, ref _salesOrderHeaders); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesPersonQuotaHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesPersonQuotaHistoryEntity))]
		public virtual EntityCollection<SalesPersonQuotaHistoryEntity> SalesPersonQuotaHistories { get { return GetOrCreateEntityCollection<SalesPersonQuotaHistoryEntity, SalesPersonQuotaHistoryEntityFactory>("SalesPerson", true, false, ref _salesPersonQuotaHistories); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesTerritoryHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryHistoryEntity))]
		public virtual EntityCollection<SalesTerritoryHistoryEntity> SalesTerritoryHistories { get { return GetOrCreateEntityCollection<SalesTerritoryHistoryEntity, SalesTerritoryHistoryEntityFactory>("SalesPerson", true, false, ref _salesTerritoryHistories); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'StoreEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(StoreEntity))]
		public virtual EntityCollection<StoreEntity> Stores { get { return GetOrCreateEntityCollection<StoreEntity, StoreEntityFactory>("SalesPerson", true, false, ref _stores); } }

		/// <summary>Gets / sets related entity of type 'SalesTerritoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual SalesTerritoryEntity SalesTerritory
		{
			get	{ return _salesTerritory; }
			set { SetSingleRelatedEntityNavigator(value, "SalesTerritory"); }
		}

		/// <summary>Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/></summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get { return _employee; }
			set { SetSingleRelatedEntityNavigator(value, "Employee"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum SalesPersonFieldIndex
	{
		///<summary>Bonus. </summary>
		Bonus,
		///<summary>CommissionPct. </summary>
		CommissionPct,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesLastYear. </summary>
		SalesLastYear,
		///<summary>SalesPersonId. </summary>
		SalesPersonId,
		///<summary>SalesQuota. </summary>
		SalesQuota,
		///<summary>SalesYtd. </summary>
		SalesYtd,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: SalesPerson. </summary>
	public partial class SalesPersonRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields: SalesPerson.SalesPersonId - SalesOrderHeader.SalesPersonId</summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingSalesPersonId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesOrderHeaders", true, new[] { SalesPersonFields.SalesPersonId, SalesOrderHeaderFields.SalesPersonId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and SalesPersonQuotaHistoryEntity over the 1:n relation they have, using the relation between the fields: SalesPerson.SalesPersonId - SalesPersonQuotaHistory.SalesPersonId</summary>
		public virtual IEntityRelation SalesPersonQuotaHistoryEntityUsingSalesPersonId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesPersonQuotaHistories", true, new[] { SalesPersonFields.SalesPersonId, SalesPersonQuotaHistoryFields.SalesPersonId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and SalesTerritoryHistoryEntity over the 1:n relation they have, using the relation between the fields: SalesPerson.SalesPersonId - SalesTerritoryHistory.SalesPersonId</summary>
		public virtual IEntityRelation SalesTerritoryHistoryEntityUsingSalesPersonId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesTerritoryHistories", true, new[] { SalesPersonFields.SalesPersonId, SalesTerritoryHistoryFields.SalesPersonId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and StoreEntity over the 1:n relation they have, using the relation between the fields: SalesPerson.SalesPersonId - Store.SalesPersonId</summary>
		public virtual IEntityRelation StoreEntityUsingSalesPersonId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Stores", true, new[] { SalesPersonFields.SalesPersonId, StoreFields.SalesPersonId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and EmployeeEntity over the 1:1 relation they have, using the relation between the fields: SalesPerson.SalesPersonId - Employee.EmployeeId</summary>
		public virtual IEntityRelation EmployeeEntityUsingSalesPersonId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToOne, "Employee", false, new[] { EmployeeFields.EmployeeId, SalesPersonFields.SalesPersonId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and SalesTerritoryEntity over the m:1 relation they have, using the relation between the fields: SalesPerson.TerritoryId - SalesTerritory.TerritoryId</summary>
		public virtual IEntityRelation SalesTerritoryEntityUsingTerritoryId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "SalesTerritory", false, new[] { SalesTerritoryFields.TerritoryId, SalesPersonFields.TerritoryId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSalesPersonRelations
	{
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingSalesPersonIdStatic = new SalesPersonRelations().SalesOrderHeaderEntityUsingSalesPersonId;
		internal static readonly IEntityRelation SalesPersonQuotaHistoryEntityUsingSalesPersonIdStatic = new SalesPersonRelations().SalesPersonQuotaHistoryEntityUsingSalesPersonId;
		internal static readonly IEntityRelation SalesTerritoryHistoryEntityUsingSalesPersonIdStatic = new SalesPersonRelations().SalesTerritoryHistoryEntityUsingSalesPersonId;
		internal static readonly IEntityRelation StoreEntityUsingSalesPersonIdStatic = new SalesPersonRelations().StoreEntityUsingSalesPersonId;
		internal static readonly IEntityRelation EmployeeEntityUsingSalesPersonIdStatic = new SalesPersonRelations().EmployeeEntityUsingSalesPersonId;
		internal static readonly IEntityRelation SalesTerritoryEntityUsingTerritoryIdStatic = new SalesPersonRelations().SalesTerritoryEntityUsingTerritoryId;

		/// <summary>CTor</summary>
		static StaticSalesPersonRelations() { }
	}
}
