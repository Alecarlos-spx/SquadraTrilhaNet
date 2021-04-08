using Aula2ExemploCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.Services
{
    public interface IMedicoService
    {
        Task<bool> AdicionarMedico(Medico medico);
        Task<List<Medico>> RetornaListaMedicos();
        Task<Medico> RetornaMedicoId(int id);
        Task<bool> AtualizarMedico(Medico novoMedico);
        Task<bool> DeletarMedico(int id);

    }
}
