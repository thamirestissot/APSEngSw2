using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aps
{
    public class Box: BaseClass
    {
        public Box(string criador) : base(criador)
        {

        }
        public string TipoVeiculo { get; set; }
        public decimal ValorHora { get; set; }
        public int Numero { get; set; }
        public bool Ocupado { get; set; }
    }
}
