using Aula2ExemploCrud.Bordas___Interfaces.UseCases.Repositorio;
using Aula2ExemploCrud.Bordas_Interfaces.Adapter;
using Aula2ExemploCrud.Bordas_Interfaces.UseCases;
using Aula2ExemploCrud.DTO.Medico.RetornaListaMedicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.UseCase.Medico
{
    public class RetornarListaMedicosUseCase : IRetornarListaMedicosUseCase
    {
        private readonly IRepositorioMedicos _repositorioMedicos;

        public RetornarListaMedicosUseCase(IRepositorioMedicos repositorioMedicos)
        {
            _repositorioMedicos = repositorioMedicos;
        }

        public RetornarListaMedicosResponse Executar()
        {
            var response = new RetornarListaMedicosResponse();

            try
            {
                response.medicos = _repositorioMedicos.Get();
                response.msg.Add("Lista de Médicos!");

                return response;
            }
            catch (Exception)
            {

                response.msg.Add("Erro ao listar os médicos!");
                return response;
            }
        }
    }
}
