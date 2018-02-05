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
	/// <summary>Entity class which represents the entity 'ProductModel'.<br/><br/></summary>
	[Serializable]
	public partial class ProductModelEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<ProductEntity> _products;
		private EntityCollection<ProductModelIllustrationEntity> _productModelIllustrations;
		private EntityCollection<ProductModelProductDescriptionCultureEntity> _productModelProductDescriptionCultures;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ProductModelEntityStaticMetaData _staticMetaData = new ProductModelEntityStaticMetaData();
		private static ProductModelRelations _relationsFactory = new ProductModelRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Products</summary>
			public static readonly string Products = "Products";
			/// <summary>Member name ProductModelIllustrations</summary>
			public static readonly string ProductModelIllustrations = "ProductModelIllustrations";
			/// <summary>Member name ProductModelProductDescriptionCultures</summary>
			public static readonly string ProductModelProductDescriptionCultures = "ProductModelProductDescriptionCultures";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ProductModelEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ProductModelEntityStaticMetaData()
			{
				SetEntityCoreInfo("ProductModelEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.ProductModelEntity, typeof(ProductModelEntity), typeof(ProductModelEntityFactory), false);
				AddNavigatorMetaData<ProductModelEntity, EntityCollection<ProductEntity>>("Products", a => a._products, (a, b) => a._products = b, a => a.Products, () => new ProductModelRelations().ProductEntityUsingProductModelId, typeof(ProductEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.ProductEntity);
				AddNavigatorMetaData<ProductModelEntity, EntityCollection<ProductModelIllustrationEntity>>("ProductModelIllustrations", a => a._productModelIllustrations, (a, b) => a._productModelIllustrations = b, a => a.ProductModelIllustrations, () => new ProductModelRelations().ProductModelIllustrationEntityUsingProductModelId, typeof(ProductModelIllustrationEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.ProductModelIllustrationEntity);
				AddNavigatorMetaData<ProductModelEntity, EntityCollection<ProductModelProductDescriptionCultureEntity>>("ProductModelProductDescriptionCultures", a => a._productModelProductDescriptionCultures, (a, b) => a._productModelProductDescriptionCultures = b, a => a.ProductModelProductDescriptionCultures, () => new ProductModelRelations().ProductModelProductDescriptionCultureEntityUsingProductModelId, typeof(ProductModelProductDescriptionCultureEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.ProductModelProductDescriptionCultureEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ProductModelEntity()
		{
		}

		/// <summary> CTor</summary>
		public ProductModelEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductModelEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductModelEntity</param>
		public ProductModelEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="productModelId">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		public ProductModelEntity(System.Int32 productModelId) : this(productModelId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="productModelId">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="validator">The custom validator object for this ProductModelEntity</param>
		public ProductModelEntity(System.Int32 productModelId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.ProductModelId = productModelId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductModelEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProducts() { return CreateRelationInfoForNavigator("Products"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductModelIllustration' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModelIllustrations() { return CreateRelationInfoForNavigator("ProductModelIllustrations"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductModelProductDescriptionCulture' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModelProductDescriptionCultures() { return CreateRelationInfoForNavigator("ProductModelProductDescriptionCultures"); }
		
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
		/// <param name="validator">The validator object for this ProductModelEntity</param>
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
		public static ProductModelRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProducts	{ get { return _staticMetaData.GetPrefetchPathElement("Products", CommonEntityBase.CreateEntityCollection<ProductEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModelIllustration' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModelIllustrations	{ get { return _staticMetaData.GetPrefetchPathElement("ProductModelIllustrations", CommonEntityBase.CreateEntityCollection<ProductModelIllustrationEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModelProductDescriptionCulture' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModelProductDescriptionCultures	{ get { return _staticMetaData.GetPrefetchPathElement("ProductModelProductDescriptionCultures", CommonEntityBase.CreateEntityCollection<ProductModelProductDescriptionCultureEntity>()); } }

		/// <summary>The CatalogDescription property of the Entity ProductModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."CatalogDescription".<br/>Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CatalogDescription
		{
			get { return (System.String)GetValue((int)ProductModelFieldIndex.CatalogDescription, true); }
			set	{ SetValue((int)ProductModelFieldIndex.CatalogDescription, value); }
		}

		/// <summary>The Instructions property of the Entity ProductModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."Instructions".<br/>Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Instructions
		{
			get { return (System.String)GetValue((int)ProductModelFieldIndex.Instructions, true); }
			set	{ SetValue((int)ProductModelFieldIndex.Instructions, value); }
		}

		/// <summary>The ModifiedDate property of the Entity ProductModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductModelFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductModelFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity ProductModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ProductModelFieldIndex.Name, true); }
			set	{ SetValue((int)ProductModelFieldIndex.Name, value); }
		}

		/// <summary>The ProductModelId property of the Entity ProductModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."ProductModelID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductModelId
		{
			get { return (System.Int32)GetValue((int)ProductModelFieldIndex.ProductModelId, true); }
			set	{ SetValue((int)ProductModelFieldIndex.ProductModelId, value); }		}

		/// <summary>The Rowguid property of the Entity ProductModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductModelFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductModelFieldIndex.Rowguid, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection<ProductEntity> Products { get { return GetOrCreateEntityCollection<ProductEntity, ProductEntityFactory>("ProductModel", true, false, ref _products); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductModelIllustrationEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductModelIllustrationEntity))]
		public virtual EntityCollection<ProductModelIllustrationEntity> ProductModelIllustrations { get { return GetOrCreateEntityCollection<ProductModelIllustrationEntity, ProductModelIllustrationEntityFactory>("ProductModel", true, false, ref _productModelIllustrations); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductModelProductDescriptionCultureEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductModelProductDescriptionCultureEntity))]
		public virtual EntityCollection<ProductModelProductDescriptionCultureEntity> ProductModelProductDescriptionCultures { get { return GetOrCreateEntityCollection<ProductModelProductDescriptionCultureEntity, ProductModelProductDescriptionCultureEntityFactory>("ProductModel", true, false, ref _productModelProductDescriptionCultures); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum ProductModelFieldIndex
	{
		///<summary>CatalogDescription. </summary>
		CatalogDescription,
		///<summary>Instructions. </summary>
		Instructions,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ProductModelId. </summary>
		ProductModelId,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ProductModel. </summary>
	public partial class ProductModelRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between ProductModelEntity and ProductEntity over the 1:n relation they have, using the relation between the fields: ProductModel.ProductModelId - Product.ProductModelId</summary>
		public virtual IEntityRelation ProductEntityUsingProductModelId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Products", true, new[] { ProductModelFields.ProductModelId, ProductFields.ProductModelId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProductModelEntity and ProductModelIllustrationEntity over the 1:n relation they have, using the relation between the fields: ProductModel.ProductModelId - ProductModelIllustration.ProductModelId</summary>
		public virtual IEntityRelation ProductModelIllustrationEntityUsingProductModelId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ProductModelIllustrations", true, new[] { ProductModelFields.ProductModelId, ProductModelIllustrationFields.ProductModelId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProductModelEntity and ProductModelProductDescriptionCultureEntity over the 1:n relation they have, using the relation between the fields: ProductModel.ProductModelId - ProductModelProductDescriptionCulture.ProductModelId</summary>
		public virtual IEntityRelation ProductModelProductDescriptionCultureEntityUsingProductModelId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ProductModelProductDescriptionCultures", true, new[] { ProductModelFields.ProductModelId, ProductModelProductDescriptionCultureFields.ProductModelId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProductModelRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductModelIdStatic = new ProductModelRelations().ProductEntityUsingProductModelId;
		internal static readonly IEntityRelation ProductModelIllustrationEntityUsingProductModelIdStatic = new ProductModelRelations().ProductModelIllustrationEntityUsingProductModelId;
		internal static readonly IEntityRelation ProductModelProductDescriptionCultureEntityUsingProductModelIdStatic = new ProductModelRelations().ProductModelProductDescriptionCultureEntityUsingProductModelId;

		/// <summary>CTor</summary>
		static StaticProductModelRelations() { }
	}
}
