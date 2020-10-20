using JC.MVC.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace JC.MVC.Views
{
    public class SalesOrderHeaderView : SalesOrderHeader
    {
        public IList<SalesOrderDetail> Details { get; set; }
        public Customer Customer { get; set; }
    }
}
