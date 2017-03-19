using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModification : TestBase
    {

        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("new", "new");

            app.Contacts.Modify(1, newData);
            app.Navigator.OpenHomePage();
            app.Auth.LogOut();
        }


    }
}
