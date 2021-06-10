using System;
namespace SIB.Models
{
    public class SIB_Ccuenta
    {
        public int Id { get; set; }
        public int NoCuenta { get; set; }
        public string Banco { get; set; }
        public string TipoCuenta { get; set; }
        public int Saldo { get; set; }
    }
}
