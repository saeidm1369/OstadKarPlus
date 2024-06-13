using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OstadKarPlus.Domain.Core.UsersAgg.AppService;

namespace OstadKarPlus.Endpoins.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet]
        public IActionResult List(int? page, int? length, string? search, string? sort, string? dir)
        {
            return Ok(_userAppService.GetList(page, length, search));
        }

        [HttpGet("{userId}")]
        public IActionResult Get(string userId)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Add()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpPatch]
        public IActionResult UpdatePassword()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
