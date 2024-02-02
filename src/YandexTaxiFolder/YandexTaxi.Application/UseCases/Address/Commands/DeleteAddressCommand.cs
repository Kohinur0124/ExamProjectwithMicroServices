using MediatR;

namespace YandexTaxi.Application.UseCases.Address.Commands
{
    public class DeleteAddressCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
