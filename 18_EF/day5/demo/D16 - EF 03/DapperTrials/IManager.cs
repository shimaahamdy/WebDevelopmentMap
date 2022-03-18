using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTrials
{
    public interface IManager<T>
    {
        bool Add(T item);
        bool Delete (int ID);
        List<T> GetAll();
        T GetByID (int id);
        bool Update(T item);
    }
}
