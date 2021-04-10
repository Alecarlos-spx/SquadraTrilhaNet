using Aula2ExemploCrud.DTO.Medico.RetornaMedicoId;
using Aula2ExemploCrud.Entities;
namespace Aula2ExemploCrud.Bordas_Interfaces.Adapter
{
    public interface IRetornaMedicoIdAdapter
    {
        public Medico converterRequestParaMedico(RetornaMedicoIdRequest request);

        public RetornaMedicoIdResponse converterMedicoParaResponse(Medico medico);

    }
}
