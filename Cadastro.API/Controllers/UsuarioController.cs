using System;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            try{
                return Ok("");
            }
            catch (Exception ex){
                return BadRequest ($"Erro: {ex.Message}");
            }
            
        }

    
}
}