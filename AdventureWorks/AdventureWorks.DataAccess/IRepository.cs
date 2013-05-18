using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DataAccess
{
    public interface IRepository
    {
        IQueryable<T> FindAll<T>() where T : class;
        T Find<T>(int id) where T : class;
    }
}
