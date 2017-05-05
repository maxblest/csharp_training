using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    public class AddingContactsToGroupTests : AuthTestBase
    {
        [Test]
        public void TestAddingContactToGroup()
        {
            GroupData group = GroupData.GetAll()[0];
            List<ContactData> oldContactsList = group.GetContacts();
            ContactData contact = ContactData.GetAll().Except(oldContactsList).First();

            
            app.Contacts.AddContactToGroup(contact, group);

            List<ContactData> newContactsList = group.GetContacts();
            oldContactsList.Add(contact);
            oldContactsList.Sort();
            newContactsList.Sort();

            Assert.AreEqual(oldContactsList, newContactsList);
        }



        [Test]
        public void TestRemovingContactFromGroup()
        {
            GroupData group = GroupData.GetAll()[0];
            List<ContactData> oldContactsList = group.GetContacts();
            ContactData contact = ContactData.GetAll().Except(oldContactsList).First();

            app.Contacts.RemoveContactFromGroup(contact, group);

            List<ContactData> newContactsList = group.GetContacts();
            oldContactsList.Remove(contact);
            oldContactsList.Sort();
            newContactsList.Sort();

            Assert.AreEqual(oldContactsList, newContactsList);
        }

    }
}
