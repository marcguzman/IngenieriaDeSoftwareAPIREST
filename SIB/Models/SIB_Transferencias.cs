using System;
namespace SIB.Models
{
    public class SIB_Transferencias
    {
        public int Id { get; set; }
        public int NoCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public string Banco { get; set; }
        public string TipoTransferencia { get; set; }
        public DateTime FechaTransferencia { get; set; }
        public int Monto { get; set; }
    }
}
