using BlazorApp2.Services;
using BlazorApp2.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealsController : ControllerBase
    {
        private readonly IDealsService _dealsService;

        public DealsController(IDealsService dealsService)
        {
            _dealsService = dealsService;
        }

        [HttpGet("/api/deals/")]
        public async Task<IActionResult> GetDeal()
        {
            Deal? deal = _dealsService.GetDeal();

            if (deal == null)
                return NotFound();

            return Ok(deal);
        }
    }
}
