using System;
using System.Linq;
using BACK.Models;
using Microsoft.EntityFrameworkCore;

namespace BACK.Data
{
    public class Repository : IRepository
    {
        private readonly KanbanContext _context;

        public Repository(KanbanContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public Card[] GetAllCards()
        {
            IQueryable<Card> query = _context.Cards;

            query = query.AsNoTracking().OrderBy(c => c.Id);

            return query.ToArray();
        }

        public Card GetCardById(int cardId)
        {
            IQueryable<Card> query = _context.Cards;

            query = query.AsNoTracking()
                         .OrderBy(c => c.Id)
                         .Where(c => c.Id == cardId);

            return query.FirstOrDefault();
        }
    }
}