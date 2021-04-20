using AutoMapper;
using OnMallBackStage.Application.Merchants.Dto;
using OnMallBackStage.Domain.MerchantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMallBackStage.Application
{
    class OnMallBackStageApplicationAutomapperProfile:Profile
    {
        public OnMallBackStageApplicationAutomapperProfile()
        {
            CreateMap<Merchant, MerchantDto>();
            CreateMap<MerchantDto, Merchant>();
        }
    }
}
