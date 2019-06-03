using System;
using System.Collections.Generic;
using System.Globalization;
using aps;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesLib
{
    [TestClass]
    public class UnitTest1
    {
        
        public UnitTest1()
        {
            TestgetLucroDiario();
            TestegetValorTotal();
        }


        [TestMethod]
        public void TestegetValorTotal()
        {
            try
            {
                decimal esperado1 = 10; // esperado apos uma hora 
                decimal esperado2 = 20;// esperado apos duas horas 

                List<Bilhete> bils = new List<Bilhete>();
                var horaEntrada = DateTime.Now;

                bils.Add(new Bilhete("TESTE")
                {
                    Box = new Box("TESTE")
                    {
                        Ocupado = true,
                        Numero = 1,
                        TipoVeiculo = "Carro",
                        ValorHora = 10
                    },
                    HoraEntrada = horaEntrada,
                    HoraSaida = horaEntrada.AddHours(1),
                    Veiculo = "Carro",
                    Identificador = "TESTE"
                });

                bils.Add(new Bilhete("TESTE")
                {
                    Box = new Box("TESTE")
                    {
                        Ocupado = true,
                        Numero = 2,
                        TipoVeiculo = "Carro",
                        ValorHora = 10
                    },
                    HoraEntrada = horaEntrada,
                    HoraSaida = horaEntrada.AddHours(2),
                    Veiculo = "Carro",
                    Identificador = "TESTE"
                });

                Assert.AreEqual(esperado1, bils[0].getValorTotal());
                Assert.AreEqual(esperado2, bils[1].getValorTotal());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            } 
           
        }
        [TestMethod]
        public void TestgetLucroDiario()
        {
            try
            {
                var data = DateTime.Now;
                Estacionamento e = new Estacionamento("TESTE");
                e.Calendario = new List<Dia>();
                e.Calendario.Add(new Dia("TESTE")
                {
                    Bilhetes = new List<Bilhete>(),
                    Data = data
                });

                e.Calendario[0].Bilhetes.Add(new Bilhete("TESTE")
                {
                    Box = new Box("TESTE")
                    {
                        Ocupado = true,
                        Numero = 2,
                        TipoVeiculo = "Carro",
                        ValorHora = 10
                    },
                    HoraEntrada = data,
                    HoraSaida = data.AddHours(3),
                    Identificador = "a",
                    Veiculo = "Carro"
                });


                e.Calendario.Add(new Dia("TESTE")
                {
                    Bilhetes = new List<Bilhete>(),
                    Data = data.AddDays(2)
                });

                Assert.AreEqual(20, e.getLucroDiario(data));

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
