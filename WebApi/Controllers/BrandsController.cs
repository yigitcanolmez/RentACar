using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("brands")]
    [ApiController]
    public class BrandsController : BaseController
    {
        public BrandsController()
        {
            
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] CreateBrandCommand createBrandCommand)
        {
            return Ok(await Mediator!.Send(createBrandCommand));
        }
    }
}
