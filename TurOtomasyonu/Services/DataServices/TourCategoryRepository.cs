using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Services.DataServices
{
    public class TourCategoryRepository :DatabaseOperation<TourCategory>, IRepository<TourCategory>,ITourCategoryRepository
    {
        public TourCategoryRepository(ProjectContext context) : base(context)
        {
        }

        public void Add(TourCategory model)
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

        public IList<TourCategory> Select()
        {
            return _set.ToList();
        }

        public IList<TourCategory> SelectSubCategoriesById(int TopCategoryId)
        {
            return _set.Where(x => x.TopCategoryId == TopCategoryId).ToList();
        }

        public IList<TourCategory> SelectTopCategories()
        {
            return _set.Where(x => x.TopCategoryId == null && x.SubCategories.Count> 0).ToList();
        }

        public void Update(TourCategory model)
        {
            var entity = _set.Find(model.Id);
            _context.Entry(entity).CurrentValues.SetValues(model);
            _context.SaveChanges();
            var state = _context.Entry(entity).State;
        }
    }
}
