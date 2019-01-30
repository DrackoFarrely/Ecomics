using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebEcomics.Models;

namespace WebEcomics.Models.Infraestructura
{
    public class ContextoEcomics : DbContext
    {
        public ContextoEcomics (): base("conecte")
        {
        }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
      }
}