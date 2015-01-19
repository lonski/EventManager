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
    public partial class PersonForm : Form
    {
        private Person _person = null;        
        private Mode _mode = Mode.VIEW;
        public enum Mode
        {
            VIEW,
            EDIT,
            ADD
        }

        public Mode FormMode
        {
            get { return _mode; }
        }

        public Person Person
        {
            get { return _person; }
        }
        
        public PersonForm(Mode formMode)            
        {           
            InitializeComponent();            
            applyFormMode(formMode);
        }

        public void loadPerson(Person p)
        {
            _person = p;

            if (_person != null)
            {
                cFName.Text = _person.FName;
                cSName.Text = _person.SName;
                cCompany.Text = _person.Company;
                cPhone.Text = _person.Phone;
                cEmail.Text = _person.Email;
                cType.SelectedIndex = (int)_person.Type;
            }
        }

        public void savePerson()
        {
            _person.FName = cFName.Text;
            _person.SName = cSName.Text;
            _person.Company = cCompany.Text;
            _person.Phone = cPhone.Text;
            _person.Email = cEmail.Text;
            _person.Type = (Person.PersonType)cType.SelectedIndex;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void applyFormMode(Mode mode)
        {
            _mode = mode;
            switch (_mode)
            {
                case Mode.VIEW:
                    setControlsEnabled(false);
                    break;
                case Mode.EDIT:
                    setControlsEnabled(true);
                    break;
                case Mode.ADD:
                    setControlsEnabled(true);
                    break;
            }
        }

        private void setControlsEnabled(bool editable)
        {
            btnOk.Visible = editable;
            btnEdit.Visible = !editable;
            foreach (Control c in this.Controls)
            {
                if (!(c is Button) && !(c is Label))
                    c.Enabled = editable;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    if (_mode == Mode.ADD)
                    {
                        _person = new Person();
                        savePerson();
                    }
                    else if (_mode == Mode.EDIT)
                    {
                        savePerson();
                    }

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }              
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                _mode = Mode.EDIT;
                setControlsEnabled(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }  
        }

        private bool validate()
        {
            if (cType.Text.Equals(""))
            {
                MessageBox.Show("Choose person type!",
                                "Invalid field value",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
