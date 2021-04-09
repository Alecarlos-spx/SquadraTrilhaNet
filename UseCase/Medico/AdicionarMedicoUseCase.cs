using Aula2ExemploCrud.Bordas___Interfaces.UseCases.Repositorio;
using Aula2ExemploCrud.Bordas_Interfaces.Adapter;
using Aula2ExemploCrud.Bordas_Interfaces.UseCases;
using Aula2ExemploCrud.DTO.Medico.AdicionarMedico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.UseCase.Medico
{
    public class AdicionarMedicoUseCase : IAdicionarMedicoUseCase
    {
        private readonly IRepositorioMedicos _repositorioMedicos;
        private readonly IAdicionarMedicoAdapter _adapter;

        public AdicionarMedicoUseCase(IRepositorioMedicos repositorioMedicos, IAdicionarMedicoAdapter adapter)
        {
            _repositorioMedicos = repositorioMedicos;
            _adapter = adapter;
        }

        public AdicionarMedicoResponse Executar(AdicionarMedicoRequest request)
        {
            var response = new AdicionarMedicoResponse();

            try
            {
                var medicoAdicionar = _adapter.converterRequestParaMedico(request);
                _repositorioMedicos.Add(medicoAdicionar);
                response.msg = "Adicionado com sucesso";
                return response;

            }
            catch (Exception)
            {

                response.msg = "Erro ao adicionar o produto";
                return response;
            }
            



        }
    }
}
