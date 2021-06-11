using System;
namespace SIB.Models
{
    public class SIB_Servicios
    {
        public int Id { get; set; }
        public string TipoDeServicio { get; set; }
        public int IdServicio { get; set; }
        public int Saldo { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
