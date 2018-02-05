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
	/// <summary>Entity class which represents the entity 'ProductDocument'.<br/><br/></summary>
	[Serializable]
	public partial class ProductDocumentEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private DocumentEntity _document;
		private ProductEntity _product;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ProductDocumentEntityStaticMetaData _staticMetaData = new ProductDocumentEntityStaticMetaData();
		private static ProductDocumentRelations _relationsFactory = new ProductDocumentRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Document</summary>
			public static readonly string Document = "Document";
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ProductDocumentEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ProductDocumentEntityStaticMetaData()
			{
				SetEntityCoreInfo("ProductDocumentEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.ProductDocumentEntity, typeof(ProductDocumentEntity), typeof(ProductDocumentEntityFactory), false);
				AddNavigatorMetaData<ProductDocumentEntity, DocumentEntity>("Document", "ProductDocuments", (a, b) => a._document = b, a => a._document, (a, b) => a.Document = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticProductDocumentRelations.DocumentEntityUsingDocumentNodeStatic, ()=>new ProductDocumentRelations().DocumentEntityUsingDocumentNode, null, new int[] { (int)ProductDocumentFieldIndex.DocumentNode }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.DocumentEntity);
				AddNavigatorMetaData<ProductDocumentEntity, ProductEntity>("Product", "ProductDocuments", (a, b) => a._product = b, a => a._product, (a, b) => a.Product = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticProductDocumentRelations.ProductEntityUsingProductIdStatic, ()=>new ProductDocumentRelations().ProductEntityUsingProductId, null, new int[] { (int)ProductDocumentFieldIndex.ProductId }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.ProductEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ProductDocumentEntity()
		{
		}

		/// <summary> CTor</summary>
		public ProductDocumentEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductDocumentEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductDocumentEntity</param>
		public ProductDocumentEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="documentNode">PK value for ProductDocument which data should be fetched into this ProductDocument object</param>
		/// <param name="productId">PK value for ProductDocument which data should be fetched into this ProductDocument object</param>
		public ProductDocumentEntity(System.String documentNode, System.Int32 productId) : this(documentNode, productId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="documentNode">PK value for ProductDocument which data should be fetched into this ProductDocument object</param>
		/// <param name="productId">PK value for ProductDocument which data should be fetched into this ProductDocument object</param>
		/// <param name="validator">The custom validator object for this ProductDocumentEntity</param>
		public ProductDocumentEntity(System.String documentNode, System.Int32 productId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.DocumentNode = documentNode;
			this.ProductId = productId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductDocumentEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Document' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDocument() { return CreateRelationInfoForNavigator("Document"); }

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
		/// <param name="validator">The validator object for this ProductDocumentEntity</param>
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
		public static ProductDocumentRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Document' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDocument { get { return _staticMetaData.GetPrefetchPathElement("Document", CommonEntityBase.CreateEntityCollection<DocumentEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProduct { get { return _staticMetaData.GetPrefetchPathElement("Product", CommonEntityBase.CreateEntityCollection<ProductEntity>()); } }

		/// <summary>The DocumentNode property of the Entity ProductDocument<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductDocument"."DocumentNode".<br/>Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 892.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String DocumentNode
		{
			get { return (System.String)GetValue((int)ProductDocumentFieldIndex.DocumentNode, true); }
			set	{ SetValue((int)ProductDocumentFieldIndex.DocumentNode, value); }
		}

		/// <summary>The ModifiedDate property of the Entity ProductDocument<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductDocument"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductDocumentFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductDocumentFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The ProductId property of the Entity ProductDocument<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductDocument"."ProductID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)ProductDocumentFieldIndex.ProductId, true); }
			set	{ SetValue((int)ProductDocumentFieldIndex.ProductId, value); }
		}

		/// <summary>Gets / sets related entity of type 'DocumentEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual DocumentEntity Document
		{
			get	{ return _document; }
			set { SetSingleRelatedEntityNavigator(value, "Document"); }
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
	public enum ProductDocumentFieldIndex
	{
		///<summary>DocumentNode. </summary>
		DocumentNode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ProductDocument. </summary>
	public partial class ProductDocumentRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between ProductDocumentEntity and DocumentEntity over the m:1 relation they have, using the relation between the fields: ProductDocument.DocumentNode - Document.DocumentNode</summary>
		public virtual IEntityRelation DocumentEntityUsingDocumentNode
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Document", false, new[] { DocumentFields.DocumentNode, ProductDocumentFields.DocumentNode }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProductDocumentEntity and ProductEntity over the m:1 relation they have, using the relation between the fields: ProductDocument.ProductId - Product.ProductId</summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Product", false, new[] { ProductFields.ProductId, ProductDocumentFields.ProductId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProductDocumentRelations
	{
		internal static readonly IEntityRelation DocumentEntityUsingDocumentNodeStatic = new ProductDocumentRelations().DocumentEntityUsingDocumentNode;
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new ProductDocumentRelations().ProductEntityUsingProductId;

		/// <summary>CTor</summary>
		static StaticProductDocumentRelations() { }
	}
}
