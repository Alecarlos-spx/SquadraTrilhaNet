using Aula2ExemploCrud.DTO.Medico.AdicionarMedico;
using Aula2ExemploCrud.Entities;
namespace Aula2ExemploCrud.Bordas_Interfaces.Adapter
{
    public interface IAdicionarMedicoAdapter
    {
        public Medico converterRequestParaMedico(AdicionarMedicoRequest request);
    }
}
