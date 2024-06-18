using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public class ProEventosPersistence : IProEventosPersistence
    {

        private readonly ProEventosContext _context;
        public ProEventosPersistence(ProEventosContext context){
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
             _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entity) where T : class
        {
            _context.RemoveRange(entity);
        }

        public void Update<T>(T entity) where T : class
        {
           _context.Update(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
           return (await _context.SaveChangesAsync()) > 0;
        }

        public Task<Evento[]> GetAllEventosAync(string tema, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemaAync(string tema, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesAync(string nome, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByNomeAync(string nome, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Evento> GetEventosByIdAync(int EventoId, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante> GetPalestrantesByIdAync(int PalestranteId, bool includeEventos)
        {
            throw new NotImplementedException();
        }



    }
}