using System.Collections.Generic;
using MedicoEntidade = Aula2ExemploCrud.Entities.Medico;

namespace Aula2ExemploCrud.DTO.Medico.RetornaListaMedicos
{
    public class RetornarListaMedicosResponse
    {
        public List<MedicoEntidade> medicos { get; set; }
        public string msg { get; set; }
    }
}
