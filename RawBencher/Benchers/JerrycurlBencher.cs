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
using Jerrycurl.Mvc;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for Dapper , doing no-change tracking fetch
	/// </summary>
	public class JerrycurlBencher : BencherBase<JC.MVC.Database.SalesOrderHeader, CreditCard>
    {
        private readonly BenchAccessor accessor = new BenchAccessor();

        public JerrycurlBencher()
            : base(e => e.SalesOrderID,
                  l => l.CreditCardID,
                  usesChangeTracking: false,
                  usesCaching: false,
                  supportsEagerLoading: true,
                  supportsAsync: true,
                  supportsInserts: true)
        {

        }

        public override JC.MVC.Database.SalesOrderHeader FetchIndividual(int key) => this.accessor.GetOne<JC.MVC.Database.SalesOrderHeader>(key);
        public override IEnumerable<JC.MVC.Database.SalesOrderHeader> FetchSet() => this.accessor.GetAll<JC.MVC.Database.SalesOrderHeader>();
        public override IEnumerable<JC.MVC.Database.SalesOrderHeader> FetchGraph() => this.accessor.GetGraph();
        public override async Task<IEnumerable<JC.MVC.Database.SalesOrderHeader>> FetchGraphAsync() => (await this.accessor.GetGraphAsync());

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

        public override IEnumerable<CreditCard> CreateSetForInserts(int amountToInsert)
        {
            var toReturn = new CreditCard[amountToInsert];

            for (int i = 0; i < amountToInsert; i++)
            {
                toReturn[i] = new CreditCard()
                {
                    CardNumber = Guid.NewGuid().ToString("N").Substring(0, 24),
                    CardType = "Vista",
                    ExpMonth = 11,
                    ExpYear = 2018,
                    ModifiedDate = DateTime.Now
                };
            }

            return toReturn;
        }

        protected override IEnumerable<CreditCard> FetchInserted(int amountInserted) => this.accessor.GetNewCards();

        protected override void DeleteInserted(IEnumerable<CreditCard> toDelete) => this.accessor.DeleteNewCards();

        public override void InsertSet(IEnumerable<CreditCard> toInsert, int batchSize) => this.accessor.InsertCards(toInsert, batchSize);

        /// <summary>
        /// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
        /// specific version
        /// </summary>
        /// <returns>the framework name.</returns>
        protected override string CreateFrameworkNameImpl()
		{
            return $"Jerrycurl v{BencherUtils.GetVersion(typeof(Accessor))} (v{BencherUtils.GetVersion(typeof(Accessor))}), MVC/Razor SQL";

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
