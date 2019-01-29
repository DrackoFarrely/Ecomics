using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEcomics.Models
{
    public class Usuario
    {
        public int Id_usuario { get; set; }
        public string Usu_nombre { get; set; }
        public string Usu_apellidos { get; set; }
        public string Usu_email { get; set; }
        public string Usu_user { get; set; }
        public string Usu_password { get; set; }

        public virtual Compra Compra { get; set; }
        public virtual Direccion Direccion { get; set; }
    }
}