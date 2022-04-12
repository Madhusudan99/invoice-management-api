#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InvoiceManagement.Data;
using InvoiceManagement.Models;

namespace InvoiceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceDetailsController : ControllerBase
    {
        private readonly DataContext _context;

        public InvoiceDetailsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/InvoiceDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceDetail>>> Getinvoices()
        {
            return await _context.invoices.ToListAsync();
        }

        // GET: api/InvoiceDetails/ByClientIdAndCompanyId?ClientId=1&&CompanyId=2
        [HttpGet("ByClientIdAndCompanyId/")]
        public async Task<ActionResult<IEnumerable<InvoiceDetail>>> GetinvoicesByClientIdAndCompanyId(int ClientId, int CompanyId)
        {
            return await _context.invoices.Where(i => i.ClientId == ClientId && i.CompanyId == CompanyId).ToListAsync();
        }

        // GET: api/InvoiceDetails/ByCompanyId?CompanyId=2
        [HttpGet("ByCompanyId/")]
        public async Task<ActionResult<IEnumerable<InvoiceDetail>>> GetinvoicesByCompanyId(int CompanyId)
        {
            return await _context.invoices.Where(i => i.CompanyId == CompanyId).ToListAsync();
        }

        // GET: api/InvoiceDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceDetail>> GetInvoiceDetail(string id)
        {
            var invoiceDetail = await _context.invoices.FindAsync(id);

            if (invoiceDetail == null)
            {
                return NotFound();
            }

            return invoiceDetail;
        }

        // PUT: api/InvoiceDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoiceDetail(string id, InvoiceDetail invoiceDetail)
        {
            if (id != invoiceDetail.InvoiceNumber)
            {
                return BadRequest();
            }

            _context.Entry(invoiceDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/InvoiceDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InvoiceDetail>> PostInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            _context.invoices.Add(invoiceDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InvoiceDetailExists(invoiceDetail.InvoiceNumber))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInvoiceDetail", new { id = invoiceDetail.InvoiceNumber }, invoiceDetail);
        }

        // DELETE: api/InvoiceDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoiceDetail(string id)
        {
            var invoiceDetail = await _context.invoices.FindAsync(id);
            if (invoiceDetail == null)
            {
                return NotFound();
            }

            _context.invoices.Remove(invoiceDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvoiceDetailExists(string id)
        {
            return _context.invoices.Any(e => e.InvoiceNumber == id);
        }
    }
}
