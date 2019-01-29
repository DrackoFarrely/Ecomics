using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEcomics.Models
{
    public class Categorias
    {
        public string Id { get; set; }
        public string nombre_cat { get; set; }

        public ICollection<Producto> productos;
    }    
}