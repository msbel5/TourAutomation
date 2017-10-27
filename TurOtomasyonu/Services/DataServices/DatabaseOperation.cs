using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Services.DataServices
{
    public abstract class DatabaseOperation<T>:IDisposable where T:class
    {
        //Database Erişim Sınıfı

        protected ProjectContext _context; //dbcontex'imiz
        protected DbSet<T> _set; //DatabaseSetler
        protected bool _disposed = false;

        public DatabaseOperation(ProjectContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }

        private void Dispose(bool disposing)
        {

            if (disposing == true)
            {
                if (_disposed==false)
                {
                    _context.Dispose(); //database baglantıları kopartılıp ramden verilir temizler.
                    _disposed = true;
                    _context = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
