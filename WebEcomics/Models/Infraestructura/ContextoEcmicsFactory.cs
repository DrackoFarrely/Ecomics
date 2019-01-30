using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEcomics.Models.Infraestructura
{
    public class ContextoEcmicsFactory
    {
        static ContextoEcomics Contexto = null;
        internal static ContextoEcomics GetContext()
        {
            return Contexto ?? new ContextoEcomics();
        }

    }
}