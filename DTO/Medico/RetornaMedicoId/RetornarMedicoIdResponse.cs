using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.DTO.Medico.RetornaMedicoId
{
    public class RetornarMedicoIdResponse
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string especialidade { get; set; }
        public string telefone { get; set; }
        public string crm { get; set; }
        public bool situacao { get; set; }
        public List<string> msg { get; set; } = new List<string>();
    }
}
