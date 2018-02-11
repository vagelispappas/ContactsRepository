using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Program
    {
        static IEnumerable<IEntity> TestCONTACTS()
        {
            List<Contact> randomCONTACTS = new List<Contact>
            {
                new Contact("Maria","Pappadopoulou",ContactType.Work),
                new Contact("Nikos","Nikolaoy",0)
            };

            return randomCONTACTS;
        }
        static void Main(string[] args)
        {
            ContactContext context = new ContactContext(new Contact("Vagelis", "Pappas", ContactType.CellPhone));
            Contact contact = new Contact("Maria", "Pappas", ContactType.Work);
            context.Add(contact);
            context.AddRange(TestCONTACTS());

            var contacts = context.GetAll();
            foreach (Contact item in contacts)
            {
                Console.WriteLine("Fullname: {0}", item.ContactDetails);
            }

            Console.ReadLine();
        }
    }
}
