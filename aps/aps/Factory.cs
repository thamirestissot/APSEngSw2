using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aps
{
    public class Factory
    {
        public T GetInstance<T>(string Criador)
        {
            var o = Activator.CreateInstance(typeof(T), new object[] { Criador });
            return (T)o;
        }
    }
}
