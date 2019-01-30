using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebEcomics.Models;

namespace WebEcomics.Models
{
    public interface IDireccion
    {
        IQueryable<Direccion> GetAll();
        void Create(Direccion entity);
        void Update(Direccion entity);
        void Delete(int id);
        Direccion GetById(int id);
        IQueryable<Direccion> FindBy(Expression<Func<Direccion, bool>> condition);
    }
}
