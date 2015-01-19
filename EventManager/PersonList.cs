using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace EventManager
{
    public partial class PersonList : Form
    {
        public PersonList()
        {
            InitializeComponent();
            
            colType.AspectToStringConverter = delegate(object obj)
            {
                Person.PersonType p = (Person.PersonType)obj;
                string ret = "";

                switch (p)
                {
                    case Person.PersonType.CONTACT: ret = "Contact person"; break;
                    case Person.PersonType.RT: ret = "Recruitment team"; break;
                    case Person.PersonType.BL: ret = "Buissness Line contact"; break;
                };

                return ret;
            };
        }

        public ObjectListView Persons
        {
            get { return ePersons; }
        }

        public void fill(List<Person> persons)
        {
            ePersons.AddObjects(persons);

            ePersons.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ePersons.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            colType.Width = 0;
        }

        public Person get()
        {
            return (Person)ePersons.SelectedObject;
        }

        private void ePersons_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }

}
