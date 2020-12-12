using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JC.MVC.Database;
using JC.MVC.Views;
using Jerrycurl.Mvc;

namespace JC.MVC.Accessors
{
    public class BenchAccessor : Accessor
    {
        public IList<SalesOrderHeader> GetAllSql() => this.Query<SalesOrderHeader>();
        public SalesOrderHeader GetOneSql(int key) => this.One<SalesOrderHeader>(key);

        public IList<SalesOrderHeader> GetAll() => this.Query<SalesOrderHeader>();
        public SalesOrderHeader GetOne(int key) => this.One<SalesOrderHeader>(key);
        public IList<SalesOrderHeaderView> GetGraph() => this.Query<SalesOrderHeaderView>();
        public Task<IList<SalesOrderHeaderView>> GetGraphAsync() => this.QueryAsync<SalesOrderHeaderView>();

        public void InsertCards(IEnumerable<CreditCard> newCards, int batchSize)
        {
            this.Execute(newCards, configure: o =>
            {
                o.MaxParameters = batchSize * 5; // 5 input params for CreditCard (excl. identity)
                o.UseTransaction();
            });
        }

        public IList<CreditCard> GetNewCards() => this.Query<CreditCard>();
        public void DeleteNewCards() => this.Execute();
    }
}