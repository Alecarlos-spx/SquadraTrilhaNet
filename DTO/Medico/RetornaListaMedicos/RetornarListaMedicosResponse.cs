using System.Collections.Generic;
using MedicoEntidade = Aula2ExemploCrud.Entities.Medico;

namespace Aula2ExemploCrud.DTO.Medico.RetornaListaMedicos
{
    public class RetornarListaMedicosResponse
    {
        public List<MedicoEntidade> medicos { get; set; } = new List<MedicoEntidade>();
        public List<string> msg { get; set; } = new List<string>();
    }
}
