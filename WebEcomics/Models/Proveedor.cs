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
        public string Compania { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}