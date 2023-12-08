using MediatR;

namespace Olx.Application.UseCases.Product.Queries
{
    public class GetProductCommand : IRequest<List<Domain.Entity.Product>>
    {
    }
}
