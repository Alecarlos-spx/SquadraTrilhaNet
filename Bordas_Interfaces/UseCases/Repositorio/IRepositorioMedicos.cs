using Aula2ExemploCrud.DTO.Medico.AdicionarMedico;
using Aula2ExemploCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.Bordas___Interfaces.UseCases.Repositorio
{
    public interface IRepositorioMedicos
    {
        public void Add(Medico request);


    }
}
