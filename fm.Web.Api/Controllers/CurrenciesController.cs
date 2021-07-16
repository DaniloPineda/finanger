using fm.Interfaces.Services;
using fm.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fm.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        private ICurrencyService _currencyService;

        public CurrenciesController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        // GET: api/Currencies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurrencyModel>>> GetCurrencies()
        {
            var result = await _currencyService.GetAll();
            if (result.Any())
                return Ok(result);
            return NoContent();
        }

        // GET: api/Currencies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurrencyModel>> GetCurrency(long id)
        {
            var model = await _currencyService.GetById(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        // PUT: api/Currencies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurrency(long id, CurrencyModel currency)
        {
            try
            {
                currency.Id = id;
                var modelToUpdate = await _currencyService.Update(currency);
                return Ok(modelToUpdate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Currencies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CurrencyModel>> PostCurrency(CurrencyModel currency)
        {            
            try
            {
                var savedModel = await _currencyService.Insert(currency);
                return Ok(savedModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Currencies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCurrency(long id)
        {
            var modelToDelete = await _currencyService.GetById(id);
            if (modelToDelete == null)
            {
                return NotFound();
            }
            var result = await _currencyService.Delete(id);

            return Ok(result);
        }

    }
}
