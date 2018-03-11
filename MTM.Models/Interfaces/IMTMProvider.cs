using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTM.Models.Interfaces
{
    public interface IMTMProvider<T>
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetById(Guid Id);

        IQueryable<T> Create(T Entity);

        IQueryable<T> Update(T Entity);

        IQueryable<T> Delete(T Entity);
    }
}
