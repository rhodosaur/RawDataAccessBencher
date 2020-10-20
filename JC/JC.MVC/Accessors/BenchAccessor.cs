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
        public IList<T> GetAll<T>() => this.Query<T>();
        public T GetOne<T>(int key) => this.One<T>(key);
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