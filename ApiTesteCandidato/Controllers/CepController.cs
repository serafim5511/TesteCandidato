using ApiTesteCandidato.Models;
using Domain.Interfaces;
using EntitiesTesteCandidato;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiTesteCandidato.Controllers
{
    public class CepController : Controller
    {
        private readonly ICep _ICep;

        public CepController(ICep ICep)
        {
            _ICep = ICep;
        }

        [HttpPost("/api/Cadastrar")]
        public async Task<IActionResult> Cadastrar([FromBody] Cep cep)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {                
                await _ICep.Add(cep);

                return Ok(new ApiResposta<DateTime>(DateTime.Now, true, 200, "Ok"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResposta<DateTime>(DateTime.Now, false, 400, "Ocorreu um erro"));
            }
        }
        [HttpGet("/api/BuscarLista")]
        public async Task<IActionResult> BuscarLista()
        {     
            try
            {
                var result = await _ICep.List();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResposta<DateTime>(DateTime.Now, false, 400, "Ocorreu um erro"));
            }
        }
    }
}
