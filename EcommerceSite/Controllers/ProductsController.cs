using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace EcommerceSite.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {        

        //public ProductsController(IProdutoServico ecommerceDbContext)
        //{
            
        //}

        //// api/products HTTP GET
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var products = _ecommerceDbContext.Products.ToList();
        //    return Ok(products);
        //}

        //// api/products/{id}
        //[HttpGet("{id}")]
        //public IActionResult GetById(int id)
        //{
        //    var product = _ecommerceDbContext.Products.SingleOrDefault(p => p.Id == id);

        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(product);
        //}

        //[HttpPost]
        //public IActionResult Post([FromBody] ProductInputModel productInputModel)
        //{
        //    if (productInputModel == null)
        //    {
        //        return BadRequest();
        //    }

        //    var product = new Produto(productInputModel.Description, productInputModel.Price);

        //    _ecommerceDbContext.Products.Add(product);

        //    _ecommerceDbContext.SaveChanges();

        //    return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        //}

        //[HttpPut("{id}")]
        //public IActionResult Put([FromBody] ProductInputModel productInputModel, int id)
        //{
        //    if (productInputModel == null)
        //    {
        //        return BadRequest();
        //    }

        //    var product = _ecommerceDbContext.Products.SingleOrDefault(p => p.Id == id);

        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    product.Description = productInputModel.Description;
        //    product.Price = productInputModel.Price;

        //    _ecommerceDbContext.SaveChanges();

        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    var product = _ecommerceDbContext.Products.SingleOrDefault(p =>p.Id == id);

        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    _ecommerceDbContext.Products.Remove(product);

        //    _ecommerceDbContext.SaveChanges();

        //    return NoContent();
        //}
    }
}
