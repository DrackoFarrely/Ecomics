using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEcomics.Models
{
    public class Detalle
    {

        public int id_compra { set; get; }

        public int id_producto { set; get; }
        public int Cantidad { set; get; }



        public virtual ICollection<Producto> Producto { get; set; }
        public virtual ICollection<Compra> Compra { get; set; }
    }
}