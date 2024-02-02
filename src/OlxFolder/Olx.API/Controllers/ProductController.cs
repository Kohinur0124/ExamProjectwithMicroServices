using MediatR;
using Microsoft.AspNetCore.Mvc;
using Olx.Application.UseCases.Product.Commands;
using Olx.Application.UseCases.Product.Queries;

namespace Olx.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetAllProduct()
    {
        var cards = await _mediator.Send(new GetProductCommand());
        return Ok(cards);
    }



    [HttpPost]

    public async ValueTask<bool> AddProduct(PostProductCommand postCard)
    {
        var t = await _mediator.Send(postCard);
        return t;
    }
    [HttpPut]

    public async ValueTask<IActionResult> UpdateProduct(PutProductCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }

    [HttpDelete]

    public async ValueTask<IActionResult> DeleteProduct(DeleteProductCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }


}
