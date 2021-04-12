using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.DTO.Medico.RetornaMedicoId
{
    public class RetornarMedicoIdRequest
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string especialidade { get; set; }
        public string telefone { get; set; }
        public string crm { get; set; }
        public bool situacao { get; set; }

    }
}
