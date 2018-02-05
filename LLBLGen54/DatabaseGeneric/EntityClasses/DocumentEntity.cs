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
	/// <summary>Entity class which represents the entity 'Document'.<br/><br/></summary>
	[Serializable]
	public partial class DocumentEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<ProductDocumentEntity> _productDocuments;
		private EmployeeEntity _employee;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static DocumentEntityStaticMetaData _staticMetaData = new DocumentEntityStaticMetaData();
		private static DocumentRelations _relationsFactory = new DocumentRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name ProductDocuments</summary>
			public static readonly string ProductDocuments = "ProductDocuments";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class DocumentEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public DocumentEntityStaticMetaData()
			{
				SetEntityCoreInfo("DocumentEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.DocumentEntity, typeof(DocumentEntity), typeof(DocumentEntityFactory), false);
				AddNavigatorMetaData<DocumentEntity, EntityCollection<ProductDocumentEntity>>("ProductDocuments", a => a._productDocuments, (a, b) => a._productDocuments = b, a => a.ProductDocuments, () => new DocumentRelations().ProductDocumentEntityUsingDocumentNode, typeof(ProductDocumentEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.ProductDocumentEntity);
				AddNavigatorMetaData<DocumentEntity, EmployeeEntity>("Employee", "Documents", (a, b) => a._employee = b, a => a._employee, (a, b) => a.Employee = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticDocumentRelations.EmployeeEntityUsingOwnerStatic, ()=>new DocumentRelations().EmployeeEntityUsingOwner, null, new int[] { (int)DocumentFieldIndex.Owner }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.EmployeeEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static DocumentEntity()
		{
		}

		/// <summary> CTor</summary>
		public DocumentEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DocumentEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DocumentEntity</param>
		public DocumentEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="documentNode">PK value for Document which data should be fetched into this Document object</param>
		public DocumentEntity(System.String documentNode) : this(documentNode, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="documentNode">PK value for Document which data should be fetched into this Document object</param>
		/// <param name="validator">The custom validator object for this DocumentEntity</param>
		public DocumentEntity(System.String documentNode, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.DocumentNode = documentNode;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DocumentEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Method which will construct a filter (predicate expression) for the unique constraint defined on the fields: Rowguid .</summary>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public IPredicateExpression ConstructFilterForUCRowguid()
		{
			var filter = new PredicateExpression();
			filter.Add(AdventureWorks.Dal.Adapter.v54.HelperClasses.DocumentFields.Rowguid == this.Fields.GetCurrentValue((int)DocumentFieldIndex.Rowguid));
 			return filter;
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductDocument' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductDocuments() { return CreateRelationInfoForNavigator("ProductDocuments"); }

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
		/// <param name="validator">The validator object for this DocumentEntity</param>
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
		public static DocumentRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductDocument' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductDocuments	{ get { return _staticMetaData.GetPrefetchPathElement("ProductDocuments", CommonEntityBase.CreateEntityCollection<ProductDocumentEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee { get { return _staticMetaData.GetPrefetchPathElement("Employee", CommonEntityBase.CreateEntityCollection<EmployeeEntity>()); } }

		/// <summary>The ChangeNumber property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."ChangeNumber".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ChangeNumber
		{
			get { return (System.Int32)GetValue((int)DocumentFieldIndex.ChangeNumber, true); }
			set	{ SetValue((int)DocumentFieldIndex.ChangeNumber, value); }
		}

		/// <summary>The Document property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."Document".<br/>Table field type characteristics (type, precision, scale, length): VarBinary, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] Document
		{
			get { return (System.Byte[])GetValue((int)DocumentFieldIndex.Document, true); }
			set	{ SetValue((int)DocumentFieldIndex.Document, value); }
		}

		/// <summary>The DocumentLevel property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."DocumentLevel".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> DocumentLevel
		{
			get { return (Nullable<System.Int16>)GetValue((int)DocumentFieldIndex.DocumentLevel, false); }
		}

		/// <summary>The DocumentNode property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."DocumentNode".<br/>Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 892.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String DocumentNode
		{
			get { return (System.String)GetValue((int)DocumentFieldIndex.DocumentNode, true); }
			set	{ SetValue((int)DocumentFieldIndex.DocumentNode, value); }
		}

		/// <summary>The DocumentSummary property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."DocumentSummary".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String DocumentSummary
		{
			get { return (System.String)GetValue((int)DocumentFieldIndex.DocumentSummary, true); }
			set	{ SetValue((int)DocumentFieldIndex.DocumentSummary, value); }
		}

		/// <summary>The FileExtension property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."FileExtension".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 8.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FileExtension
		{
			get { return (System.String)GetValue((int)DocumentFieldIndex.FileExtension, true); }
			set	{ SetValue((int)DocumentFieldIndex.FileExtension, value); }
		}

		/// <summary>The FileName property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."FileName".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 400.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FileName
		{
			get { return (System.String)GetValue((int)DocumentFieldIndex.FileName, true); }
			set	{ SetValue((int)DocumentFieldIndex.FileName, value); }
		}

		/// <summary>The FolderFlag property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."FolderFlag".<br/>Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean FolderFlag
		{
			get { return (System.Boolean)GetValue((int)DocumentFieldIndex.FolderFlag, true); }
			set	{ SetValue((int)DocumentFieldIndex.FolderFlag, value); }
		}

		/// <summary>The ModifiedDate property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)DocumentFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)DocumentFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Owner property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."Owner".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 Owner
		{
			get { return (System.Int32)GetValue((int)DocumentFieldIndex.Owner, true); }
			set	{ SetValue((int)DocumentFieldIndex.Owner, value); }
		}

		/// <summary>The Revision property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."Revision".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 5.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Revision
		{
			get { return (System.String)GetValue((int)DocumentFieldIndex.Revision, true); }
			set	{ SetValue((int)DocumentFieldIndex.Revision, value); }
		}

		/// <summary>The Rowguid property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)DocumentFieldIndex.Rowguid, true); }
			set	{ SetValue((int)DocumentFieldIndex.Rowguid, value); }
		}

		/// <summary>The Status property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."Status".<br/>Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte Status
		{
			get { return (System.Byte)GetValue((int)DocumentFieldIndex.Status, true); }
			set	{ SetValue((int)DocumentFieldIndex.Status, value); }
		}

		/// <summary>The Title property of the Entity Document<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Document"."Title".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)DocumentFieldIndex.Title, true); }
			set	{ SetValue((int)DocumentFieldIndex.Title, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductDocumentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductDocumentEntity))]
		public virtual EntityCollection<ProductDocumentEntity> ProductDocuments { get { return GetOrCreateEntityCollection<ProductDocumentEntity, ProductDocumentEntityFactory>("Document", true, false, ref _productDocuments); } }

		/// <summary>Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get	{ return _employee; }
			set { SetSingleRelatedEntityNavigator(value, "Employee"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum DocumentFieldIndex
	{
		///<summary>ChangeNumber. </summary>
		ChangeNumber,
		///<summary>Document. </summary>
		Document,
		///<summary>DocumentLevel. </summary>
		DocumentLevel,
		///<summary>DocumentNode. </summary>
		DocumentNode,
		///<summary>DocumentSummary. </summary>
		DocumentSummary,
		///<summary>FileExtension. </summary>
		FileExtension,
		///<summary>FileName. </summary>
		FileName,
		///<summary>FolderFlag. </summary>
		FolderFlag,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Owner. </summary>
		Owner,
		///<summary>Revision. </summary>
		Revision,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>Status. </summary>
		Status,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Document. </summary>
	public partial class DocumentRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between DocumentEntity and ProductDocumentEntity over the 1:n relation they have, using the relation between the fields: Document.DocumentNode - ProductDocument.DocumentNode</summary>
		public virtual IEntityRelation ProductDocumentEntityUsingDocumentNode
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ProductDocuments", true, new[] { DocumentFields.DocumentNode, ProductDocumentFields.DocumentNode }); }
		}

		/// <summary>Returns a new IEntityRelation object, between DocumentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields: Document.Owner - Employee.EmployeeId</summary>
		public virtual IEntityRelation EmployeeEntityUsingOwner
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Employee", false, new[] { EmployeeFields.EmployeeId, DocumentFields.Owner }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticDocumentRelations
	{
		internal static readonly IEntityRelation ProductDocumentEntityUsingDocumentNodeStatic = new DocumentRelations().ProductDocumentEntityUsingDocumentNode;
		internal static readonly IEntityRelation EmployeeEntityUsingOwnerStatic = new DocumentRelations().EmployeeEntityUsingOwner;

		/// <summary>CTor</summary>
		static StaticDocumentRelations() { }
	}
}
