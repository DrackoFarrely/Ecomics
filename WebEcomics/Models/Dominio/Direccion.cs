using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEcomics.Models
{
    public class Direccion
    {
        [ForeignKey("Usuario")]
        [Column(Order = 1)]
        public int Id_usuario { set; get; }
        public string Calle { set; get; }
        public string Numero { set; get; }
        public string Entre_calle1 { set; get; }
        public string Entre_calle2 { set; get; }
        public string Estado { set; get; }
        public string Municipio { set; get; }
        public string Ciudad { set; get; }
        public string Colonia { set; get; }
        public string Codigo_postal { set; get; }

        public virtual Usuario Usuario { set; get; }
    }
}