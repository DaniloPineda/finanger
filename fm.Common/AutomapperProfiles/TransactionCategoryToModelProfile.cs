using AutoMapper;
using fm.Data.EFModels;
using fm.Models;

namespace fm.Common.AutomapperProfiles
{
    public class TransactionCategoryToModelProfile : Profile
    {
        public TransactionCategoryToModelProfile()
        {
            CreateMap<TransactionCategory, TransactionCategoryModel>();
            CreateMap<TransactionCategoryModel, TransactionCategory>();
        }
    }
}
