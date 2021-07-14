using fm.Models;
using fm.Interfaces.Repositories;
using fm.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using fm.Data.EFModels;
using System;

namespace fm.Services.EntityFramework
{
    public class CurrencyService : ICurrencyService
    {
        private ICurrencyRepository _currencyRepo;
        private IMapper _mapper;
        public CurrencyService(ICurrencyRepository currencyRepo, IMapper mapper)
        {
            _currencyRepo = currencyRepo;
            _mapper = mapper;
        }

        public Task<IEnumerable<CurrencyModel>> GetAll()
        {
            var currency = _currencyRepo.Get();
            return Task.FromResult(_mapper.Map<IEnumerable<CurrencyModel>>(currency));
        }

        public Task<CurrencyModel> GetById(long id)
        {
            var currency = _currencyRepo.GetByID(id);
            return Task.FromResult(_mapper.Map<CurrencyModel>(currency));
        }

        public Task<IEnumerable<CurrencyModel>> GetByName(string term)
        {
            var currency = _currencyRepo.Get(x => x.CurrencyName.Contains(term));
            return Task.FromResult(_mapper.Map<IEnumerable<CurrencyModel>>(currency));
        }

        public Task<CurrencyModel> Insert(CurrencyModel model)
        {
            try
            {
                var currency = _mapper.Map<Currency>(model);
                _currencyRepo.Insert(currency);
                _currencyRepo.SaveChanges();
                return Task.FromResult(_mapper.Map<CurrencyModel>(currency));
            }
            catch (Exception)
            {
                throw;
            }


        }

        public Task<CurrencyModel> Update(CurrencyModel model)
        {
            try
            {
                var currency = _mapper.Map<Currency>(model);
                _currencyRepo.Update(currency);
                _currencyRepo.SaveChanges();
                return Task.FromResult(_mapper.Map<CurrencyModel>(currency));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<bool> Delete(long id)
        {
            try
            {
                _currencyRepo.Delete(id);
                _currencyRepo.SaveChanges();
                var itemDeleted = _currencyRepo.GetByID(id) == null;
                return Task.FromResult(itemDeleted);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
