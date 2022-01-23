using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTEAPI.Data;
using TESTEAPI.Models;

namespace TESTEAPI.Controllers
{
    [ApiController()]
    public class HomeController : ControllerBase
    {

        [HttpGet("/GetListCustomers")]
        public IActionResult GetListCustomers([FromServices] AppDbContext ctx)
        {
            List<Customer> lstCst = new List<Customer>();

            lstCst = ctx.Customers.ToList();

            if(lstCst == null)
            {
                return NotFound();
            }

            return Ok(lstCst);
        }

        [HttpGet("/{id:int}")]
        public IActionResult GetCustomerById([FromServices] AppDbContext ctx, [FromRoute] int id)
        {
            Customer cst = new Customer();

            cst = ctx.Customers.FirstOrDefault(x => x.idCustomer == id);

            if (cst == null)
            {
                return NotFound();
            }

            return Ok(cst);
        }

        [HttpPost("/PostCustomer")]
        public IActionResult PostCustomer([FromServices] AppDbContext ctx, [FromBody] Customer cst)
        {
            ctx.Add(cst);
            ctx.SaveChanges();
           
            return Created($"/{cst.idCustomer}", cst);
        }

        [HttpPut("/{id:int}")]
        public IActionResult PutCustomer([FromServices] AppDbContext ctx, [FromRoute] int id, [FromBody] Customer cst)
        {
            var cst2 = ctx.Customers.FirstOrDefault(x => x.idCustomer == id);

            if(cst == null)
            {
                return NotFound();
            }

            cst2.dsName = cst.dsName;
            cst2.dsEmail = cst.dsEmail;
            cst2.dsCPFCNPJ = cst.dsCPFCNPJ;

            ctx.Update(cst2);
            ctx.SaveChanges();

            return Ok(cst2);
        }

        [HttpDelete("/{id:int}")]
        public IActionResult DeleteCustomer([FromServices] AppDbContext ctx, [FromRoute] int id)
        {
            Customer cst = ctx.Customers.FirstOrDefault(x => x.idCustomer == id);

            if(cst == null)
            {
                return NotFound();
            }

            ctx.Remove(cst);
            ctx.SaveChanges();

            return Ok(cst);
        }
    }
}
