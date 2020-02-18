using GesCMS.Application.Page.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace GesCMS.WebUI.Controllers.Admin
{
    [Route("api/[controller]")]

    public class PageController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<PageViewModel>> Get()
        {
            return await Mediator.Send(new GetPageQuery());
        }
    }
}