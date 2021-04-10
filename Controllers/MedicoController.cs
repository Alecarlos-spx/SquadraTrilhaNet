using Aula2ExemploCrud.Bordas_Interfaces.UseCases;
using Aula2ExemploCrud.DTO.Medico.AdicionarMedico;
using Aula2ExemploCrud.DTO.Medico.AtualizarMedico;
using Aula2ExemploCrud.DTO.Medico.DeletarMedico;
using Aula2ExemploCrud.DTO.Medico.RetornaMedicoId;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Aula2ExemploCrud.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MedicoController : ControllerBase
    {
        private readonly ILogger<MedicoController> _logger;
       

        private readonly IAdicionarMedicoUseCase _adicionarMedicoUseCase;
        private readonly IAtualizarMedicoUseCases _atualizarMedicoUseCases;
        private readonly IDeletarMedicoUseCase _deletarMedicoUseCase;
        private readonly IRetornaMedicoIdUseCase _retornaMedicoIdUseCase;
        private readonly IRetornaListaMedicosUseCase _retornaListaMedicosUseCase;

        public MedicoController(ILogger<MedicoController> logger, IAdicionarMedicoUseCase adicionarMedicoUseCase, IAtualizarMedicoUseCases atualizarMedicoUseCases, IDeletarMedicoUseCase deletarMedicoUseCase, IRetornaMedicoIdUseCase retornaMedicoIdUseCase, IRetornaListaMedicosUseCase retornaListaMedicosUseCase)
        {
            _logger = logger;
            _adicionarMedicoUseCase = adicionarMedicoUseCase;
            _atualizarMedicoUseCases = atualizarMedicoUseCases;
            _deletarMedicoUseCase = deletarMedicoUseCase;
            _retornaMedicoIdUseCase = retornaMedicoIdUseCase;
            _retornaListaMedicosUseCase = retornaListaMedicosUseCase;
        }



        [HttpGet]
        public  IActionResult Get()
        {
            return Ok(_retornaListaMedicosUseCase.Executar());

        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id não encontrado");
            }
            var request = new RetornaMedicoIdRequest();
            request.id = id;

            return Ok(_retornaMedicoIdUseCase.Executar(request));

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
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id não encontrado");
            }
            var request = new DeletarMedicoRequest();
            request.id = id;

            return Ok(_deletarMedicoUseCase.Executar(request));
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] AtualizarMedicoRequest medicoAtualizar, int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id não encontrado");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(medicoAtualizar);
            }

            return Ok(_atualizarMedicoUseCases.Executar(medicoAtualizar, id));
        }

    }
}
