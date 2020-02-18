using AutoMapper;
using GesCMS.Models;
using GesCMS.Repository.Repositories;
using GesCMS.Services.AdminServices.Inteface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace GesCMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly IPageService _pageServcice;

        public HomeController(ILogger<HomeController> logger, IPageService pageService, IMapper mapper, IPageRepository pageRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _pageServcice = pageService;
        }

        public async System.Threading.Tasks.Task<IActionResult> IndexAsync()
        {
            var x = await _pageServcice.GetList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
