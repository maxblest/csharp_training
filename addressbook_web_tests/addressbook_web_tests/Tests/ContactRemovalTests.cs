using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemoval : AuthTestBase
    {

        [Test]
        public void ContactRemovalTest()
        {
            app.Contacts.Validate();
            app.Contacts.Remove(1);
            app.Auth.LogOut();
        }


    }
}
