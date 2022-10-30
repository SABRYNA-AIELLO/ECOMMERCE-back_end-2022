using backend.Models;
using Microsoft.AspNetCore.Mvc;


namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeaderController : ControllerBase
    {

        [HttpGet("GetHeaderInfo")]
        public IActionResult GetHeaderInfo()
        {
            try
            {
                Header header = new Header();
                header.UrlImage = "logo de la marca";
                header.Nombre = "Tienda Ecommerce";
                header.Moneda = "Arg $ / U$S / EUR €";
                header.Help = "ventas@tienda.com / administracion@tienda.com" ;

                return Ok(header);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}


