﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.5.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ContactCreditCard'.</summary>
	public partial class ContactCreditCard : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="ContactCreditCard"/> class.</summary>
		public ContactCreditCard() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the ContactId field. </summary>
		public System.Int32 ContactId { get; set;}
		/// <summary>Gets or sets the CreditCardId field. </summary>
		public System.Int32 CreditCardId { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ContactCreditCard.CreditCard - CreditCard.ContactCreditCards (m:1)'</summary>
		public virtual CreditCard CreditCard { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ContactCreditCard.Person - Person.Person.ContactCreditCards (m:1)'</summary>
		public virtual Person Person { get; set;}
	}
}