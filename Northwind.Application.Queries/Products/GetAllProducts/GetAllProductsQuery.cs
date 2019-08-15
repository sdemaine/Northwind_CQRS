using MediatR;

namespace Northwind.Application.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<ProductsListViewModel>
    {
    }
}
