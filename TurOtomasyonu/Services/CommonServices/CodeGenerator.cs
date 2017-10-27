using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurOtomasyonu.Services.CommonServices
{
    public static class CodeGenerator
    {
        public static string Generate(int defaultSize = 10)
        {
           return Guid.NewGuid().ToString().Replace("-", "").Substring(0, defaultSize);
        }
    }
}
