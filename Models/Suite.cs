using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Threading.Tasks;

namespace HOSPEDAGEM_DE_HOTEL.Models
{
    public class Suite
    {
        public Suite(string TipoDeSuite_, int Capacidade_, decimal ValorDaDiaria_)
        {TipoDeSuite = TipoDeSuite_; Capacidade = Capacidade_; ValorDaDiaria = ValorDaDiaria_;}

        public string TipoDeSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDaDiaria { get; set; }
        

    }
}