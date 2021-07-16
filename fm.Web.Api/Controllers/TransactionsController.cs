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
    public class TransactionsController : ControllerBase
    {
        private ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        // GET: api/Transactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionModel>>> GetTransactions()
        {
            var result = await _transactionService.GetAll();
            if (result.Any())
                return Ok(result);
            return NoContent();
        }

        // GET: api/Transactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransactionModel>> GetTransaction(long id)
        {
            var model = await _transactionService.GetById(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        // PUT: api/Transactions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransaction(long id, TransactionModel transaction)
        {
            try
            {
                transaction.Id = id;
                var modelToUpdate = await _transactionService.Update(transaction);
                return Ok(modelToUpdate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Transactions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TransactionModel>> PostTransaction(TransactionModel transaction)
        {
            try
            {
                var savedModel = await _transactionService.Insert(transaction);
                return Ok(savedModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Transactions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransaction(long id)
        {
            var modelToDelete = await _transactionService.GetById(id);
            if (modelToDelete == null)
            {
                return NotFound();
            }
            var result = await _transactionService.Delete(id);

            return Ok(result);
        }

    }
}
