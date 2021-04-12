using Aula2ExemploCrud.DTO.Medico.RetornaMedicoId;
using Aula2ExemploCrud.Entities;
namespace Aula2ExemploCrud.Bordas_Interfaces.Adapter
{
    public interface IRetornarMedicoIdAdapter
    {
        public Medico converterRequestParaMedico(RetornarMedicoIdRequest request);

        public RetornarMedicoIdResponse converterMedicoParaResponse(Medico medico);

    }
}
