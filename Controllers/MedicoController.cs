using Aula2ExemploCrud.Bordas_Interfaces.UseCases;
using Aula2ExemploCrud.DTO.Medico.AdicionarMedico;
using Aula2ExemploCrud.Entities;
using Aula2ExemploCrud.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MedicoController : ControllerBase
    {
        private readonly ILogger<MedicoController> _logger;
        private readonly IMedicoService _medicoService;

        private readonly IAdicionarMedicoUseCase _adicionarMedicoUseCase;

        public MedicoController(ILogger<MedicoController> logger, IMedicoService medicoService, IAdicionarMedicoUseCase adicionarMedicoUseCase)
        {
            _logger = logger;
            _medicoService = medicoService;
            _adicionarMedicoUseCase = adicionarMedicoUseCase;
        }



        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _medicoService.RetornaListaMedicos());

            }
            catch (System.Exception ex)
            {
                return BadRequest(new { erro = ex, msg = "Id não encontrado" });
            }

        }

        [HttpGet("{id}")]
        public  async Task<IActionResult> GetId(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id não encontrado");
            }

            try
            {
              
                return Ok(await _medicoService.RetornaMedicoId(id));

            }
            catch (System.Exception ex)
            {
                return BadRequest(new { erro = ex, msg = "Id não encontrado" });
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody] AdicionarMedicoRequest novoMedico)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(novoMedico);
            }

            return Ok(_adicionarMedicoUseCase.Executar(novoMedico));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id não encontrado");
            }

            try
            {
                await _medicoService.DeletarMedico(id);
                return NoContent();
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { erro = ex, msg = "Id não encontrado" });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] Medico medico, int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id não encontrado");
            }

            //var medicoId = _medicoService.RetornaMedicoId(id);
    
            try
            {
                return Ok(await _medicoService.AtualizarMedico(medico));
            
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { erro = ex, msg = "Id não encontrado" });
            }

        }

    }
}
