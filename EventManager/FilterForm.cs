using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventManager
{
    public partial class FilterForm : Form
    {
        private List<Person> _persons;

        public List<int> Attendees
        {
            get 
            {
                List<int> attFilter = new List<int>();
                foreach (String astr in atendeeList.CheckedItems)
                {
                    String[] arr = astr.Split(',');
                    Person per = _persons.Find(p => p.SName == arr[0] && p.FName == arr[1]);
                    if (per != null) attFilter.Add(per.ID);
                }
                return attFilter;
            }
        }

        public FilterForm(List<Person> persons)
        {
            InitializeComponent();
            _persons = persons;
            foreach (Person p in _persons)
            {
                atendeeList.Items.Add(p.SName + "," + p.FName);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
