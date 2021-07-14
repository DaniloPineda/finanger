using AutoMapper;
using fm.Data.EFModels;
using fm.Models;

namespace fm.Common.AutomapperProfiles
{
    public class TransactionToModelProfile : Profile
    {
        public TransactionToModelProfile()
        {
            CreateMap<Transaction, TransactionModel>();
            CreateMap<TransactionModel, Transaction>();
        }
    }
}
