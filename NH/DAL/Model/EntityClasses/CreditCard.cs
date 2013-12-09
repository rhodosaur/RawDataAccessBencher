﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace NH.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'CreditCard'</summary>
	public partial class CreditCard
	{
		#region Class Member Declarations
		private Iesi.Collections.Generic.ISet<ContactCreditCard> _contactCreditCards;
		private Iesi.Collections.Generic.ISet<SalesOrderHeader> _salesOrderHeaders;
		private System.String _cardNumber;
		private System.String _cardType;
		private System.Int32 _creditCardId;
		private System.Byte _expMonth;
		private System.Int16 _expYear;
		private System.DateTime _modifiedDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="CreditCard"/> class.</summary>
		public CreditCard() : base()
		{
			_contactCreditCards = new Iesi.Collections.Generic.HashedSet<ContactCreditCard>();
			_salesOrderHeaders = new Iesi.Collections.Generic.HashedSet<SalesOrderHeader>();
			_creditCardId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.CreditCardId.GetHashCode();
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
			CreditCard toCompareWith = obj as CreditCard;
			return toCompareWith == null ? false : ((this.CreditCardId == toCompareWith.CreditCardId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the CardNumber field. </summary>	
		public virtual System.String CardNumber
		{ 
			get { return _cardNumber; }
			set { _cardNumber = value; }
		}

		/// <summary>Gets or sets the CardType field. </summary>	
		public virtual System.String CardType
		{ 
			get { return _cardType; }
			set { _cardType = value; }
		}

		/// <summary>Gets the CreditCardId field. </summary>	
		public virtual System.Int32 CreditCardId
		{ 
			get { return _creditCardId; }
		}

		/// <summary>Gets or sets the ExpMonth field. </summary>	
		public virtual System.Byte ExpMonth
		{ 
			get { return _expMonth; }
			set { _expMonth = value; }
		}

		/// <summary>Gets or sets the ExpYear field. </summary>	
		public virtual System.Int16 ExpYear
		{ 
			get { return _expYear; }
			set { _expYear = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'ContactCreditCard.CreditCard - CreditCard.ContactCreditCards (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<ContactCreditCard> ContactCreditCards
		{
			get { return _contactCreditCards; }
			set { _contactCreditCards = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.CreditCard - CreditCard.SalesOrderHeaders (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return _salesOrderHeaders; }
			set { _salesOrderHeaders = value; }
		}
		
		#endregion
	}
}