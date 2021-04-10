using Aula2ExemploCrud.DTO.Medico.AtualizarMedico;

namespace Aula2ExemploCrud.Bordas_Interfaces.UseCases
{
    public interface IAtualizarMedicoUseCases
    {
        AtualizarMedicoResponse Executar(AtualizarMedicoRequest request, int id);
    }
}
