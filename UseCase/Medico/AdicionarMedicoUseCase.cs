using Aula2ExemploCrud.Bordas___Interfaces.UseCases.Repositorio;
using Aula2ExemploCrud.Bordas_Interfaces.Adapter;
using Aula2ExemploCrud.Bordas_Interfaces.UseCases;
using Aula2ExemploCrud.DTO.Medico.AdicionarMedico;
using Aula2ExemploCrud.Validator.Medico;
using System;
using System.Collections.Generic;

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
            var validacao = new AdicionarMedicoRequestValidator();

            try
            {
                response = validacao.ValidarCamposAdicionarMedico(request);


                if (response.erros.Count > 0)
                {
                    response.msg.Add("Erro ao adicionar o medico");
                    return response;
                }

                var medicoAdicionar = _adapter.converterRequestParaMedico(request);
                _repositorioMedicos.Add(medicoAdicionar);
                response.msg.Add("Adicionado com sucesso");
                response.id = medicoAdicionar.id;
                return response;

            }
            catch (Exception)
            {

                response.msg.Add("Erro ao adicionar o medico");
                return response;
            }
            



        }
    }
}
