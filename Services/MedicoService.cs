using Aula2ExemploCrud.Context;
using Aula2ExemploCrud.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2ExemploCrud.Services
{
    public class MedicoService : IMedicoService
    {

        private readonly ContextData _ContextData;

        public MedicoService(ContextData contextData)
        {
            _ContextData = contextData;
        }

        public async Task<bool> AdicionarMedico(Medico medico)
        {
            try
            {
                await _ContextData.medico.AddAsync(medico);
                await _ContextData.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
            

            return true;
        }

     


        public async Task<bool> AtualizarMedico(Medico novoMedico)
        {


            //_______________________________ Gerou erro --> resolvi o erro quando transformei os metodos em assychrono

            //_ContextData.Attach(novoMedico);
            //_ContextData.Entry<Medico>(novoMedico).State = EntityState.Modified;

            //________________________________


            try
            {
                //_____________________________ resolução com medoto sem ser assychrono
                //var local = _ContextData.Set<Medico>().Local.Where(t => t.id == novoMedico.id).FirstOrDefault();
                //_ContextData.Entry(local).State = EntityState.Detached;
                //_____________________________


                //_________________________________ sendo assychrono funcionou sem ter problema no Attach
                _ContextData.Attach(novoMedico);

                _ContextData.Update(novoMedico);

                await _ContextData.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<bool> DeletarMedico(int id)
        {

            try
            {
                var idMedico = _ContextData.medico.Where(t => t.id == id).FirstOrDefault();
                _ContextData.medico.Remove(idMedico);
                await _ContextData.SaveChangesAsync();

                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Medico>> RetornaListaMedicos()
        {
            return await _ContextData.medico.ToListAsync();
        }

        public async  Task<Medico> RetornaMedicoId(int id)
        {
            return await _ContextData.medico.Where(t => t.id == id).FirstOrDefaultAsync();
            
        }
    }
}
