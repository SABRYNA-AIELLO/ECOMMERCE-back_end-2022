using Back_End.Models;
using Microsoft.AspNetCore.Mvc;
using Back_End.Repositories;

namespace Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


        [HttpGet("GetErrorExample")]
        public IActionResult GetErrorExample()
        {
            List<Product> products = new List<Product>();

            try
            {
                Product product = new Product(3, "ropa", 1000, false);
                product.SetNewPrice(850);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
            return Ok(products);
        }


        [HttpGet("GetProductsHome")]
        public ActionResult GetProductsHome()
        {
            List<Product> products = new List<Product>();
            try
            {
                ProductRepository repo = new ProductRepository();
                products = repo.GetProducts();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(products);
        }



        [HttpGet("GetProductsByCategory")]
        public IActionResult GetProductsByCategory(int idCategory)
           {
            List<Product> products = new List<Product>();
            List<Product> productsByCategory = new List<Product>();
            try
            {
                ProductRepository repo = new ProductRepository();
                products = repo.GetProducts();
                foreach (var product in products)
                {
                    if (product.category.idCategory == idCategory)
                    { 
                        productsByCategory.Add(product);
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(productsByCategory);
        }



        [HttpGet("GetProductsByDestacados")]
        public ActionResult GetProductsByDestacados()
        {
            List<Product> productsAux = new List<Product>();
            List<Product> productsDestacado = new List<Product>();
            try
            {

                ProductRepository repo = new ProductRepository();
                productsAux = repo.GetProducts();
                foreach (var product in productsAux) { if (product.Destacado) productsDestacado.Add(product);}
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(productsDestacado);
        }

        [HttpPost("AddProductToCart")] //Crear
        public IActionResult AddProductToCart(int idProducto, int cantidad)
        {
            try
            {
                CartRepository.AddProductToCart(idProducto, cantidad);
                return Ok("El producto se agrego con exito");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetCart")]
        public IActionResult GetCart()
        {
            try
            {
                return Ok(CartRepository.GetCart().items);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


    }
}



//shif+F9//
//comentar en blocke: control+k+c//
//descomentar en blocker: control+k+u//
