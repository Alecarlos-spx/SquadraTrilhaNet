using Aula2ExemploCrud.Bordas___Interfaces.UseCases.Repositorio;
using Aula2ExemploCrud.Context;
using Aula2ExemploCrud.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Aula2ExemploCrud.Repositorios
{
    public class RepositorioMedicos : IRepositorioMedicos
    {
        public readonly ContextData _context;

        public RepositorioMedicos(ContextData context)
        {
            _context = context;
        }

        public int Add(Medico request)
        {
            _context.medico.Add(request);
            _context.SaveChanges();
            return request.id;
        }


        public int Update(Medico request)
        {
            var local = _context.Set<Medico>().Local.Where(x => x.id == request.id).FirstOrDefault();
            if(local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
            //_context.Attach<Medico>(request);
          
            _context.medico.Update(request);
            _context.SaveChanges();
            return request.id;
        }
        public void Delete(int id)
        {
            var medico = _context.medico.Where(t => t.id == id).FirstOrDefault();
            _context.medico.Remove(medico);
            _context.SaveChanges();
        }

        public List<Medico> Get()
        {
            var medicoLista = _context.medico.ToList();
            return medicoLista;
        }

        public Medico GetId(int id)
        {
            var medico = _context.medico.Where(t => t.id == id).FirstOrDefault();
            return medico;
        }
    }
}
