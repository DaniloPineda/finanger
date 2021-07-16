using fm.Interfaces.Services;
using fm.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fm.Web.Api.Controllers
{
    public class TransactionTypesController : Controller
    {
        private ITransactionTypeService _transactionTypeService;
        public TransactionTypesController(ITransactionTypeService transactionTypeService)
        {
            _transactionTypeService = transactionTypeService;
        }

             // GET: api/TransactionTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionTypeModel>>> GetTransactionTypes()
        {
            var result = await _transactionTypeService.GetAll();
            if (result.Any())
                return Ok(result);
            return NoContent();
        }

        // GET: api/TransactionTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransactionTypeModel>> GetTransactionType(long id)
        {
            var model = await _transactionTypeService.GetById(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        // PUT: api/TransactionTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransactionType(long id, TransactionTypeModel transactionType)
        {
            try
            {
                transactionType.Id= id;
                var modelToUpdate = await _transactionTypeService.Update(transactionType);
                return Ok(modelToUpdate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/TransactionTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TransactionTypeModel>> PostTransactionType(TransactionTypeModel transactionType)
        {            
            try
            {
                var savedModel = await _transactionTypeService.Insert(transactionType);
                return Ok(savedModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/TransactionTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransactionType(long id)
        {
            var modelToDelete = await _transactionTypeService.GetById(id);
            if (modelToDelete == null)
            {
                return NotFound();
            }
            var result = await _transactionTypeService.Delete(id);

            return Ok(result);
        }
    }
}
