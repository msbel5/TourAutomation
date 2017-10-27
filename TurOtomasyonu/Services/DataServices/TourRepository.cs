using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;
using TurOtomasyonu.Services.InfrastructureService;

namespace TurOtomasyonu.Services.DataServices
{
    public class TourRepository :DatabaseOperation<Tour>,IRepository<Tour>,ITourRepository
    {
        IInfraService infraService;

        public TourRepository(ProjectContext context) : base(context)
        {
           
        }

        public TourRepository(IInfraService service):this(new ProjectContext())
        {
            infraService = service;
        }

        public void Add(Tour model)
        {
            _set.Add(model);
        }

        public void Delete(int id)
        {
            var  entity = _set.Find(id);
            _set.Remove(entity);
            _context.SaveChanges();
        }

        public IList<Tour> Select()
        {
            return _set.ToList();
        }

        public IList<Tour> SelectTourByDate(DateTime startDate, DateTime endDate, TourCategory selectedItem)
        {

            return _set.Where(x => x.StartDate >= startDate && x.EndDate <= endDate && ((x.CategoryId==selectedItem.Id) || (x.CategoryId == selectedItem.TopCategoryId))).ToList();
        }

        public void Update(Tour model)
        {
            var entity = _set.Find(model.Id);
            _context.Entry(entity).CurrentValues.SetValues(model);
            _context.SaveChanges();
            var state = _context.Entry(entity).State;
        }

        public void Pay(IList<Customer> cs,Tour t)
        {
           ((PaymentService)infraService).Pay(cs,t);
        }
    }
}
