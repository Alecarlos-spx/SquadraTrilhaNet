using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.DTO.Medico.AtualizarMedico
{
    public class AtualizarMedicoRequest
    {
        public string nome { get; set; }
        public string especialidade { get; set; }
        public string telefone { get; set; }
        public string crm { get; set; }
        public bool situacao { get; set; }
    }
}
