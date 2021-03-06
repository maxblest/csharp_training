﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(AppManager manager)
            
            : base(manager)
    {
    }
    
    

        public void LogIn(AccountData account)
    {
        if (IsLoggedIn())
        {
            if (IsLoggedIn(account))
            {
                    return;
            }

                LogOut();
        }
        Type(By.Name("user"), account.Username);
        Type(By.Name("pass"), account.Password);
        driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();

    }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
            throw new NotImplementedException();
        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn()
                && getLoggetUserName() == account.Username;
        }

        public string getLoggetUserName()
        {
            string text  = driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text;
            return text.Substring(1, text.Length - 2);
        }

        public void LogOut()
        {
            if (IsLoggedIn())
            {
                driver.FindElement(By.LinkText("Logout")).Click();
            }
        }

    }
}


