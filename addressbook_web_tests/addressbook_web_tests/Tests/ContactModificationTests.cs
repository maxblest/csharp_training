using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModification : ContactTestBase
    {

        [Test]
        public void ContactModificationTest()
        {
            //ContactData newData = new ContactData("new", "new");

            app.Contacts.Validate();
            List<ContactData> oldContacts = ContactData.GetAll();
            app.Contacts.Modify(oldContacts[0]);
            app.Navigator.OpenHomePage();

            Assert.AreEqual(oldContacts.Count, app.Contacts.GetContactCount());
            List<ContactData> newContacts = ContactData.GetAll();
            //oldContacts[0].Firstname = newData.Firstname;
            //oldContacts[0].Lastname = newData.Lastname;
            //oldContacts.Sort();
            //newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

            app.Auth.LogOut();
        }


    }
}
