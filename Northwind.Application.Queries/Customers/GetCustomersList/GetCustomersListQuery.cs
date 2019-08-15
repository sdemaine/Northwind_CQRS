using MediatR;

namespace Northwind.Application.Queries.GetCustomerList
{
    public class GetCustomersListQuery : IRequest<CustomersListViewModel>
    {
    }
}
