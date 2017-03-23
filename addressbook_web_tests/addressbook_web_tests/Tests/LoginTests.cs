﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {

        [Test]
        public void LoginWithValidCredentials()
        {
            
            app.Auth.LogOut();

            AccountData account = new AccountData("admin", "secret");

            app.Auth.LogIn(account);
            Assert.IsTrue(app.Auth.IsLoggedIn(account));

        }

        [Test]
        public void LoginWithInvalidCredentials()
        {

            app.Auth.LogOut();

            AccountData account = new AccountData("admin", "123456");

            app.Auth.LogIn(account);
            Assert.IsFalse(app.Auth.IsLoggedIn(account));

        }
    }
}
