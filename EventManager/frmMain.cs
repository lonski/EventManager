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
    public partial class frmMain : Form
    {
        private DateTime _calDate = new DateTime(2015, 1, 1);
        private EventGateway _eventGateway = new EventGateway();
        private List<Event> _events = null;
        
        public frmMain()
        {
            InitializeComponent();
            updateCalendar();
            loadEvents();
        }

        private void loadEvents()
        {
            _events = _eventGateway.fetch_all();

            foreach( Event e in _events)
            {
                eventList.AddObject(e);
                calendar.Items.Add( createCalendarItem(e) );
            }

        }

        private CalendarItem createCalendarItem(Event e)
        {
            CalendarItem item = new CalendarItem(calendar, e.DateStart, e.DateEnd, e.Name);
            item.BackgroundColor = Color.Lime;
            return item;
        }

        private void updateCalendar()
        {
            calendar.SetViewRange(_calDate.AddDays(-1), _calDate.AddMonths(1));
            l_month.Text = _calDate.ToString("MMMM yyyy");
        }

        private void calNextMonth_Click_1(object sender, EventArgs e)
        {
            _calDate = _calDate.AddMonths(1);
            updateCalendar();
        }

        private void calPrevMonth_Click_1(object sender, EventArgs e)
        {
            _calDate = _calDate.AddMonths(-1);
            updateCalendar();
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

    }
}
