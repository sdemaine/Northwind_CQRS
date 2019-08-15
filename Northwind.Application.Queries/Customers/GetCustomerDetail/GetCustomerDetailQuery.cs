using MediatR;

namespace Northwind.Application.Queries.GetCustomerDetail
{
    public class GetCustomerDetailQuery : IRequest<CustomerDetailModel>
    {
        public string Id { get; set; }
    }
}
