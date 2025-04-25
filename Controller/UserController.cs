using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("ObterHoraDataAtual")]
       public IActionResult ObterDataHora()
       {
            var obj = new 
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToLongTimeString()
            };

            return Ok(obj);
       }

        [HttpGet("Apresentar/{nome}")]
       public IActionResult Apresentar(string nome)
        {
                var mensagem = $"Olá {nome},seja bem vindo!";
                return Ok(new {mensagem});
        }

    }
}