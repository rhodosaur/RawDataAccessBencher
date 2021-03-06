﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace EF6.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ShipMethod'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class ShipMethod : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="ShipMethod"/> class.</summary>
		public ShipMethod() : base()
		{
			this.PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
			this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		[DataMember]
		public System.String Name { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		[DataMember]
		public System.Guid Rowguid { get; set;}
		/// <summary>Gets or sets the ShipBase field. </summary>
		[DataMember]
		public System.Decimal ShipBase { get; set;}
		/// <summary>Gets or sets the ShipMethodId field. </summary>
		[DataMember]
		public System.Int32 ShipMethodId { get; set;}
		/// <summary>Gets or sets the ShipRate field. </summary>
		[DataMember]
		public System.Decimal ShipRate { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderHeader.ShipMethod - ShipMethod.PurchaseOrderHeaders (m:1)'</summary>
		[DataMember]
		public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.ShipMethod - ShipMethod.SalesOrderHeaders (m:1)'</summary>
		[DataMember]
		public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set;}
		#endregion
	}
}
