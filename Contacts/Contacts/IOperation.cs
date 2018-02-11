using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    interface IOperation
    {
        void Add(IEntity entity);
        void AddRange(IEnumerable<IEntity> entities);
        void Remove(int id);
        IEnumerable<IEntity> GetAll();
        IEntity Get(int id);
    }
}
