using MediatR;

namespace YandexEats.Application.UseCases.Resturaunt.Commands
{
    public class DeleteResturauntCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
