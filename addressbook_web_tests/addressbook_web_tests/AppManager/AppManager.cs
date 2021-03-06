﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace WebAddressbookTests
{
    public class AppManager
    {
        protected IWebDriver driver;
        public string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        private static ThreadLocal<AppManager> app = new ThreadLocal<AppManager>();

        private AppManager()
        {
            driver = new FirefoxDriver(new FirefoxBinary("C:\\Program Files\\Mozilla Firefox\\firefox.exe"), new FirefoxProfile());
            baseURL = "http://localhost/";

            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        ~AppManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public static AppManager GetInstance()
        {
            if (! app.IsValueCreated)
            {
                AppManager newInstance = new AppManager();
                newInstance.Navigator.OpenHomePage();
                app.Value = newInstance;

            }
            return app.Value;
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }


        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }

        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }

        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }

        }

        public ContactHelper Contacts
        {
            get
            {
                return contactHelper;
            }

        }

    }
}
