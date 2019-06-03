using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aps
{
    public class Bilhete:BaseClass
    {
        public Bilhete(string criador):base(criador)
        {

        }
        public string Identificador { get; set; }
        public string Veiculo { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        private decimal ValorTotal { get; set; }
        public Box Box {get; set;}

        public decimal getValorTotal()
        {
            ValorTotal = Box.ValorHora * ((decimal)HoraSaida.Subtract(HoraEntrada).TotalHours);
            return ValorTotal;
        }
    }

}
