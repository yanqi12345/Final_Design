using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnMallBackStage.Application.Merchants;
using OnMallBackStage.Application.Merchants.Dto;
using OnMallBackStage.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace OnMallBackStage.Web.Controllers
{
    
    public class HomeController : Controller
      
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMerchantAppService _merchantAppService;

        public HomeController(ILogger<HomeController> logger, IMerchantAppService merchantAppService)
        {
            _logger = logger;
            _merchantAppService = merchantAppService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<MerchantDto> GetMerchant(string merchantname)
        {
            var merchant = await _merchantAppService.Get(merchantname);
            return merchant;
        }

        public async Task<bool> InsertMerchant(MerchantDto dto)
        {
            return await _merchantAppService.Insert(dto);
        }
        public async Task<bool> DeleteMerchant(string merchantno)
        {
            return await _merchantAppService.Delete(merchantno);
        }

        public async Task<MerchantDto> UpdateMerchant(string merchantname, MerchantDto dto)
        {
            var user = await _merchantAppService.Update(merchantname, dto);
            return user;
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
  
    /*
    public class HomeController : AbpController
    {
        public ActionResult Index()
        {
            return Redirect("~/swagger");
        }
    }
    */
}
