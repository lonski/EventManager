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
        private DateTime _calDate = new DateTime(2015, 1, 1);
        private EventGateway _eventGateway = new EventGateway();
        private List<Event> _events = null;
        private List<CalendarItem> _calendarItems = new List<CalendarItem>();
        
        public MainForm()
        {
            InitializeComponent();

            fetchData();
                        
            initalizeEventList();
            updateCalendarPeriod();

            reloadCalendarItems();
            populate();
        }

        public void addNewEvent(Event e)
        {
            _events.Add(e);
            populate();
        }

        public void deleteEvent(Event e)
        {
            _eventGateway.erase(e);

            fetchData();
            reloadCalendarItems();
            populate();
        }

        public void populate()
        {
            reloadCalendarItems();
            populateCalendar();
            populateEventList();
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

        private void fetchData()
        {                        
            _events = _eventGateway.fetch_all();            
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

        private void initalizeEventList()
        {
            colName.ImageGetter = delegate(object eventObj)
            {
                Event e = (Event)eventObj;
                return e.Icon;
            };

            colPrice.ImageGetter = delegate(object eventObj)
            {                
                return "coins";
            };

            colDate.AspectToStringConverter = delegate(object dateObj)
            {
                DateTime date = (DateTime)dateObj;
                return date.ToString("dd/MM/yyyy");
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
            _calDate = _calDate.AddMonths(1);            
            updateCalendarPeriod();
        }

        private void calPrevMonth_Click_1(object sender, EventArgs e)
        {
            _calDate = _calDate.AddMonths(-1);
            updateCalendarPeriod();
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
            populateCalendar();
        }

        private void eventInfo_Click(object sender, EventArgs e)
        {    
            Event ev = getSelectedEvent();

            if (ev != null)
            {
                EventForm form = new EventForm(this, EventForm.Mode.VIEW);
                form.loadEvent(ev);
                form.Show();
            }
        }

        private void eventAdd_Click(object sender, EventArgs e)
        {
            EventForm form = new EventForm(this, EventForm.Mode.ADD);            
            form.Show();
        }

        private void eventEdit_Click(object sender, EventArgs e)
        {
            Event ev = getSelectedEvent();

            if (ev != null)
            {
                EventForm form = new EventForm(this, EventForm.Mode.EDIT);
                form.loadEvent(ev);
                form.Show();
            }
        }
        
        private void eventDelete_Click(object sender, EventArgs e)
        {
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

        private void eventList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            eventInfo_Click(this, null);
        }

        private void calendar_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            eventInfo_Click(this, null);
        }

    }
}
