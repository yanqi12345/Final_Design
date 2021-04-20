using OnMallBackStage.Application.Merchants.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace OnMallBackStage.Application.Merchants
{
    public interface IMerchantAppService: IApplicationService
    {
        Task<MerchantDto> Get(string merchantname);
        Task<bool> Insert(MerchantDto dto);

        Task<bool> Delete(string merchantno);

        Task<MerchantDto> Update(string merchantname, MerchantDto dto);
    }
}
