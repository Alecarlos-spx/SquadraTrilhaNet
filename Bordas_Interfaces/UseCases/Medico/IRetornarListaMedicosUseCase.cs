using Aula2ExemploCrud.DTO.Medico.RetornaListaMedicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.Bordas_Interfaces.UseCases
{
    public interface IRetornarListaMedicosUseCase
    {
        RetornarListaMedicosResponse Executar();
    }
}
