using System.Collections.Generic;

namespace Northwind.Application.Queries.GetCustomerList
{
    public class CustomersListViewModel
    {
        public IList<CustomerLookupModel> Customers { get; set; }
    }
}
