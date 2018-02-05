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
	/// <summary>Entity class which represents the entity 'CountryRegionCurrency'.<br/><br/></summary>
	[Serializable]
	public partial class CountryRegionCurrencyEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private CountryRegionEntity _countryRegion;
		private CurrencyEntity _currency;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static CountryRegionCurrencyEntityStaticMetaData _staticMetaData = new CountryRegionCurrencyEntityStaticMetaData();
		private static CountryRegionCurrencyRelations _relationsFactory = new CountryRegionCurrencyRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CountryRegion</summary>
			public static readonly string CountryRegion = "CountryRegion";
			/// <summary>Member name Currency</summary>
			public static readonly string Currency = "Currency";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class CountryRegionCurrencyEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public CountryRegionCurrencyEntityStaticMetaData()
			{
				SetEntityCoreInfo("CountryRegionCurrencyEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.CountryRegionCurrencyEntity, typeof(CountryRegionCurrencyEntity), typeof(CountryRegionCurrencyEntityFactory), false);
				AddNavigatorMetaData<CountryRegionCurrencyEntity, CountryRegionEntity>("CountryRegion", "CountryRegionCurrencies", (a, b) => a._countryRegion = b, a => a._countryRegion, (a, b) => a.CountryRegion = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticCountryRegionCurrencyRelations.CountryRegionEntityUsingCountryRegionCodeStatic, ()=>new CountryRegionCurrencyRelations().CountryRegionEntityUsingCountryRegionCode, null, new int[] { (int)CountryRegionCurrencyFieldIndex.CountryRegionCode }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.CountryRegionEntity);
				AddNavigatorMetaData<CountryRegionCurrencyEntity, CurrencyEntity>("Currency", "CountryRegionCurrencies", (a, b) => a._currency = b, a => a._currency, (a, b) => a.Currency = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticCountryRegionCurrencyRelations.CurrencyEntityUsingCurrencyCodeStatic, ()=>new CountryRegionCurrencyRelations().CurrencyEntityUsingCurrencyCode, null, new int[] { (int)CountryRegionCurrencyFieldIndex.CurrencyCode }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.CurrencyEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static CountryRegionCurrencyEntity()
		{
		}

		/// <summary> CTor</summary>
		public CountryRegionCurrencyEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CountryRegionCurrencyEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CountryRegionCurrencyEntity</param>
		public CountryRegionCurrencyEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		public CountryRegionCurrencyEntity(System.String countryRegionCode, System.String currencyCode) : this(countryRegionCode, currencyCode, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="validator">The custom validator object for this CountryRegionCurrencyEntity</param>
		public CountryRegionCurrencyEntity(System.String countryRegionCode, System.String currencyCode, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.CountryRegionCode = countryRegionCode;
			this.CurrencyCode = currencyCode;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CountryRegionCurrencyEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'CountryRegion' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCountryRegion() { return CreateRelationInfoForNavigator("CountryRegion"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Currency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrency() { return CreateRelationInfoForNavigator("Currency"); }
		
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
		/// <param name="validator">The validator object for this CountryRegionCurrencyEntity</param>
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
		public static CountryRegionCurrencyRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CountryRegion' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCountryRegion { get { return _staticMetaData.GetPrefetchPathElement("CountryRegion", CommonEntityBase.CreateEntityCollection<CountryRegionEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Currency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrency { get { return _staticMetaData.GetPrefetchPathElement("Currency", CommonEntityBase.CreateEntityCollection<CurrencyEntity>()); } }

		/// <summary>The CountryRegionCode property of the Entity CountryRegionCurrency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegionCurrency"."CountryRegionCode".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)CountryRegionCurrencyFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)CountryRegionCurrencyFieldIndex.CountryRegionCode, value); }
		}

		/// <summary>The CurrencyCode property of the Entity CountryRegionCurrency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegionCurrency"."CurrencyCode".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CurrencyCode
		{
			get { return (System.String)GetValue((int)CountryRegionCurrencyFieldIndex.CurrencyCode, true); }
			set	{ SetValue((int)CountryRegionCurrencyFieldIndex.CurrencyCode, value); }
		}

		/// <summary>The ModifiedDate property of the Entity CountryRegionCurrency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegionCurrency"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CountryRegionCurrencyFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CountryRegionCurrencyFieldIndex.ModifiedDate, value); }
		}

		/// <summary>Gets / sets related entity of type 'CountryRegionEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CountryRegionEntity CountryRegion
		{
			get	{ return _countryRegion; }
			set { SetSingleRelatedEntityNavigator(value, "CountryRegion"); }
		}

		/// <summary>Gets / sets related entity of type 'CurrencyEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CurrencyEntity Currency
		{
			get	{ return _currency; }
			set { SetSingleRelatedEntityNavigator(value, "Currency"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum CountryRegionCurrencyFieldIndex
	{
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>CurrencyCode. </summary>
		CurrencyCode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: CountryRegionCurrency. </summary>
	public partial class CountryRegionCurrencyRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between CountryRegionCurrencyEntity and CountryRegionEntity over the m:1 relation they have, using the relation between the fields: CountryRegionCurrency.CountryRegionCode - CountryRegion.CountryRegionCode</summary>
		public virtual IEntityRelation CountryRegionEntityUsingCountryRegionCode
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "CountryRegion", false, new[] { CountryRegionFields.CountryRegionCode, CountryRegionCurrencyFields.CountryRegionCode }); }
		}

		/// <summary>Returns a new IEntityRelation object, between CountryRegionCurrencyEntity and CurrencyEntity over the m:1 relation they have, using the relation between the fields: CountryRegionCurrency.CurrencyCode - Currency.CurrencyCode</summary>
		public virtual IEntityRelation CurrencyEntityUsingCurrencyCode
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Currency", false, new[] { CurrencyFields.CurrencyCode, CountryRegionCurrencyFields.CurrencyCode }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticCountryRegionCurrencyRelations
	{
		internal static readonly IEntityRelation CountryRegionEntityUsingCountryRegionCodeStatic = new CountryRegionCurrencyRelations().CountryRegionEntityUsingCountryRegionCode;
		internal static readonly IEntityRelation CurrencyEntityUsingCurrencyCodeStatic = new CountryRegionCurrencyRelations().CurrencyEntityUsingCurrencyCode;

		/// <summary>CTor</summary>
		static StaticCountryRegionCurrencyRelations() { }
	}
}
