using MediatR;

namespace YandexEats.Application.UseCases.Foods.Queries
{
    public class GetFoodCommand : IRequest<List<Domain.Entities.Foods>>
    {
    }
}
