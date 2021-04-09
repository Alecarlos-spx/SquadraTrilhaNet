using Aula2ExemploCrud.DTO.Medico.AdicionarMedico;


namespace Aula2ExemploCrud.Bordas_Interfaces.UseCases
{
    public interface IAdicionarMedicoUseCase
    {
        AdicionarMedicoResponse Executar(AdicionarMedicoRequest request);
    }
}
