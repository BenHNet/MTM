using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTM.Models.Interfaces
{
    public interface IMTMProvider<T>
    {
        IQueryable<T> GetAll();

        T GetById(Guid Id);

        T Create(T Entity);

        T Update(T Entity);

        int Delete(Guid Id);
    }
}
