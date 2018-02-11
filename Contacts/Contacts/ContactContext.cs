using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class ContactContext:IOperation
    {
        private readonly List<IEntity> _contactList;

        public ContactContext()
        {
            _contactList = new List<IEntity>();
        }
        public void Add(IEntity entity)
        {
            _contactList.Add(entity);
        }

        public IEntity Get(int id)
        {
            return
                 _contactList.FirstOrDefault(en => en.ID == id);
        }

        public IEnumerable<IEntity> GetAll()
        {
            return 
                _contactList;
        }

        public void Remove(int id)
        {
            _contactList.Remove(Get(id));
        }
    }
}
