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
            GroupData group = new GroupData("aaa", "bbb", "ccc");


            app.Groups.Create(group);
            app.Auth.LogOut();
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("","","");

            app.Groups.Create(group);
            app.Auth.LogOut();
        }

    }








       







 

       

 
    }

