﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aps
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory f = new Factory();
            Bilhete b = f.GetInstance<Bilhete>("Main");
        }
    }
}
