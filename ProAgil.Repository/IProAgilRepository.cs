using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface IProAgilRepository
    {
        //GERAL
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveChangesAsync();

         //EVENTOS
         Task<Evento[]> GetAllEventoAsync(bool includePalestrante);
         Task<Evento> GetAllEventoAsyncById(int EventoId, bool includePalestrantes);
         Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrantes);

         //PALESTRANTE
         Task<Palestrante[]> GetAllPalestranteAsync(bool includeEventos);
         Task<Palestrante> GetAllPalestranteAsyncById(int PalestranteId, bool includeEventos);
         Task<Palestrante[]> GetAllPalestranteAsyncByName(string name, bool includeEventos);
    }
}