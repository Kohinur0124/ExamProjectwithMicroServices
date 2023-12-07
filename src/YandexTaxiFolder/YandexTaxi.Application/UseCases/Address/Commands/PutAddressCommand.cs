using MediatR;

namespace YandexTaxi.Application.UseCases.Address.Commands
{
    public class PutAddressCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double x { get; set; }

        public double y { get; set; }
    }
}
