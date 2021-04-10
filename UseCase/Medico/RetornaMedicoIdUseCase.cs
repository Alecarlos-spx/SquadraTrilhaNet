using Aula2ExemploCrud.Bordas___Interfaces.UseCases.Repositorio;
using Aula2ExemploCrud.Bordas_Interfaces.Adapter;
using Aula2ExemploCrud.Bordas_Interfaces.UseCases;
using Aula2ExemploCrud.DTO.Medico.RetornaMedicoId;
using System;

namespace Aula2ExemploCrud.UseCase.Medico
{
    public class RetornaMedicoIdUseCase : IRetornaMedicoIdUseCase
    {
        private readonly IRepositorioMedicos _repositorioMedicos;
        private readonly IRetornaMedicoIdAdapter _adapter;

        public RetornaMedicoIdUseCase(IRepositorioMedicos repositorioMedicos, IRetornaMedicoIdAdapter adapter)
        {
            _repositorioMedicos = repositorioMedicos;
            _adapter = adapter;
        }

        public RetornaMedicoIdResponse Executar(RetornaMedicoIdRequest request)
        {
            var response = new RetornaMedicoIdResponse();

            try
            {
                var medico = _repositorioMedicos.GetId(request.id);
                if (medico == null)
                {
                    response.msg = "Erro ao pesquisar o médico";
                    return response;
                }
                response = _adapter.converterMedicoParaResponse(medico);
                response.msg = "Pesquisa realizada com sucesso!";
                return response;
            }
            catch (Exception)
            {

                response.msg = "Erro ao pesquisar o médico";
                return response;
            }
        }
    }
}
