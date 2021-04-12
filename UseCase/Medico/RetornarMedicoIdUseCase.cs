using Aula2ExemploCrud.Bordas___Interfaces.UseCases.Repositorio;
using Aula2ExemploCrud.Bordas_Interfaces.Adapter;
using Aula2ExemploCrud.Bordas_Interfaces.UseCases;
using Aula2ExemploCrud.DTO.Medico.RetornaMedicoId;
using System;

namespace Aula2ExemploCrud.UseCase.Medico
{
    public class RetornarMedicoIdUseCase : IRetornarMedicoIdUseCase
    {
        private readonly IRepositorioMedicos _repositorioMedicos;
        private readonly IRetornarMedicoIdAdapter _adapter;

        public RetornarMedicoIdUseCase(IRepositorioMedicos repositorioMedicos, IRetornarMedicoIdAdapter adapter)
        {
            _repositorioMedicos = repositorioMedicos;
            _adapter = adapter;
        }

        public RetornarMedicoIdResponse Executar(RetornarMedicoIdRequest request)
        {
            var response = new RetornarMedicoIdResponse();

            try
            {
                var medico = _repositorioMedicos.GetId(request.id);
                if (medico == null)
                {
                    response.msg.Add("Erro ao pesquisar o médico");
                    return response;
                }
                response = _adapter.converterMedicoParaResponse(medico);
                response.msg.Add("Pesquisa realizada com sucesso!");
                return response;
            }
            catch (Exception)
            {

                response.msg.Add("Erro ao pesquisar o médico");
                return response;
            }
        }
    }
}
