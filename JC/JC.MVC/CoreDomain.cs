using System;
using System.Data;
using Jerrycurl.Data.Filters;
using Jerrycurl.Mvc;

namespace JC.MVC
{
    public class CoreDomain : IDomain
    {
        public void Configure(DomainOptions options)
        {
            options.UseSqlServer("data source=.;initial catalog=AdventureWorks;integrated security=SSPI;persist security info=False;packet size=4096");
        }
    }
}