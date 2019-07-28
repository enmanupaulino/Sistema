using System;

using System.ComponentModel.DataAnnotations;


namespace Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloID { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public DateTime Fecha { get; set; }
        public int Vigencia { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Ganancia { get; set; }
        
        public Articulos()
        {
            ArticuloID = 0;
            Nombre = string.Empty;
            Marca = string.Empty;
            Fecha = DateTime.Now;
            Vigencia = 0;
            PrecioCompra = 0;
            PrecioVenta = 0;
            Ganancia = 0;
        }     
    }
}
