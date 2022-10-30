using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDataController : ControllerBase
    {
        [HttpGet("GetFooterData")]
        public IActionResult GetFooterData()
        {
            try
            {
                Footer footer = new Footer();
                footer.direccion = "Tucuman 752";
                footer.horario = "8 a 16hs";
                footer.telefono = "6319-1584";
                 return Ok(footer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
           
        }
    }
}
