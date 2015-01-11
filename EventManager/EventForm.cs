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

        public EventForm(MainForm parent, Mode formMode)            
        {           
            InitializeComponent();
            _parent = parent;
            applyFormMode(formMode);
        }
        
        public void loadEvent(Event e)
        {
            _event = e;

            if (_event != null)
            {
                cName.Text = _event.Name;
                cLoaction.Text = _event.Location;
                cDate.Value = _event.Date;
                cDate.MinDate = cDate.MaxDate = _event.Date;
                cPrice.Value = Convert.ToDecimal(_event.Price);
                cCv.Value = _event.Cv;
                cHired.Value = _event.Hired;
                cDescription.Text = _event.Description;
                cComments.Text = _event.Comment;
            }
        }

        public void saveEvent()
        {
            _event.Name = cName.Text;
            _event.Location = cLoaction.Text;
            _event.Date = cDate.Value;
            _event.Price = Convert.ToDouble(cPrice.Value);
            _event.Cv = Convert.ToInt32(cCv.Value);
            _event.Hired = Convert.ToInt32(cHired.Value);
            _event.Description = cDescription.Text;
            _event.Comment = cComments.Text;

            _parent.EventGateway.write(_event);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void applyFormMode(Mode mode)
        {
            _mode = mode;
            switch (_mode)
            {
                case Mode.VIEW:
                    setFormEditable(false);
                    break;
                case Mode.EDIT:
                    setFormEditable(true);
                    break;
                case Mode.ADD:
                    setFormEditable(true);
                    break;
            }
        }

        private void setFormEditable(bool editable)
        {
            btnOk.Visible = editable;
            cDate.Enabled = editable;
            foreach (Control c in this.Controls)
            {
                if ( !(c is Button) && !(c is Label))
                    c.Enabled = editable;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.ADD)
            {
                _event = new Event();
                saveEvent();
                _parent.addNewEvent(_event);
            }
            else if (_mode == Mode.EDIT)
            {
                saveEvent();                
                _parent.populate();
            }
                        
            Close();
        }
        
    }
}
