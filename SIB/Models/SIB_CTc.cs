using System;
namespace SIB.Models
{
    public class SIB_CTc
    {
        public int Id { get; set; }
        public int NoTarjeta { get; set; }
        public string  Banco { get; set; }
        public int LimiteCredito { get; set; }
        public DateTime FechaCorte { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
