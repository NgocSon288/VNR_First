using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VNR.Dto.KhoaHoc;
using VNR.Entities;
using VNR.Models;
using VNR.Services.Interfaces;

namespace VNR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IKhoaHocService _khoaHocService;
        private readonly IMonHocService _monHocService;

        public HomeController(ILogger<HomeController> logger,
            IKhoaHocService khoaHocService, 
            IMonHocService monHocService)
        {
            _logger = logger;
            _khoaHocService = khoaHocService;
            _monHocService = monHocService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _khoaHocService.GetAll());
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

        #region Apis

        [HttpGet]
        public async Task<KhoaHocDto> GetMonHocByKhoaHocId(int id)
        {
            return await _khoaHocService.GetById(id);
        }

        #endregion
    }
}
