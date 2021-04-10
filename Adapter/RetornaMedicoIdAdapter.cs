using Aula2ExemploCrud.Bordas_Interfaces.Adapter;
using Aula2ExemploCrud.DTO.Medico.AdicionarMedico;
using Aula2ExemploCrud.DTO.Medico.RetornaMedicoId;
using Aula2ExemploCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.Adapter
{
    public class RetornaMedicoIdAdapter : IRetornaMedicoIdAdapter
    {
        public RetornaMedicoIdResponse converterMedicoParaResponse(Medico medico)
        {
            var response = new RetornaMedicoIdResponse();
            response.id = medico.id;
            response.nome = medico.nome;
            response.especialidade = medico.especialidade;
            response.telefone = medico.telefone;
            response.crm = medico.crm;
            response.situacao = medico.situacao;

            

            return response;
        }

        public Medico converterRequestParaMedico(RetornaMedicoIdRequest request)
        {
            var MedicoPorId = new Medico();
            MedicoPorId.id = request.id;
            MedicoPorId.nome = request.nome;
            MedicoPorId.especialidade = request.especialidade;
            MedicoPorId.telefone = request.telefone;
            MedicoPorId.crm = request.crm;
            MedicoPorId.situacao = request.situacao;

            return MedicoPorId;

        }
    }
}

