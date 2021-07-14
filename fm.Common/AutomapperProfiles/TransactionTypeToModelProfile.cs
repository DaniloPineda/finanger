using AutoMapper;
using fm.Data.EFModels;
using fm.Models;

namespace fm.Common.AutomapperProfiles
{
    public class TransactionTypeToModelProfile : Profile
    {
        public TransactionTypeToModelProfile()
        {
            CreateMap<TransactionType, TransactionTypeModel>();
            CreateMap<TransactionTypeModel, Transaction>();
        }
    }
}
