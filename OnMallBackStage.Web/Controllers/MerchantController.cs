using Microsoft.AspNetCore.Mvc;
using OnMallBackStage.Application.Merchants;
using OnMallBackStage.Application.Merchants.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnMallBackStage.Web.Controllers
{
    public class MerchantController : Controller
    {
        private readonly IMerchantAppService _merchantAppService;

        public MerchantController(IMerchantAppService merchantAppService)
        {
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
    }
}
