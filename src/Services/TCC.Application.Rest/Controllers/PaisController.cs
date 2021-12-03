using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TCC.Application.Rest.GrpcServices;
using TCC.Application.Rest.Models;

namespace TCC.Application.Rest.Controllers
{
    [Route("paises")]
    public class PaisController : BaseController
    {
        private readonly PaisGrpcService _paisGrpcService;

        public PaisController(PaisGrpcService paisGrpcService)
        {
            _paisGrpcService = paisGrpcService;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<Pais>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ObterPaisesAsync()
        {
            var pathData = Path.Combine(Directory.GetCurrentDirectory(), "Data", "data.json");

            try
            {
                using (var fs = new FileStream(pathData, FileMode.Open, FileAccess.Read))
                {
                    var paises = await DeserializarAsync<List<Pais>>(fs);

                    return Ok(paises);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{nome}")]
        [ProducesResponseType(typeof(Pais), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ObterPaisesPorNomeAsync(string nome)
        {
            var pathData = Path.Combine(Directory.GetCurrentDirectory(), "Data", "data.json");

            try
            {
                using (var fs = new FileStream(pathData, FileMode.Open, FileAccess.Read))
                {
                    var paises = await DeserializarAsync<List<Pais>>(fs);

                    var pais = paises.FirstOrDefault(x => x.NomePais.ToLower() == nome.ToLower());

                    if (pais == null) return NoContent();

                    return Ok(pais);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("grpc/{nome}")]
        [ProducesResponseType(typeof(List<Pais>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ObterPaisesGrpcAsync(string nome)
        {
            var pathData = Path.Combine(Directory.GetCurrentDirectory(), "Data", "data.json");

            try
            {
                var pais = await _paisGrpcService.GetPaisNomeAsync(nome);
                return Ok(pais);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
