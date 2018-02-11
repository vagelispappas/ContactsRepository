namespace Contacts
{
    public enum ContactType
    {
        Work = 1,
        CellPhone = 2,
        Home = 3
    }

    class Contact : IEntity
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private ContactType _contactType;

        public Contact()
        {
            
        }

        public Contact(string firstName, string lastName, ContactType contactType)
        {
            _firstName = firstName;
            _lastName = lastName;
            _contactType = contactType;
        }

        public string ContactDetails => $"{_firstName} -- {_lastName} -- {_contactType}";

        public int ID
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

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public ContactType ContactType
        {
            get
            {
                return _contactType;
            }
            set
            {
                _contactType = value;
            }
        }
    }
}
