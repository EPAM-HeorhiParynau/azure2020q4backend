using System.Collections.Generic;
using System.Linq;
using Azure2020q4API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Azure2020q4API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly AdventureWorks2019Context _context;
		private readonly ILogger<ProductController> _logger;

		public ProductController(AdventureWorks2019Context context, ILogger<ProductController> logger)
		{
			_context = context;
			_logger = logger;
		}

		// GET: api/<Product>
		[HttpGet]
		public IEnumerable<Product> Get()
		{
			_logger.LogWarning("Get is not implemented.!!!!");
			return new Product[0];
		}

		// GET api/<Product>/5
		[HttpGet("{id}")]
		public Product Get(int id)
		{
			return _context.Product.FirstOrDefault(e => e.ProductId == id);
		}

		// POST api/<Product>
		[HttpPost]
		public void Post([FromBody] Product value)
		{
			_context.Product.Add(value);
			_context.SaveChanges();
		}

		// PUT api/<Product>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
			var entry = _context.Product.FindAsync(id);

			_context.Entry(entry).CurrentValues.SetValues(entry);
			_context.SaveChanges();
		}

		// DELETE api/<Product>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			var applicationContextToDelete = _context.Product.Find(id);
			_context.Product.Remove(applicationContextToDelete);

			_context.SaveChanges();
		}
	}
}
