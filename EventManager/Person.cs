using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager
{
    public class Person
    {
        public enum PersonType
        {
            CONTACT,
            RT,
            BL            
        }

        private int _id = -1;
        private string _fname = "";
        private string _sname = "";
        private string _company = "";
        private string _phone = "";
        private string _email = "";
        private PersonType _type = PersonType.CONTACT;

        public PersonType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FName
        {
            get { return _fname; }
            set { _fname = value; }
        }

        public string SName
        {
            get { return _sname; }
            set { _sname = value; }
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
