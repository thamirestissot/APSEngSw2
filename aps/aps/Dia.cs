using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aps
{
    public class Dia
    {
        public DateTime Data { get; set; }
        public Decimal Lucro { get { return (Bilhetes==null) ? 0 : Bilhetes.Select(x => x.CalcularValorTotal()).Sum(); } }    
        public List<Bilhete> Bilhetes { get; set; }

    }
}
