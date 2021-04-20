using BACK.Models;

namespace BACK.Data
{
    public interface IRepository
    {
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         bool SaveChanges();

         // CARDS
         Card[] GetAllCards();
         Card GetCardById(int cardId);
    }
}