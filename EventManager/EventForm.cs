using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EventManager.DataGateways;

namespace EventManager
{
    public partial class EventForm : Form
    {
        private Event _event = null;
        private MainForm _parent = null;
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

        public Event Event
        {
            get {return _event;}
        }

        public EventForm(MainForm parent, Mode formMode)            
        {
            try
            {
                InitializeComponent();
                _parent = parent;
                applyFormMode(formMode);
                initaliyePersonList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void initaliyePersonList()
        {
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
        
        public void loadEvent(Event e)
        {
            _event = e;

            if (_event != null)
            {
                cName.Text = _event.Name;
                cLoaction.Text = _event.Location;
                cDate.Value = _event.Date;
                cDeadline.Value = _event.Date;
                cPrice.Value = Convert.ToDecimal(_event.Price);
                cCv.Value = _event.Cv;
                cHired.Value = _event.Hired;
                cDescription.Text = _event.Description;
                cComments.Text = _event.Comment;
                cTarget.Value = _event.Target;
                cApp.Value = _event.Applications;
                cFeedback.Text = _event.Feedback;
                colorPanel.BackColor = _event.Color;
     
                fillPersonList();
                autosizePersonsColumns();
            }
        }

        public void saveEvent()
        {
            _event.Name = cName.Text;
            _event.Location = cLoaction.Text;
            _event.Date = cDate.Value;
            _event.Deadline = cDeadline.Value;
            _event.Price = Convert.ToDouble(cPrice.Value);
            _event.Cv = Convert.ToInt32(cCv.Value);
            _event.Hired = Convert.ToInt32(cHired.Value);
            _event.Description = cDescription.Text;
            _event.Comment = cComments.Text;
            _event.Target = Convert.ToInt32(cTarget.Value);
            _event.Applications = Convert.ToInt32(cApp.Value);
            _event.Feedback = cFeedback.Text;
            _event.Color = colorPanel.BackColor;
        }

        private void fillPersonList()
        {
            ePersons.Items.Clear();
            if (_event != null)
            {
                foreach (int pID in _event.Persons)
                {
                    Person person = _parent.Persons.Find(p => p.ID == pID);
                    if (person != null)
                        ePersons.AddObject(person);
                }
            }            
        }

        private void autosizePersonsColumns()
        {
            ePersons.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ePersons.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            colType.Width = 0;
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
                    _event = new Event();
                    break;
            }
        }

        private void setControlsEnabled(bool editable)
        {
            btnOk.Visible = editable;
            cDate.Enabled = editable;
            btnEdit.Visible = !editable;
            btnPAdd.Enabled = editable;
            btnPRemove.Enabled = editable;
            btnPEdit.Enabled = editable;

            foreach (Control c in this.Controls)
            {
                if ( !(c is Button) && !(c is Label))
                    c.Enabled = editable;                
            }
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                saveEvent();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Person p = (Person)ePersons.SelectedObject;
                if (p != null)
                {
                    PersonForm form = new PersonForm(PersonForm.Mode.EDIT);
                    form.loadPerson(p);
                    form.ShowDialog();

                    if (form.DialogResult == DialogResult.OK)
                    {
                        fillPersonList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Person p = (Person)ePersons.SelectedObject;
                if (p != null)
                {
                    string msg = "Delete person " + p.FName + " " + p.SName + "?";

                    if (MessageBox.Show(msg, "Delete person", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        ePersons.RemoveObject(p);
                        _event.Persons.Remove(p.ID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnPAdd_Click(object sender, EventArgs e)
        {
            try
            {
                PersonList list = new PersonList();
                list.fill(_parent.Persons);
                list.ShowDialog();

                Person p = list.get();
                if (p != null && !_event.Persons.Contains(p.ID))
                {
                    _event.Persons.Add(p.ID);
                    ePersons.AddObject(p);
                    autosizePersonsColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {
            DialogResult r = colorDialog.ShowDialog();
            if ( r == DialogResult.OK)
            {
                colorPanel.BackColor = colorDialog.Color;
            }
        }        
    }
}
