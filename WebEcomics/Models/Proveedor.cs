using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEcomics.Models
{
    public class Proveedor
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        [ForeignKey("Categoria")]
        [Column(Order = 1)]
        public string Id_categoria { get; set; }
        [ForeignKey("Proveedor")]
        [Column(Order = 1)]
        public int Id_proveedor { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public double Costo { get; set; }
        public int Stockmax { get; set; }
        public int Stockmin { get; set; }
        public DateTime Fecha_registro { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual Proveedor Proveedor { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
    }
}