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
	/// <summary>Entity class which represents the entity 'ProductInventory'.<br/><br/></summary>
	[Serializable]
	public partial class ProductInventoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private LocationEntity _location;
		private ProductEntity _product;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ProductInventoryEntityStaticMetaData _staticMetaData = new ProductInventoryEntityStaticMetaData();
		private static ProductInventoryRelations _relationsFactory = new ProductInventoryRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Location</summary>
			public static readonly string Location = "Location";
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ProductInventoryEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ProductInventoryEntityStaticMetaData()
			{
				SetEntityCoreInfo("ProductInventoryEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.ProductInventoryEntity, typeof(ProductInventoryEntity), typeof(ProductInventoryEntityFactory), false);
				AddNavigatorMetaData<ProductInventoryEntity, LocationEntity>("Location", "ProductInventories", (a, b) => a._location = b, a => a._location, (a, b) => a.Location = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticProductInventoryRelations.LocationEntityUsingLocationIdStatic, ()=>new ProductInventoryRelations().LocationEntityUsingLocationId, null, new int[] { (int)ProductInventoryFieldIndex.LocationId }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.LocationEntity);
				AddNavigatorMetaData<ProductInventoryEntity, ProductEntity>("Product", "ProductInventories", (a, b) => a._product = b, a => a._product, (a, b) => a.Product = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticProductInventoryRelations.ProductEntityUsingProductIdStatic, ()=>new ProductInventoryRelations().ProductEntityUsingProductId, null, new int[] { (int)ProductInventoryFieldIndex.ProductId }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.ProductEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ProductInventoryEntity()
		{
		}

		/// <summary> CTor</summary>
		public ProductInventoryEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductInventoryEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductInventoryEntity</param>
		public ProductInventoryEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="locationId">PK value for ProductInventory which data should be fetched into this ProductInventory object</param>
		/// <param name="productId">PK value for ProductInventory which data should be fetched into this ProductInventory object</param>
		public ProductInventoryEntity(System.Int16 locationId, System.Int32 productId) : this(locationId, productId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="locationId">PK value for ProductInventory which data should be fetched into this ProductInventory object</param>
		/// <param name="productId">PK value for ProductInventory which data should be fetched into this ProductInventory object</param>
		/// <param name="validator">The custom validator object for this ProductInventoryEntity</param>
		public ProductInventoryEntity(System.Int16 locationId, System.Int32 productId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.LocationId = locationId;
			this.ProductId = productId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductInventoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Location' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoLocation() { return CreateRelationInfoForNavigator("Location"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProduct() { return CreateRelationInfoForNavigator("Product"); }
		
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
		/// <param name="validator">The validator object for this ProductInventoryEntity</param>
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
		public static ProductInventoryRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Location' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathLocation { get { return _staticMetaData.GetPrefetchPathElement("Location", CommonEntityBase.CreateEntityCollection<LocationEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProduct { get { return _staticMetaData.GetPrefetchPathElement("Product", CommonEntityBase.CreateEntityCollection<ProductEntity>()); } }

		/// <summary>The Bin property of the Entity ProductInventory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductInventory"."Bin".<br/>Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte Bin
		{
			get { return (System.Byte)GetValue((int)ProductInventoryFieldIndex.Bin, true); }
			set	{ SetValue((int)ProductInventoryFieldIndex.Bin, value); }
		}

		/// <summary>The LocationId property of the Entity ProductInventory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductInventory"."LocationID".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int16 LocationId
		{
			get { return (System.Int16)GetValue((int)ProductInventoryFieldIndex.LocationId, true); }
			set	{ SetValue((int)ProductInventoryFieldIndex.LocationId, value); }
		}

		/// <summary>The ModifiedDate property of the Entity ProductInventory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductInventory"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductInventoryFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductInventoryFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The ProductId property of the Entity ProductInventory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductInventory"."ProductID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)ProductInventoryFieldIndex.ProductId, true); }
			set	{ SetValue((int)ProductInventoryFieldIndex.ProductId, value); }
		}

		/// <summary>The Quantity property of the Entity ProductInventory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductInventory"."Quantity".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 Quantity
		{
			get { return (System.Int16)GetValue((int)ProductInventoryFieldIndex.Quantity, true); }
			set	{ SetValue((int)ProductInventoryFieldIndex.Quantity, value); }
		}

		/// <summary>The Rowguid property of the Entity ProductInventory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductInventory"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductInventoryFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductInventoryFieldIndex.Rowguid, value); }
		}

		/// <summary>The Shelf property of the Entity ProductInventory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductInventory"."Shelf".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Shelf
		{
			get { return (System.String)GetValue((int)ProductInventoryFieldIndex.Shelf, true); }
			set	{ SetValue((int)ProductInventoryFieldIndex.Shelf, value); }
		}

		/// <summary>Gets / sets related entity of type 'LocationEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual LocationEntity Location
		{
			get	{ return _location; }
			set { SetSingleRelatedEntityNavigator(value, "Location"); }
		}

		/// <summary>Gets / sets related entity of type 'ProductEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get	{ return _product; }
			set { SetSingleRelatedEntityNavigator(value, "Product"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum ProductInventoryFieldIndex
	{
		///<summary>Bin. </summary>
		Bin,
		///<summary>LocationId. </summary>
		LocationId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>Shelf. </summary>
		Shelf,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ProductInventory. </summary>
	public partial class ProductInventoryRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between ProductInventoryEntity and LocationEntity over the m:1 relation they have, using the relation between the fields: ProductInventory.LocationId - Location.LocationId</summary>
		public virtual IEntityRelation LocationEntityUsingLocationId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Location", false, new[] { LocationFields.LocationId, ProductInventoryFields.LocationId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProductInventoryEntity and ProductEntity over the m:1 relation they have, using the relation between the fields: ProductInventory.ProductId - Product.ProductId</summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Product", false, new[] { ProductFields.ProductId, ProductInventoryFields.ProductId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProductInventoryRelations
	{
		internal static readonly IEntityRelation LocationEntityUsingLocationIdStatic = new ProductInventoryRelations().LocationEntityUsingLocationId;
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new ProductInventoryRelations().ProductEntityUsingProductId;

		/// <summary>CTor</summary>
		static StaticProductInventoryRelations() { }
	}
}
