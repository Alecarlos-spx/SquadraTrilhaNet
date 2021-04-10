using Aula2ExemploCrud.DTO.Medico.AtualizarMedico;
using Aula2ExemploCrud.Entities;
namespace Aula2ExemploCrud.Bordas_Interfaces.Adapter
{
    public interface IAtualizarMedicoAdapter
    {
        public Medico converterRequestParaMedico(AtualizarMedicoRequest request);
    }
}
