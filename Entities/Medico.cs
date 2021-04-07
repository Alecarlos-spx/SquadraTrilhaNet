using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.Entities
{
    public enum periodo
    {
        manhã,
        tarde,
        noite
    }
    public class Medico
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }
        public string especialidade { get; set; }
        public string telefone { get; set; }
        public periodo periodoAtendimento { get; set; } 
        public string diasSemanaAtendimento { get; set; }
    }
}
