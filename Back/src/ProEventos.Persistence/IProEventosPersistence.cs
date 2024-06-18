using System.Threading.Tasks;
using ProEventos.Domain;
namespace ProEventos.Persistence
{
    public interface IProEventosPersistence
    {
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void DeleteRange<T>(T[] entity) where T: class;
        Task<bool> SaveChangesAsync();

        Task<Evento[]> GetAllEventosByTemaAync(string tema, bool includePalestrantes);
        Task<Evento[]> GetAllEventosAync(string tema, bool includePalestrantes);
        Task<Evento> GetEventosByIdAync(int EventoId, bool includePalestrantes);

        Task<Palestrante[]> GetAllPalestrantesByNomeAync(string nome, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAync(string nome, bool includeEventos);
        Task<Palestrante> GetPalestrantesByIdAync(int PalestranteId, bool includeEventos);

    }
}