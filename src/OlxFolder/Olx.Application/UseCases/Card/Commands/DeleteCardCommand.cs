using MediatR;

namespace Olx.Application.UseCases.Card.Commands
{
    public class DeleteCardCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
