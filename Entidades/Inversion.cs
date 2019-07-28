
using System.ComponentModel.DataAnnotations;


namespace Entidades
{
   public  class Inversion
    {
        [Key]
        public int InversionID { get; set; }
        public decimal Monto { get; set; }

        public Inversion()
        {
            InversionID = 0;
            Monto=0;
        }

        public Inversion(int inversionID, decimal monto)
        {
            InversionID = inversionID;
            Monto = monto;
        }
    }
}
