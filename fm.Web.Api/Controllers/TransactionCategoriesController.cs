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
    public class TransactionCategoriesController : ControllerBase
    {
        private ITransactionCategoryService _transactionCategoryService;
        public TransactionCategoriesController(ITransactionCategoryService transactionCategoryService)
        {
            _transactionCategoryService = transactionCategoryService;
        }

        // GET: api/TransactionCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionCategoryModel>>> GetTransactionCategories()
        {
            var result = await _transactionCategoryService.GetAll();
            if (result.Any())
                return Ok(result);
            return NoContent();
        }

        // GET: api/TransactionCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransactionCategoryModel>> GetTransactionCategory(long id)
        {
            var transactionCategory = await _transactionCategoryService.GetById(id);

            if (transactionCategory == null)
            {
                return NotFound();
            }

            return transactionCategory;
        }

        // PUT: api/TransactionCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransactionCategory(long id, TransactionCategoryModel transactionCategory)
        {
            try
            {
                transactionCategory.Id = id;
                var modelToUpdate = await _transactionCategoryService.Update(transactionCategory);                
                return Ok(modelToUpdate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // POST: api/TransactionCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TransactionCategoryModel>> PostTransactionCategory(TransactionCategoryModel transactionCategory)
        {            
            try
            {
                var savedModel = await _transactionCategoryService.Insert(transactionCategory);
                return Ok(savedModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }

        // DELETE: api/TransactionCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransactionCategory(long id)
        {
            var transactionCategory = await _transactionCategoryService.GetById(id);
            if (transactionCategory == null)
            {
                return NotFound();
            }
            var result = await _transactionCategoryService.Delete(id);

            return Ok(result);
        }
    }
}
