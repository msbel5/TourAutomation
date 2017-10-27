using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurOtomasyonu.Services.DataServices
{
    public interface IRepository<T> 
    {
        void Add(T model);
        void Delete(int id);
        void Update(T model);
        IList<T> Select();

    }
}
