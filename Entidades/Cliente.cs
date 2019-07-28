﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        public string NombreCliente { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }


        public Cliente()
        {
            ClienteID = 0;
            NombreCliente = string.Empty;
            Cedula= string.Empty;
            Direccion= string.Empty;
            Telefono= string.Empty;
            Fecha = DateTime.Now;
            Total =0;
        }
    }
}
