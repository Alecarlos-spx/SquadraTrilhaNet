using Aula2ExemploCrud.Entities;
using System.Collections.Generic;

namespace Aula2ExemploCrud.Bordas___Interfaces.UseCases.Repositorio
{
    public interface IRepositorioMedicos
    {
        public int Add(Medico request);
        public int Update(Medico request);
        public void Delete(int request);
        public Medico GetId(int request);
        public List<Medico> Get();





    }
}
