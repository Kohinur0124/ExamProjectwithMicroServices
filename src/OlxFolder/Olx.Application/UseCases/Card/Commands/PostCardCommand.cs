using MediatR;

namespace Olx.Application.UseCases.Card.Commands
{
    public class PostCardCommand : IRequest<bool>
    {
        public string Number { get; set; }

        public string ExpireDate { get; set; }

        public long Amount { get; set; }
    }
}
