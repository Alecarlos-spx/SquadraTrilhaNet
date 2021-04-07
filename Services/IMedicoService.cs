using Aula2ExemploCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.Services
{
    public interface IMedicoService
    {
        bool AdicionarMedico(Medico medico);
        List<Medico> RetornaListaMedicos();
        Medico RetornaMedicoId(int id);
        bool AtualizarMedico(Medico novoMedico);
        bool DeletarMedico(int id);

    }
}
