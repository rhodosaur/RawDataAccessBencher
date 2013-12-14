﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace NH.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'BusinessEntity'</summary>
	public partial class BusinessEntity
	{
		#region Class Member Declarations
		private Iesi.Collections.Generic.ISet<BusinessEntityAddress> _businessEntityAddresses;
		private Iesi.Collections.Generic.ISet<BusinessEntityContact> _businessEntityContacts;
		private Person _person;
		private Store _store;
		private Vendor _vendor;
		private System.Int32 _businessEntityId;
		private System.DateTime _modifiedDate;
		private System.Guid _rowguid;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="BusinessEntity"/> class.</summary>
		public BusinessEntity() : base()
		{
			_businessEntityAddresses = new Iesi.Collections.Generic.HashedSet<BusinessEntityAddress>();
			_businessEntityContacts = new Iesi.Collections.Generic.HashedSet<BusinessEntityContact>();
			_businessEntityId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.BusinessEntityId.GetHashCode();
			return toReturn;
		}
	
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		/// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
		/// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			if(obj == null) 
			{
				return false;
			}
			BusinessEntity toCompareWith = obj as BusinessEntity;
			return toCompareWith == null ? false : ((this.BusinessEntityId == toCompareWith.BusinessEntityId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets the BusinessEntityId field. </summary>	
		public virtual System.Int32 BusinessEntityId
		{ 
			get { return _businessEntityId; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'BusinessEntityAddress.BusinessEntity - BusinessEntity.BusinessEntityAddresses (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<BusinessEntityAddress> BusinessEntityAddresses
		{
			get { return _businessEntityAddresses; }
			set { _businessEntityAddresses = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'BusinessEntityContact.BusinessEntity - BusinessEntity.BusinessEntityContacts (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<BusinessEntityContact> BusinessEntityContacts
		{
			get { return _businessEntityContacts; }
			set { _businessEntityContacts = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Person.BusinessEntity - BusinessEntity.Person (1:1)'</summary>
		public virtual Person Person
		{
			get { return _person; }
			set { _person = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Store.BusinessEntity - BusinessEntity.Store (1:1)'</summary>
		public virtual Store Store
		{
			get { return _store; }
			set { _store = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Vendor.BusinessEntity - BusinessEntity.Vendor (1:1)'</summary>
		public virtual Vendor Vendor
		{
			get { return _vendor; }
			set { _vendor = value; }
		}
		
		#endregion
	}
}