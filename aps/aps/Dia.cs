using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aps
{
    public class Dia: BaseClass
    {
        public Dia(string criador):base(criador)
        {

        }
        public DateTime Data { get; set; }
        public Decimal Lucro { get { return (Bilhetes==null) ? 0 : Bilhetes.Select(x => x.getValorTotal()).Sum(); } }    
        public List<Bilhete> Bilhetes { get; set; }

    }
}
