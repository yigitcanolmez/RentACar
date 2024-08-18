using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetById;
using Application.Features.Brands.Queries.GetList;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("brands")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] CreateBrandCommand createBrandCommand)
        {
            return Ok(await Mediator.Send(createBrandCommand));
        }
        [HttpGet]
        public async Task<IActionResult> GetListAsync([FromQuery] PageRequest pageRequest)
        {
            GetListBrandQuery getListBrandQuery = new GetListBrandQuery() { PageRequest = pageRequest };
            return Ok(await Mediator.Send(getListBrandQuery));
        }

        [HttpGet("getById/{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
        {
            GetByIdBrandQuery getByIdBrandQuery = new GetByIdBrandQuery() { Id = id };
            return Ok(await Mediator.Send(getByIdBrandQuery));
        }
    }
}
