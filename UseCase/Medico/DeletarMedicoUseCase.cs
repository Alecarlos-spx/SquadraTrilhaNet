using Aula2ExemploCrud.Bordas___Interfaces.UseCases.Repositorio;
using Aula2ExemploCrud.Bordas_Interfaces.UseCases;
using Aula2ExemploCrud.DTO.Medico.DeletarMedico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.UseCase.Medico
{
    public class DeletarMedicoUseCase : IDeletarMedicoUseCase
    {
        private readonly IRepositorioMedicos _repositorioMedicos;

        public DeletarMedicoUseCase(IRepositorioMedicos repositorioMedicos)
        {
            _repositorioMedicos = repositorioMedicos;
        }

        public DeletarMedicoResponse Executar(DeletarMedicoRequest request)
        {
            var response = new DeletarMedicoResponse();

            try
            {
                var medico = _repositorioMedicos.GetId(request.id);
                if (medico == null)
                {
                    response.msg.Add("Erro ao excluir o médico!");
                    return response;
                }

                _repositorioMedicos.Delete(request.id);
                response.msg.Add("Excluido com sucesso!");
                return response;
            }
            catch (Exception)
            {

                response.msg.Add("Erro ao excluir o médico!");
                return response;

            }
        }
    }
}
