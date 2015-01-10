using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager
{
    class Event
    {
        private int _id = 0;
        private string _name = "";
        private string _description = "";
        private string _location = "";
        private DateTime _dateStart = new DateTime(2015,1,1);
        private DateTime _dateEnd = new DateTime(2015,1,1);

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public DateTime DateStart
        {
            get { return _dateStart; }
            set 
            {
                if (value != null) _dateStart = value;                    
            }
        }
        public DateTime DateEnd
        {
            get { return _dateEnd; }
            set
            {
                if (value != null) _dateEnd = value;
            }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
