using MediatR;

namespace YandexTaxi.Application.UseCases.Address.Commands
{
    public class PostAddressCommand : IRequest<bool>
    {
        public string Name { get; set; }

        public double x { get; set; }

        public double y { get; set; }
    }
}
