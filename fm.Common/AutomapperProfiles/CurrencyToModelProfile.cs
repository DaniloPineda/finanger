using AutoMapper;
using fm.Data.EFModels;
using fm.Models;

namespace fm.Common.AutomapperProfiles
{
    public class CurrencyToModelProfile : Profile 
    {
        public CurrencyToModelProfile()
        {
            CreateMap<Currency, CurrencyModel>();
            CreateMap<CurrencyModel, Currency>();
        }
    }
}
