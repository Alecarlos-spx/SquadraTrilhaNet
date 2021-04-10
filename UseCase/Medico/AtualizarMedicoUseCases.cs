using Aula2ExemploCrud.Bordas___Interfaces.UseCases.Repositorio;
using Aula2ExemploCrud.Bordas_Interfaces.Adapter;
using Aula2ExemploCrud.Bordas_Interfaces.UseCases;
using Aula2ExemploCrud.DTO.Medico.AtualizarMedico;
using System;

namespace Aula2ExemploCrud.UseCase.Medico
{
    public class AtualizarMedicoUseCases : IAtualizarMedicoUseCases
    {
        private readonly IRepositorioMedicos _repositorioMedicos;
        private readonly IAtualizarMedicoAdapter _adapter;

        public AtualizarMedicoUseCases(IRepositorioMedicos repositorioMedico, IAtualizarMedicoAdapter adapter)
        {
            _repositorioMedicos = repositorioMedico;
            _adapter = adapter;
        }

        public AtualizarMedicoResponse Executar(AtualizarMedicoRequest request, int id)
        {
            var response = new AtualizarMedicoResponse();

            try
            {
                var medico = _repositorioMedicos.GetId(id);
                if (medico == null)
                {
                    response.msg = "Erro ao atualizar o médico";
                    return response;
                }


                var medicoAtualizar = _adapter.converterRequestParaMedico(request);

                medicoAtualizar.id = id;
                _repositorioMedicos.Update(medicoAtualizar);
                response.msg = "Atualizado com sucesso";
                response.id = medicoAtualizar.id;
                return response;

            }
            catch (Exception)
            {

                response.msg = "Erro ao atualizar o médico";
                return response;
            }

        }
    }
}
