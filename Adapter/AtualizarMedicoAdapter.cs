using Aula2ExemploCrud.Bordas_Interfaces.Adapter;
using Aula2ExemploCrud.DTO.Medico.AtualizarMedico;
using Aula2ExemploCrud.Entities;

namespace Aula2ExemploCrud.Adapter
{
    public class AtualizarMedicoAdapter : IAtualizarMedicoAdapter
    {
        public Medico converterRequestParaMedico(AtualizarMedicoRequest request)
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

