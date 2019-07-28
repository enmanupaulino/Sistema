using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
namespace Entidades
{
   public  class Inversion
    {
        [Key]
        public int InversionID { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }


        public Inversion()
        {
            InversionID = 0;
            Monto=0;
            Fecha = DateTime.Now;
        }

        public Inversion(int inversionID, decimal monto, DateTime fecha)
        {
            InversionID = inversionID;
            Monto = monto;
            Fecha = fecha;
        }
    }
}
