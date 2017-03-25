using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {


        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("zzz", null, null);

            app.Navigator.GoToGroupsPage();
            app.Groups.Validate();
            app.Groups.Modify(1, newData);
            app.Auth.LogOut();

        }
    }
}
