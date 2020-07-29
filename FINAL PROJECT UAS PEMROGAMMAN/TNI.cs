using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class TNI
    {
        public string NIP { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }
}