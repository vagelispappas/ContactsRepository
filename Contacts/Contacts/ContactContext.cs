using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class ContactContext : IOperation
    {
        private readonly List<IEntity> _contactList = new List<IEntity>();

        public ContactContext(IEntity entity)
        {
            if (entity != null)
            {
                entity.ID = _contactList.Count + 1;
            }
            _contactList.Add(entity);
            _contactList = GetAll().ToList();
        }

        public ContactContext(IEnumerable<IEntity> entities)
        {
            _contactList.AddRange(entities);
        }

        public void Add(IEntity entity)
        {
            if (entity != null)
                entity.ID = _contactList.Count + 1;

            _contactList.Add(entity);
        }

        public void AddRange(IEnumerable<IEntity> entities)
        {
            if (entities.ToList().Count != 0)
            {
                foreach (var item in entities.ToList())
                {
                    item.ID = _contactList.Count + 1;
                    _contactList.Add(item);
                }
            }
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
