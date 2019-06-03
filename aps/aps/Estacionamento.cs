using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aps
{
    public class Estacionamento:BaseClass
    {
        public Estacionamento(string criador):base(criador)
        {

        }
        public List<Dia> Calendario { get; set; }
        public List<Box> Boxes { get; set; }
        public List<string> Funcionarios { get; set; }

        public decimal getLucroDiario(DateTime Data) {
            return Calendario.Where(x => x.Data.ToString("dd-mm-yyyy") == Data.ToString("dd-mm-yyyy")).FirstOrDefault().Lucro;
        }
        public List<Box> listaBoxPorStatus(bool status) {
            return Boxes.Where(x => x.Ocupado == status).ToList();
        }
        public List<string> fecharDia() {
            var hoje = Calendario.Where(x => x.Data.ToString("dd-mm-yyyy") == DateTime.Now.ToString("dd-mm-yyyy")).FirstOrDefault();
            if(hoje == null)
            {
                return new List<string> { "Dia fechado" };
            }
            List<Bilhete> bilhetes = hoje.Bilhetes;

            return bilhetes.Where(b => b.Box.Ocupado == true).Select(y => y.Veiculo).ToList();
        }
    }
}
