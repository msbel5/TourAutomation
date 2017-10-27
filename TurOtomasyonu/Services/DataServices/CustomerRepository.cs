using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Services.DataServices
{
    public class CustomerRepository : DatabaseOperation<Customer>, IRepository<Customer>
    {
        public CustomerRepository(ProjectContext context) : base(context)
        {
        }

        public void Add(Customer model)
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

        public IList<Customer> Select()
        {
            return _set.ToList();
        }

        public void Update(Customer model)
        {
            var entity = _set.Find(model.Id);
            _context.Entry(entity).CurrentValues.SetValues(model);
            _context.SaveChanges();
            var state = _context.Entry(entity).State;
        }

        
    }
}
