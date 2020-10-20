using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using JC.MVC.Accessors;
using JC.MVC.Database;
using JC.MVC.Views;
using Jerrycurl.Data.Metadata;
using Jerrycurl.Data.Queries;
using Jerrycurl.Data.Sessions;
using Jerrycurl.Mvc;
using Jerrycurl.Relations;
using Jerrycurl.Relations.Metadata;

namespace RawBencher.Benchers
{
	public class JerrycurlDataBencher : BencherBase<JC.MVC.Database.SalesOrderHeader, CreditCard>
    {
        private QueryOptions options = new QueryOptions()
        {
            ConnectionFactory = () => new SqlConnection("data source=.;initial catalog=AdventureWorks;integrated security=SSPI;persist security info=False;packet size=4096"),
            Schemas = new SchemaStore(new DotNotation())
            {
                new RelationMetadataBuilder(),
                new BindingMetadataBuilder(),
                new ReferenceMetadataBuilder(),
            }
        };
        private QueryHandler queries;

        public JerrycurlDataBencher()
            : base(e => e.SalesOrderID,
                  l => l.CreditCardID,
                  usesChangeTracking: false,
                  usesCaching: false,
                  supportsEagerLoading: true,
                  supportsAsync: true,
                  supportsInserts: false)
        {
            this.queries = new QueryHandler(this.options);
        }

        public override JC.MVC.Database.SalesOrderHeader FetchIndividual(int key)
        {
            ISchema schema = this.options.Schemas.GetSchema(typeof(int));
            IField param = new Relation(key, schema, "");

            QueryData query = new QueryData()
            {
                QueryText = "SELECT [SalesOrderID] AS [Item.SalesOrderID],[RevisionNumber] AS [Item.RevisionNumber],[OrderDate] AS [Item.OrderDate],[DueDate] AS [Item.DueDate],[ShipDate] AS [Item.ShipDate],[Status] AS [Item.Status],[OnlineOrderFlag] AS [Item.OnlineOrderFlag],[SalesOrderNumber] AS [Item.SalesOrderNumber],[PurchaseOrderNumber] AS [Item.PurchaseOrderNumber],[AccountNumber] AS [Item.AccountNumber],[CustomerID] AS [Item.CustomerID],[SalesPersonID] AS [Item.SalesPersonID],[TerritoryID] AS [Item.TerritoryID],[BillToAddressID] AS [Item.BillToAddressID],[ShipToAddressID] AS [Item.ShipToAddressID],[ShipMethodID] AS [Item.ShipMethodID],[CreditCardID] AS [Item.CreditCardID],[CreditCardApprovalCode] AS [Item.CreditCardApprovalCode],[CurrencyRateID] AS [Item.CurrencyRateID],[SubTotal] AS [Item.SubTotal],[TaxAmt] AS [Item.TaxAmt],[Freight] AS [Item.Freight],[TotalDue] AS [Item.TotalDue],[Comment] AS [Item.Comment],[rowguid] AS [Item.rowguid],[ModifiedDate] AS [Item.ModifiedDate] FROM [Sales].[SalesOrderHeader] WHERE [SalesOrderID] = @P0",
                Parameters = new IParameter[] { new Parameter("P0", param) },
            };

            return this.queries.List<JC.MVC.Database.SalesOrderHeader>(query).SingleOrDefault();
        }
        public override IEnumerable<JC.MVC.Database.SalesOrderHeader> FetchSet()
        {
            QueryData query = new QueryData()
            {
                QueryText = "SELECT [SalesOrderID] AS [Item.SalesOrderID],[RevisionNumber] AS [Item.RevisionNumber],[OrderDate] AS [Item.OrderDate],[DueDate] AS [Item.DueDate],[ShipDate] AS [Item.ShipDate],[Status] AS [Item.Status],[OnlineOrderFlag] AS [Item.OnlineOrderFlag],[SalesOrderNumber] AS [Item.SalesOrderNumber],[PurchaseOrderNumber] AS [Item.PurchaseOrderNumber],[AccountNumber] AS [Item.AccountNumber],[CustomerID] AS [Item.CustomerID],[SalesPersonID] AS [Item.SalesPersonID],[TerritoryID] AS [Item.TerritoryID],[BillToAddressID] AS [Item.BillToAddressID],[ShipToAddressID] AS [Item.ShipToAddressID],[ShipMethodID] AS [Item.ShipMethodID],[CreditCardID] AS [Item.CreditCardID],[CreditCardApprovalCode] AS [Item.CreditCardApprovalCode],[CurrencyRateID] AS [Item.CurrencyRateID],[SubTotal] AS [Item.SubTotal],[TaxAmt] AS [Item.TaxAmt],[Freight] AS [Item.Freight],[TotalDue] AS [Item.TotalDue],[Comment] AS [Item.Comment],[rowguid] AS [Item.rowguid],[ModifiedDate] AS [Item.ModifiedDate] FROM [Sales].[SalesOrderHeader]",
            };

            return this.queries.List<JC.MVC.Database.SalesOrderHeader>(query);
        }

        public override IEnumerable<JC.MVC.Database.SalesOrderHeader> FetchGraph()
        {
            QueryData query = new QueryData()
            {
                QueryText = @"

SELECT
    T0.""SalesOrderID"" AS ""Item.SalesOrderID"",
T0.""RevisionNumber"" AS ""Item.RevisionNumber"",
T0.""OrderDate"" AS ""Item.OrderDate"",
T0.""DueDate"" AS ""Item.DueDate"",
T0.""ShipDate"" AS ""Item.ShipDate"",
T0.""Status"" AS ""Item.Status"",
T0.""OnlineOrderFlag"" AS ""Item.OnlineOrderFlag"",
T0.""SalesOrderNumber"" AS ""Item.SalesOrderNumber"",
T0.""PurchaseOrderNumber"" AS ""Item.PurchaseOrderNumber"",
T0.""AccountNumber"" AS ""Item.AccountNumber"",
T0.""CustomerID"" AS ""Item.CustomerID"",
T0.""SalesPersonID"" AS ""Item.SalesPersonID"",
T0.""TerritoryID"" AS ""Item.TerritoryID"",
T0.""BillToAddressID"" AS ""Item.BillToAddressID"",
T0.""ShipToAddressID"" AS ""Item.ShipToAddressID"",
T0.""ShipMethodID"" AS ""Item.ShipMethodID"",
T0.""CreditCardID"" AS ""Item.CreditCardID"",
T0.""CreditCardApprovalCode"" AS ""Item.CreditCardApprovalCode"",
T0.""CurrencyRateID"" AS ""Item.CurrencyRateID"",
T0.""SubTotal"" AS ""Item.SubTotal"",
T0.""TaxAmt"" AS ""Item.TaxAmt"",
T0.""Freight"" AS ""Item.Freight"",
T0.""TotalDue"" AS ""Item.TotalDue"",
T0.""Comment"" AS ""Item.Comment"",
T0.""rowguid"" AS ""Item.rowguid"",
T0.""ModifiedDate"" AS ""Item.ModifiedDate"",
    T1.""CustomerID"" AS ""Item.Customer.CustomerID"",
T1.""PersonID"" AS ""Item.Customer.PersonID"",
T1.""StoreID"" AS ""Item.Customer.StoreID"",
T1.""TerritoryID"" AS ""Item.Customer.TerritoryID"",
T1.""AccountNumber"" AS ""Item.Customer.AccountNumber"",
T1.""rowguid"" AS ""Item.Customer.rowguid"",
T1.""ModifiedDate"" AS ""Item.Customer.ModifiedDate""
FROM
    ""Sales"".""SalesOrderHeader"" T0
INNER JOIN
    ""Sales"".""Customer"" T1 ON T1.""CustomerID"" = T0.""CustomerID""
WHERE
    T0.""SalesOrderID"" > 50000 AND T0.""SalesOrderID"" <= 51000

SELECT
    T2.""SalesOrderID"" AS ""Item.Details.Item.SalesOrderID"",
T2.""SalesOrderDetailID"" AS ""Item.Details.Item.SalesOrderDetailID"",
T2.""CarrierTrackingNumber"" AS ""Item.Details.Item.CarrierTrackingNumber"",
T2.""OrderQty"" AS ""Item.Details.Item.OrderQty"",
T2.""ProductID"" AS ""Item.Details.Item.ProductID"",
T2.""SpecialOfferID"" AS ""Item.Details.Item.SpecialOfferID"",
T2.""UnitPrice"" AS ""Item.Details.Item.UnitPrice"",
T2.""UnitPriceDiscount"" AS ""Item.Details.Item.UnitPriceDiscount"",
T2.""LineTotal"" AS ""Item.Details.Item.LineTotal"",
T2.""rowguid"" AS ""Item.Details.Item.rowguid"",
T2.""ModifiedDate"" AS ""Item.Details.Item.ModifiedDate""
FROM
    ""Sales"".""SalesOrderDetail"" T2
INNER JOIN
    ""Sales"".""SalesOrderHeader"" T0 ON T0.""SalesOrderID"" = T2.""SalesOrderID""
WHERE
    T2.""SalesOrderID"" > 50000 AND T2.""SalesOrderID"" <= 51000"
            };

            return this.queries.List<SalesOrderHeaderView>(query);
        }
        public override async Task<IEnumerable<JC.MVC.Database.SalesOrderHeader>> FetchGraphAsync()
        {
            QueryData query = new QueryData()
            {
                QueryText = @"

SELECT
    T0.""SalesOrderID"" AS ""Item.SalesOrderID"",
T0.""RevisionNumber"" AS ""Item.RevisionNumber"",
T0.""OrderDate"" AS ""Item.OrderDate"",
T0.""DueDate"" AS ""Item.DueDate"",
T0.""ShipDate"" AS ""Item.ShipDate"",
T0.""Status"" AS ""Item.Status"",
T0.""OnlineOrderFlag"" AS ""Item.OnlineOrderFlag"",
T0.""SalesOrderNumber"" AS ""Item.SalesOrderNumber"",
T0.""PurchaseOrderNumber"" AS ""Item.PurchaseOrderNumber"",
T0.""AccountNumber"" AS ""Item.AccountNumber"",
T0.""CustomerID"" AS ""Item.CustomerID"",
T0.""SalesPersonID"" AS ""Item.SalesPersonID"",
T0.""TerritoryID"" AS ""Item.TerritoryID"",
T0.""BillToAddressID"" AS ""Item.BillToAddressID"",
T0.""ShipToAddressID"" AS ""Item.ShipToAddressID"",
T0.""ShipMethodID"" AS ""Item.ShipMethodID"",
T0.""CreditCardID"" AS ""Item.CreditCardID"",
T0.""CreditCardApprovalCode"" AS ""Item.CreditCardApprovalCode"",
T0.""CurrencyRateID"" AS ""Item.CurrencyRateID"",
T0.""SubTotal"" AS ""Item.SubTotal"",
T0.""TaxAmt"" AS ""Item.TaxAmt"",
T0.""Freight"" AS ""Item.Freight"",
T0.""TotalDue"" AS ""Item.TotalDue"",
T0.""Comment"" AS ""Item.Comment"",
T0.""rowguid"" AS ""Item.rowguid"",
T0.""ModifiedDate"" AS ""Item.ModifiedDate"",
    T1.""CustomerID"" AS ""Item.Customer.CustomerID"",
T1.""PersonID"" AS ""Item.Customer.PersonID"",
T1.""StoreID"" AS ""Item.Customer.StoreID"",
T1.""TerritoryID"" AS ""Item.Customer.TerritoryID"",
T1.""AccountNumber"" AS ""Item.Customer.AccountNumber"",
T1.""rowguid"" AS ""Item.Customer.rowguid"",
T1.""ModifiedDate"" AS ""Item.Customer.ModifiedDate""
FROM
    ""Sales"".""SalesOrderHeader"" T0
INNER JOIN
    ""Sales"".""Customer"" T1 ON T1.""CustomerID"" = T0.""CustomerID""
WHERE
    T0.""SalesOrderID"" > 50000 AND T0.""SalesOrderID"" <= 51000

SELECT
    T2.""SalesOrderID"" AS ""Item.Details.Item.SalesOrderID"",
T2.""SalesOrderDetailID"" AS ""Item.Details.Item.SalesOrderDetailID"",
T2.""CarrierTrackingNumber"" AS ""Item.Details.Item.CarrierTrackingNumber"",
T2.""OrderQty"" AS ""Item.Details.Item.OrderQty"",
T2.""ProductID"" AS ""Item.Details.Item.ProductID"",
T2.""SpecialOfferID"" AS ""Item.Details.Item.SpecialOfferID"",
T2.""UnitPrice"" AS ""Item.Details.Item.UnitPrice"",
T2.""UnitPriceDiscount"" AS ""Item.Details.Item.UnitPriceDiscount"",
T2.""LineTotal"" AS ""Item.Details.Item.LineTotal"",
T2.""rowguid"" AS ""Item.Details.Item.rowguid"",
T2.""ModifiedDate"" AS ""Item.Details.Item.ModifiedDate""
FROM
    ""Sales"".""SalesOrderDetail"" T2
INNER JOIN
    ""Sales"".""SalesOrderHeader"" T0 ON T0.""SalesOrderID"" = T2.""SalesOrderID""
WHERE
    T2.""SalesOrderID"" > 50000 AND T2.""SalesOrderID"" <= 51000"
            };

            return await this.queries.ListAsync<SalesOrderHeaderView>(query);
        }

        public override void VerifyGraphElementChildren(JC.MVC.Database.SalesOrderHeader parent, BenchResult resultContainer)
        {
            SalesOrderHeaderView view = parent as SalesOrderHeaderView;

            if (view == null)
                return;

            int amount = 0;
            foreach (var sod in view.Details)
            {
                if (sod.SalesOrderID > 0)
                {
                    amount++;
                }
                else
                {
                    return;
                }
            }

            resultContainer.IncNumberOfRowsForType(typeof(SalesOrderDetail), amount);

            if ((view.Customer == null) || (view.Customer.CustomerID <= 0))
            {
                return;
            }

            resultContainer.IncNumberOfRowsForType(typeof(Customer), 1);
        }
        /// <summary>
        /// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
        /// specific version
        /// </summary>
        /// <returns>the framework name.</returns>
        protected override string CreateFrameworkNameImpl()
		{
            return $"Jerrycurl v{BencherUtils.GetVersion(typeof(Accessor))} (v{BencherUtils.GetInformalVersion(typeof(Accessor))}), Raw SQL";
        }


		#region Properties
		/// <summary>
		/// Gets or sets the connection string to use
		/// </summary>
		public string ConnectionStringToUse { get; set; }
		/// <summary>
		/// Gets or sets the command text.
		/// </summary>
		public string CommandText { get; set; }
		#endregion
	}
}
