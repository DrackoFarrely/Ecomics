using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEcomics.Models.Infraestructura
{
    public class UnitofWork : IUnitofWork
    {
        private ContextoEcomics contexto = null;
        private ContextoEcomics Contexto
        {
            get
            {
                return contexto = contexto ?? ContextoEcmicsFactory.GetContext();
            }
        }
        public void Commit()
        {
            Contexto.SaveChanges();
        }
        public void Rollback()
        {
            
        }
    }
}