using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.DTO.Medico.AtualizarMedico
{
    public class AtualizarMedicoResponse
    {
        public List<string> msg { get; set; } = new List<string>();

        public List<string> erros { get; set; } = new List<string>();
        public int id { get; set; }
    }
}
