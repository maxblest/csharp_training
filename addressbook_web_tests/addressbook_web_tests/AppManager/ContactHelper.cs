using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {

        public ContactHelper(AppManager manager)
             : base(manager)
        {
        }

        public List<ContactData> GetContactList()
        {
            List<ContactData> contacts = new List<ContactData>();
            manager.Navigator.OpenHomePage();
            ICollection<IWebElement> elements = driver.FindElements(By.Name("entry"));

            foreach (IWebElement element in elements)
            {
                IList<IWebElement> cells = element.FindElements(By.TagName("td"));
                string firstname = cells[2].Text;
                string lastname = cells[1].Text;
                ContactData contact = new ContactData(lastname, firstname);
                contacts.Add(contact);
            }

            return contacts;
        }

        public ContactHelper Remove(int p)
        {
            SelectContact(p);
            ClickDelete();
            ConfirmDeletion();
            manager.Navigator.OpenHomePage();
            return this;
        }

        public ContactHelper Modify(int p, ContactData newData)
        {
            ClickEdit(p);
            FillContactForm(newData);
            UpdateContact();
            manager.Navigator.OpenHomePage();
            return this;
        }

        public ContactHelper Validate()
        {
            if (!IsElementPresent(By.Name("selected[]")))
            {
                ClickAddNew();
                FillContactForm(new ContactData("brandnew", "brandnew"));
                SubmitContact();
                manager.Navigator.OpenHomePage();
            }
            return this;
        }

        public ContactHelper Create(ContactData contact)
        {
            ClickAddNew();
            FillContactForm(contact);
            SubmitContact();
            manager.Navigator.OpenHomePage();
            return this;
        }

        public ContactHelper ClickDelete()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public ContactHelper ConfirmDeletion()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index+1) + "]")).Click();
            return this;
        }


        public ContactHelper ClickAddNew()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ContactHelper SubmitContact()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }


        public ContactHelper UpdateContact()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper ClickEdit(int index)
        {
            driver.FindElement(By.XPath("(//img[@alt='Edit'])[" + (index+1) + "]")).Click();
            return this;
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("lastname"), contact.Lastname);
            return this;
        }

    }
}
