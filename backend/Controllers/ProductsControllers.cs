using Back_End.Models;
using Microsoft.AspNetCore.Mvc;

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
                products = GetProducts();
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
                products = GetProducts();
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
            List<Product> products = new List<Product>();
            List<Product> productsDestacado = new List<Product>();
            try
            {
                products = GetProducts();

                foreach (var product in products)
                {
                    if (product.Destacado == true)
                    {
                        productsDestacado.Add(product);
                    }
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(productsDestacado);
        }



        private List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            Product product1 = new Product(1, "Producto 1", 3000, false);
            product1.Description = "Remera basica blanca";
            product1.category = new Category(1, "Remeras");
            products.Add(product1);

            Product product2 = new Product(2, "Producto 2", 800, true);
            product2.Description = "Buzo canguro sin capucha";
            product2.category = new Category(2, "Buzos");
            products.Add(product2);

            Product product3 = new Product(3, "Producto 3", 1000, false);
            product3.Size = "XXXL";
            products.Add(product3);

            Product product4 = new Product(2, "Producto 4", 1000, true);
            product4.Description = "Buzo canguro con capucha";
            product4.category = new Category(2, "Buzos");
            products.Add(product4);

            Product product5 = new Product(1, "Producto 5", 2000, false);
            product5.Description = "Remera basica negra";
            product5.category = new Category(1, "Remeras");
            products.Add(product5);

            return products;
        }
    }
}

        //shif+F9//
        //comentar en blocke: control+k+c//
        //descomentar en blocker: control+k+u//
