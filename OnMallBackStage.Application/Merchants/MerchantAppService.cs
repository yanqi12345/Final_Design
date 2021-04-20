using OnMallBackStage.Application.Merchants.Dto;
using OnMallBackStage.Domain.MerchantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace OnMallBackStage.Application.Merchants
{
    public class MerchantAppService : ApplicationService, IMerchantAppService
    {
        private readonly IRepository<Merchant> _merchantRepository;
        public MerchantAppService(IRepository<Merchant> merchantRepository)
        {
            _merchantRepository = merchantRepository;
        }

        public async Task<MerchantDto> Get(string merchantname)
        {
            var merchant = await _merchantRepository.GetAsync(a => a.MerchantName==merchantname);
            var get_dto = ObjectMapper.Map<Merchant, MerchantDto>(merchant);
            return get_dto;
        }
        public async Task<bool> Insert(MerchantDto dto)
        {

            var entity = ObjectMapper.Map<MerchantDto, Merchant>(dto);
            var post = await _merchantRepository.InsertAsync(entity);
            if (post == null)
            {
                return false;
            }
            return true;
        }
        public async Task<bool> Delete(string merchantno)
        {
            await _merchantRepository.DeleteAsync(a => a.MerchantNo == merchantno);
            return true;
        }

        public async Task<MerchantDto> Update(string merchantname, MerchantDto dto)
        {
            var merchant = await _merchantRepository.GetAsync(a => a.MerchantName == merchantname);//获取merchantname所对应的merchant
            var entity = ObjectMapper.Map<MerchantDto, Merchant>(dto);//创建实体

            merchant.MerchantNo = entity.MerchantNo;//赋值
            merchant.MerchantName= entity.MerchantName;
            merchant.MerchantPassword = entity.MerchantPassword;
            merchant.MerchantTel = entity.MerchantTel;

            merchant = await _merchantRepository.UpdateAsync(merchant);//更新
            var update_dto = ObjectMapper.Map<Merchant, MerchantDto>(merchant);//转化为Dto,返回web
            return update_dto;
        }


    }
}
