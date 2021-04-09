using Aula2ExemploCrud.Bordas_Interfaces.Adapter;
using Aula2ExemploCrud.DTO.Medico.AdicionarMedico;
using Aula2ExemploCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.Adapter
{
    public class AdicionarMedicoAdapter : IAdicionarMedicoAdapter
    {
        public Medico converterRequestParaMedico(AdicionarMedicoRequest request)
        {
            var novoMedico = new Medico();
            novoMedico.nome = request.nome;
            novoMedico.especialidade = request.especialidade;
            novoMedico.telefone = request.telefone;
            novoMedico.crm = request.crm;
            novoMedico.situacao = request.situacao;

            return novoMedico;

        }
    }
}

