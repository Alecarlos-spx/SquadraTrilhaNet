using Aula2ExemploCrud.DTO.Medico.DeletarMedico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.Bordas_Interfaces.UseCases
{
    public interface IDeletarMedicoUseCase
    {
        DeletarMedicoResponse Executar(DeletarMedicoRequest request);
    }
}
