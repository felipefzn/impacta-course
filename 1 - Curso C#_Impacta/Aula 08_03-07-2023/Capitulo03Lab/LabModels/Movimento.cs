﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabModels
{
    public class Movimento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Historico { get; set; }
        public Operacoes Operacao { get; set; }
        public double Valor { get; set; }
        public override string ToString() 
        {
            return string.Format("{0:dd/MM/yyyy} {1,-10} {2,10:N2}",
                Data, Historico, Valor);
        }
    }
}
