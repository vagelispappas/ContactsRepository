using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contacts;

namespace Contact.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ContactContext context = new ContactContext(new FakeContact());
            var entities = context.GetAll();
            Console.WriteLine(entities);
            foreach (var item in entities)
            {
                Console.WriteLine(item.ID);
            }
        }
    }

    public class FakeContact : IEntity
    {
        public int ID { get; private set; }

        int IEntity.ID
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }
    }
}
