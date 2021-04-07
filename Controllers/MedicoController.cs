using Microsoft.AspNetCore.Mvc;
using Aula2ExemploCrud.Entities;
using Aula2ExemploCrud.Services;
using Microsoft.Extensions.Logging;

namespace Aula2ExemploCrud.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MedicoController : ControllerBase
    {
        private readonly ILogger<MedicoController> _logger;
        private readonly IMedicoService _medicoService;

        public MedicoController(ILogger<MedicoController> logger, IMedicoService medicoService)
        {
            _logger = logger;
            _medicoService = medicoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_medicoService.RetornaListaMedicos());
       
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            return Ok(_medicoService.RetornaMedicoId(id));

        }

        [HttpPost]
        public IActionResult Post([FromBody] Medico medico)
        {
            return Ok(_medicoService.AdicionarMedico(medico));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _medicoService.DeletarMedico(id);
            return NoContent();
        }



    }
}
