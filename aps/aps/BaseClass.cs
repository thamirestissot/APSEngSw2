using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aps
{
    public class BaseClass
    {
        public string CriadoPor { get; set; }
        public BaseClass(string CriadoPor)
        {
            this.CriadoPor = CriadoPor;
        }
    }
}
