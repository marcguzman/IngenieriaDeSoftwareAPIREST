using System;
namespace SIB.Models
{
    public class SIB_PagoTC
    {
        public int Id { get; set; }
        public int NoTarjeta { get; set; }
        public int Saldo { get; set; }
        public DateTime FechaLimitedePago { get; set; }
        public int PagoContado { get; set; }
        public int PagoMinimo { get; set; }

    }
}
