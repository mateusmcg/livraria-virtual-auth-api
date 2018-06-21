using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace livraria_virtual_payment_api.Controllers
{
    [Route("v1/public/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] Auth authInfo)
        {
            try
            {
                return Ok("Usuário autenticado.");
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost("validate")]
        public IActionResult Validate([FromBody] AuthValidade authInfo)
        {
            try
            {
                return Ok("Usuário possui permissão ao recurso.");
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
