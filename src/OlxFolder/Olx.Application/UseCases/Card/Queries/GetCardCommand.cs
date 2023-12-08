using MediatR;

namespace Olx.Application.UseCases.Card.Queries
{
    public class GetCardCommand : IRequest<List<Domain.Entity.Card>>
    {
    }
}
