using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Services.DataServices
{
    public class VoteRepository : DatabaseOperation<Vote>, IRepository<Vote>
    {
        public VoteRepository(ProjectContext context) : base(context)
        {

        }
        public void Add(Vote model)
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

        public IList<Vote> Select()
        {
            return _set.ToList();
        }

        public void Update(Vote model)
        {
            var entity = _set.Find(model.ID);
            _context.Entry(entity).CurrentValues.SetValues(model);
            _context.SaveChanges();
            var state = _context.Entry(entity).State;
        }
    }
}
