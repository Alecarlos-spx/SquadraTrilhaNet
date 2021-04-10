using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.Entities
{
  
    public class Medico
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string especialidade { get; set; }
        public string telefone { get; set; }
        public string crm { get; set; }
        public bool situacao { get; set; }


    }
}
