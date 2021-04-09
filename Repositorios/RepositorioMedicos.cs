using Aula2ExemploCrud.Bordas___Interfaces.UseCases.Repositorio;
using Aula2ExemploCrud.Context;
using Aula2ExemploCrud.DTO.Medico.AdicionarMedico;
using Aula2ExemploCrud.Entities;

namespace Aula2ExemploCrud.Repositorios
{
    public class RepositorioMedicos : IRepositorioMedicos
    {
        public readonly ContextData _context;

        public RepositorioMedicos(ContextData context)
        {
            _context = context;
        }

        public void Add(Medico request)
        {
            _context.medico.Add(request);
            _context.SaveChanges();
        }
    }
}
