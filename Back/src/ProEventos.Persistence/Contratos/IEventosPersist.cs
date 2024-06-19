using System.Threading.Tasks;
using ProEventos.Domain;
namespace ProEventos.Persistence
{
    public interface IEventosPersist
    {
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);
        Task<Evento> GetEventosByIdAsync(int EventoId, bool includePalestrantes);
    }
}