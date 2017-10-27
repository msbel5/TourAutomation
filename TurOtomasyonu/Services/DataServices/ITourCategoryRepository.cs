using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Services.DataServices
{
    public interface ITourCategoryRepository
    {
        IList<TourCategory> SelectTopCategories();
        IList<TourCategory> SelectSubCategoriesById(int TopCategoryId);
    }
}
