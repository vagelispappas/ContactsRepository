using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public enum ContactType
    {
        Work =1,
        CellPhone = 2,
        Home = 3
    }

    class Contact:IEntity
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private ContactType _contactType;

        public Contact()
        { 

        }

        public Contact(int id, string firstName, string lastName, ContactType contactType)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _contactType = contactType;
        }

        public string FullName => $"{_firstName} {_lastName}";

        int IEntity.ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
}
