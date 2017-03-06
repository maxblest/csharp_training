﻿using System;
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
            GroupData group = new WebAddressbookTests.GroupData("aaa");
            group.Header = "bbb";
            group.Footer = "ccc";
            SubmitGroupCreation();
            ReturnToGroupsPage();
            LogOut();
        }







       







 

       

 
    }
}
