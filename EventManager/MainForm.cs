using EventManager.DataGateways;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace EventManager
{
    public partial class MainForm : Form
    {
        private bool _dbOK = false;
        private DateTime _calDate = new DateTime(2015, 1, 1);
        
        private EventGateway _eventGateway = new EventGateway();
        private PersonGateway _personsGateway = new PersonGateway();

        private List<Event> _events = null;
        private List<Person> _persons = null;        
        private List<CalendarItem> _calendarItems = new List<CalendarItem>();
        
        public MainForm()
        {
            try
            {
                InitializeComponent();
                initalizePersonList();
                updateCalendarPeriod();

                tabControl.ItemSize = new Size(0, 1);

                loadAllData();
                if (!_dbOK) itmSettings_Click(this, null);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void initalizePersonList()
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

        private void applySettings()
        {
            _eventGateway.DBFile = Properties.Settings.Default.DatabasePath;
            _personsGateway.DBFile = Properties.Settings.Default.DatabasePath;
        }

        private void loadAllData()
        {
            try
            {
                fetchEvents();
                fetchPersons();
                initalizeEventList();                
                reloadCalendarItems();
                populateEvents();
                populatePersons();
                _dbOK = true;
            }
            catch (System.Data.SQLite.SQLiteException sqlEx)
            {
                _dbOK = false;
                MessageBox.Show("Can not fetch data from database: " + Properties.Settings.Default.DatabasePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Person> Persons
        {
            get { return _persons; }
        }

        public List<Event> Events
        {
            get { return _events; }
        }

        public void addNewPerson(Person p)
        {
            _personsGateway.write(p);
            _persons.Add(p);
            populatePersons();
        }
        
        public void deletePerson(Person p)
        {            
            personList.RemoveObject(p);
            _personsGateway.erase(p);
            Event evt = _events.Find(e => e.Persons.Contains(p.ID));
            if ( evt != null ) evt.Persons.Remove(p.ID);
            _persons.Remove(p);            
        }

        public void addNewEvent(Event e)
        {
            _events.Add(e);
            populateEvents();
        }

        public void deleteEvent(Event e)
        {
            _eventGateway.erase(e);

            fetchEvents();
            reloadCalendarItems();
            populateEvents();
        }

        public void populateEvents()
        {
            reloadCalendarItems();
            populateCalendar();
            populateEventList();
        }

        public void populatePersons()
        {
            personList.Items.Clear();
            personList.AddObjects(_persons);
            personList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            personList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            colType.Width = 0;
        }

        private void populateEventList()
        {
            eventList.Items.Clear();
            eventList.AddObjects(_events);
            eventList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            eventList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void populateCalendar()
        {
            calendar.Items.Clear();
            foreach (CalendarItem item in _calendarItems)
            {
                if (calendar.ViewIntersects(item))
                {
                    calendar.Items.Add(item);
                }
            }
        }

        private void fetchEvents()
        {                        
            _events = _eventGateway.fetch_all();            
        }

        private void fetchPersons()
        {
            _persons = _personsGateway.fetch_all();
        }

        private void reloadCalendarItems()
        {
            _calendarItems.Clear();
            foreach (Event e in _events)
            {
                _calendarItems.Add(createCalendarItem(e));
            }
        }

        public Event getSelectedEvent()
        {
            Event e = null;
            if (tabControl.SelectedIndex == 0) //Calendar
            {
                List<CalendarItem> items = calendar.GetSelectedItems().ToList();
                if (items.Count > 0)
                {
                    int id = (int)items[0].Tag; //event ID is stored in calendar item Tag
                    e = _events.Find(ev => ev.ID == id);
                }
            }
            else if (tabControl.SelectedIndex == 1) //List
            {
                e = (Event)eventList.SelectedObject;
            }
            return e;
        }

        public EventGateway EventGateway
        {
            get { return _eventGateway; }
        }

        public PersonGateway PersonGateway
        {
            get { return _personsGateway; }
        }

        private void initalizeEventList()
        {
            colName.ImageGetter = delegate(object eventObj)
            {
                Event e = (Event)eventObj;
                return e.Icon;
            };

            colDate.AspectToStringConverter = delegate(object dateObj)
            {
                DateTime date = (DateTime)dateObj;
                return date.ToString("dd/MM/yyyy");
            };
                        
            colPrice.AspectToStringConverter = delegate(object dateObj)
            {                
                return String.Format("{0:C}", dateObj);
            };   
        }

        private CalendarItem createCalendarItem(Event e)
        {
            CalendarItem item = new CalendarItem(calendar, e.Date, e.Date, e.Name);
            item.BackgroundColor = Color.Lime;
            item.Tag = e.ID;
            return item;
        }

        private void updateCalendarPeriod()
        {
            calendar.SetViewRange(_calDate.AddDays(-1), _calDate.AddMonths(1));            
            l_month.Text = _calDate.ToString("MMMM yyyy");
        }

        private void calNextMonth_Click_1(object sender, EventArgs e)
        {
            try
            {
                _calDate = _calDate.AddMonths(1);
                updateCalendarPeriod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calPrevMonth_Click_1(object sender, EventArgs e)
        {
            try
            {
                _calDate = _calDate.AddMonths(-1);
                updateCalendarPeriod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {            
            tabControl.SelectedIndex = 0;
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void calendar_LoadItems(object sender, CalendarLoadEventArgs e)
        {
            try
            {
                populateCalendar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eventInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkDB()) return;
                Event ev = getSelectedEvent();

                if (ev != null)
                {
                    EventForm form = new EventForm(this, EventForm.Mode.VIEW);
                    form.loadEvent(ev);
                    form.ShowDialog();

                    if (form.FormMode == EventForm.Mode.EDIT && form.DialogResult == DialogResult.OK)
                    {
                        _eventGateway.write(form.Event);
                        populateEvents();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eventAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkDB()) return;
                EventForm form = new EventForm(this, EventForm.Mode.ADD);
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    addNewEvent(form.Event);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eventEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkDB()) return;
                Event ev = getSelectedEvent();

                if (ev != null)
                {
                    EventForm form = new EventForm(this, EventForm.Mode.EDIT);
                    form.loadEvent(ev);
                    form.ShowDialog();

                    if (form.DialogResult == DialogResult.OK)
                    {
                        _eventGateway.write(form.Event);
                        populateEvents();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void eventDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkDB()) return;
                Event selectedEvent = getSelectedEvent();
                if (selectedEvent != null)
                {
                    string msg = "Delete event " + selectedEvent.Name + "?";

                    if (MessageBox.Show(msg, "Delete event", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        deleteEvent(selectedEvent);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eventList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!checkDB()) return;
            eventInfo_Click(this, null);
        }

        private void calendar_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            if (!checkDB()) return;
            eventInfo_Click(this, null);
        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void ribbon2_ActiveTabChanged(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = ribbon2.Tabs.IndexOf(ribbon2.ActiveTab);
        }

        private void personInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkDB()) return;
                Person p = (Person)personList.SelectedObject;
                if (p != null)
                {
                    PersonForm form = new PersonForm(PersonForm.Mode.VIEW);
                    form.loadPerson(p);
                    form.ShowDialog();

                    if (form.FormMode == PersonForm.Mode.EDIT && form.DialogResult == DialogResult.OK)
                    {
                        _personsGateway.write(form.Person);
                        populatePersons();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void personEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkDB()) return;
                Person p = (Person)personList.SelectedObject;
                if (p != null)
                {
                    PersonForm form = new PersonForm(PersonForm.Mode.EDIT);
                    form.loadPerson(p);
                    form.ShowDialog();

                    if (form.DialogResult == DialogResult.OK)
                    {
                        _personsGateway.write(form.Person);
                        populatePersons();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void personAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkDB()) return;
                PersonForm form = new PersonForm(PersonForm.Mode.ADD);
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    addNewPerson(form.Person);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void personDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkDB()) return;
                Person p = (Person)personList.SelectedObject;
                if (p != null)
                {
                    string msg = "Delete person " + p.FName + " " + p.SName + "?";

                    if (MessageBox.Show(msg, "Delete person", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        deletePerson(p);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void personList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!checkDB()) return;
            personInfo_Click(this, null);
        }

        private void itmExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void itmReload_Click(object sender, EventArgs e)
        {
            if (!checkDB()) return;
            loadAllData();
        }

        private void itmSettings_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsForm form = new SettingsForm();
                form.ShowDialog();
                applySettings();
                loadAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkDB()
        {
            if (!_dbOK) MessageBox.Show("Database not available.", "Database connection problem", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            return _dbOK;
        }

        private void itmAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }
    }
}
