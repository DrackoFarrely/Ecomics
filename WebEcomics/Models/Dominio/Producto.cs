using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEcomics.Models
{
    public class Producto
    {
        [Key]
        public int ID { set; get; }

        [ForeignKey("Categoria")]
        [Column(Order = 1)]
        public string Id_Categoria { set; get; }

        [ForeignKey("Proveedor")]
        [Column(Order = 2)]

        public string Nombre_producto { set; get; }
        public int Id_Proveedor { set; get; }
        public string Descripcion { set; get; }
        public double Precio { set; get; }
        public double Costo { set; get; }
        public int Stockmax { set; get; }
        public int Stockmin { set; get; }
        public DateTime Fecha_reg { set; get; }


        public virtual Categorias Categoria { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}