using MediatR;

namespace YandexTaxi.Application.UseCases.Order.Commands
{
    public class PutOrderCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public int AddressIdOne { get; set; }

        public int AddressIdTwo { get; set; }

        public int TaxiId { get; set; }


        public long Total { get; set; }


        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public string Status { get; set; }
    }
}
