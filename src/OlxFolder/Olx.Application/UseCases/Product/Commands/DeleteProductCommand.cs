using MediatR;

namespace Olx.Application.UseCases.Product.Commands
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
