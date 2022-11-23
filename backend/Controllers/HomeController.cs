using backend.Models;
using Microsoft.AspNetCore.Mvc;
using static backend.Models.Home;

namespace backend.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("GetHomeInfo")]
        public IActionResult GetHomeInfo()
        {
            try
            {
                HomeInfo homeInfo = new HomeInfo();

                homeInfo.header.UrlImage = "logo de la marca";
                homeInfo.header.Nombre = "Tienda Ecommerce";
                homeInfo.header.Moneda = "Arg $ / U$S / EUR €";
                homeInfo.header.Help = "ventas@tienda.com / administracion@tienda.com";

                homeInfo.footer.direccion = "Tucuman 752";
                homeInfo.footer.horario = "8 a 16hs";
                homeInfo.footer.telefono = "6319-1584";

                return Ok(homeInfo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }


}
