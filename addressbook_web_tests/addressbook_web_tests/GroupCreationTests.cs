using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
      

        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            LogIn(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            FillOutGroupForm(new GroupData("aaa", "bbb", "ccc"));
            SubmitGroupCreation();
            ReturnToGroupsPage();
            LogOut();
        }







       







 

       

 
    }
}
