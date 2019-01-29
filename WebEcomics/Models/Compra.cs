using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEcomics.Models
{
    public class Compra
    {

        public int Idcompra { get; set; }
        public int Id_usuario { get; set; }
        public DateTime fecha { get; set; }
        public double totalcompra { get; set; }

        public virtual Usuario Usuario { get; set; }



    }
}