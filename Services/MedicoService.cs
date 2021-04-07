using Aula2ExemploCrud.Context;
using Aula2ExemploCrud.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Aula2ExemploCrud.Services
{
    public class MedicoService : IMedicoService
    {

        private readonly ContextData _ContextData;

        public MedicoService(ContextData contextData)
        {
            _ContextData = contextData;
        }

        public bool AdicionarMedico(Medico medico)
        {
            _ContextData.medico.Add(medico);
            _ContextData.SaveChanges();

            return true;
        }

        public bool AtualizarMedico(Medico novoMedico)
        {
            _ContextData.medico.Attach(novoMedico);
            _ContextData.Entry(novoMedico).State = EntityState.Modified;
            _ContextData.SaveChanges();
            return true;

        }

        public bool DeletarMedico(int id)
        {
            var idMedico = _ContextData.medico.Where(t => t.id == id).FirstOrDefault();
            _ContextData.medico.Remove(idMedico);
            _ContextData.SaveChanges();

            return true;
        }

        public List<Medico> RetornaListaMedicos()
        {
            return _ContextData.medico.ToList();
        }

        public Medico RetornaMedicoId(int id)
        {
            return _ContextData.medico.Where(t => t.id == id).FirstOrDefault();
            
        }
    }
}
