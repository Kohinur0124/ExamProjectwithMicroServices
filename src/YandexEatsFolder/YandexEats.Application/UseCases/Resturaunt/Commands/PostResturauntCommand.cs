using MediatR;

namespace YandexEats.Application.UseCases.Resturaunt.Commands
{
    public class PostResturauntCommand : IRequest<bool>
    {
        public string Name { get; set; }

        public int UserId { get; set; }

        public int CardId { get; set; }

    }
}
