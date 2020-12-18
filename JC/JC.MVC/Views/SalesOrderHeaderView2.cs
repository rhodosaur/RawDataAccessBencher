using JC.MVC.Database;
using Jerrycurl.Relations;
using System;
using System.Collections.Generic;
using System.Text;

namespace JC.MVC.Views
{
    public class SalesOrderHeaderView2 : SalesOrderHeader
    {
        public IList<SalesOrderDetail> Details { get; set; }
        public One<Customer> Customer { get; set; }
    }
}
