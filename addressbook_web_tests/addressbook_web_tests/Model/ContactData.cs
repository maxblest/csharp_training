﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
    private string firstname;
    private string lastname;

    public ContactData(string firstname, string lastname)
    {
        this.firstname = firstname;
        this.lastname = lastname;
    }


    public string Firstname
    {
        get
        {
            return firstname;
        }
        set
        {
            firstname = value;
        }
    }

    public string Lastname
    {
        get
        {
            return lastname;
        }
        set
        {
            lastname = value;
        }
    }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            string a = Firstname + Lastname;
            string b = other.Firstname + other.Lastname;


            return a.CompareTo(b);
        }


        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, null))
            {
                return true;
            }
            return Firstname == other.Firstname
                   && Lastname == other.Lastname;
        }

        public override int GetHashCode()
        {
            return Lastname.GetHashCode();
        }

        public override string ToString()
        {
            return "contactname=" + Firstname + Lastname;
        }
    }
}
