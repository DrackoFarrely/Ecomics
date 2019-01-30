using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebEcomics.Models;
using System.Linq.Expressions;

namespace WebEcomics.Models
{
    public interface IUsuario
    {
        IQueryable<Usuario> GetUsuarios();
        void Create(Usuario entity);
        void Update(Usuario entity);
        void Delete(int id);
        Usuario GetUsuario(int id);
        IQueryable<Usuario>FindBy(Expression<Func<Usuario, bool>>condition);
    }
}
