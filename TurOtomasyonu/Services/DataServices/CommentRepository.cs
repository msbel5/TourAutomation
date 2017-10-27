using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Services.DataServices
{
    public class CommentRepository : DatabaseOperation<Comment>, IRepository<Comment>
    {
        public CommentRepository(ProjectContext context) : base(context)
        {

        }
        public void Add(Comment model)
        {
            _set.Add(model);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _set.Find(id);
            _set.Remove(entity);
            _context.SaveChanges();
        }

        public IList<Comment> Select()
        {
            return _set.ToList();
        }

        public void Update(Comment model)
        {
            var entity = _set.Find(model.ID);
            _context.Entry(entity).CurrentValues.SetValues(model);
            _context.SaveChanges();
            var state = _context.Entry(entity).State;
        }
    }
}
