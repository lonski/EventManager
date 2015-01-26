using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager
{
    using System.Drawing;
    using EventPersons = List<int>;

    public class Event
    {
        private int _id = 0;
        private string _name = "";
        private string _description = "";
        private string _comments = "";
        private string _location = "";
        private DateTime _date = DateTime.Now;
        private double _price = 0;
        private int _icon = -1;
        private int _cv = 0;
        private int _hired = 0;
        private int _applications = 0;
        private int _target = 0;
        private string _feedback = "";
        private DateTime _deadline = DateTime.Now;
        private Color _color = Color.Lime;
        private EventPersons _persons = new EventPersons();

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public DateTime Deadline
        {
            get { return _deadline; }
            set { _deadline = value; }
        }

        public string Feedback
        {
            get { return _feedback; }
            set { _feedback = value; }
        }

        public int Applications
        {
            get { return _applications; }
            set { _applications = value; }
        }

        public int Target
        {
            get { return _target; }
            set { _target = value; }
        }

        public EventPersons Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }

        public string Comment
        {
            get { return _comments; }
            set { _comments = value; }
        }

        public int Hired
        {
            get { return _hired; }
            set { _hired = value; }
        }

        public int Cv
        {
            get { return _cv; }
            set { _cv = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

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
        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value != null) _date = value;
            }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
