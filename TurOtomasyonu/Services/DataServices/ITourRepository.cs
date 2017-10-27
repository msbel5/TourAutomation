using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Services.DataServices
{
    public interface ITourRepository
    {
        IList<Tour> SelectTourByDate(DateTime startDate, DateTime endDate,TourCategory selectedItem);
        
    }
}
