﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModification : AuthTestBase
    {

        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("new", "new");

            app.Contacts.Validate();
            List<ContactData> oldContacts = app.Contacts.GetContactList();
            app.Contacts.Modify(0, newData);
            app.Navigator.OpenHomePage();

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].Firstname = newData.Firstname;
            oldContacts[0].Lastname = newData.Lastname;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

            app.Auth.LogOut();
        }


    }
}
