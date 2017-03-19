﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreation : TestBase
    {

        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("aaa", "bbb");

            app.Contacts
                .ClickAddNew()
                .FillContactForm(contact);
            app.Auth.LogOut();
        }


    }
}
