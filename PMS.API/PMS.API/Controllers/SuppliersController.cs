using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMS.API.Data;
using PMS.API.Models;

namespace PMS.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SuppliersController : Controller
    {
        private readonly PMSDbContext _pmsDbContext;
        public SuppliersController(PMSDbContext pmsDbContext)
        {
            this._pmsDbContext = pmsDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSuppliers()
        {
            var suppliers = await _pmsDbContext.Suppliers.ToListAsync();

            return Ok(suppliers);
        }

        [HttpPost]
        public async Task<IActionResult> AddSupplier([FromBody] Supplier supplier)
        {
            await _pmsDbContext.Suppliers.AddAsync(supplier);
            await _pmsDbContext.SaveChangesAsync();

            return Ok(supplier);
        }

        [HttpGet]
        [Route("{supplierNo:Int}")]
        public async Task<IActionResult> GetSupplier(int supplierNo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var supplier = await _pmsDbContext.Suppliers.FirstOrDefaultAsync(x => x.SupplierNo == supplierNo);

            if (supplier == null)
                return NotFound();

            return Ok(supplier);
        }

        [HttpPut]
        [Route("{supplierNo:Int}")]
        public async Task<IActionResult> UpdateSupplier([FromRoute] int supplierNo, Supplier updateSupplierRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supplier = await _pmsDbContext.Suppliers.FindAsync(supplierNo);

            if (supplier == null)
                return NotFound();

            supplier.SupplierName = updateSupplierRequest.SupplierName;
            supplier.Phone = updateSupplierRequest.Phone;
            supplier.Address = updateSupplierRequest.Address;
            supplier.Email = updateSupplierRequest.Email;

            await _pmsDbContext.SaveChangesAsync();

            return Ok(supplier);
        }

        [HttpDelete]
        [Route("{supplierNo:Int}")]
        public async Task<IActionResult> DeleteProduct(int supplierNo)
        {
            var supplier = await _pmsDbContext.Suppliers.FindAsync(supplierNo);

            if (supplier == null)
                return NotFound();

            _pmsDbContext.Suppliers.Remove(supplier);
            await _pmsDbContext.SaveChangesAsync();

            return Ok(supplier);
        }
    }
}
