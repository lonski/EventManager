using EventManager.DBDrivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager.DataGateways
{
    class EventGateway
    {
        private IDBDriver db = null;
        private string db_file = @"d:\Sources\EventManager\EventManager\Database\event_manager.s3db";

        public EventGateway()
        {
            db = new SqlLiteDriver();
        }

        public Event fetch(int i)
        {
            db.open(db_file);

            Event e = null;
            List<Dictionary<string, string>> eventData = db.query("SELECT * FROM events WHERE id="+i);

            if (eventData.Count > 0)
            {
                e = createEvent(eventData[0]);
            }

            db.close();
            return e;
        }

        private static Event createEvent(Dictionary<string, string> eventData)
        {
            Event e = new Event();

            e.ID = Convert.ToInt32(eventData["id"]);
            e.Name = eventData["name"];
            e.Location = eventData["location"];
            e.Description = eventData["description"];
            e.DateStart = DateTime.Parse(eventData["dateStart"]);
            e.DateEnd = DateTime.Parse(eventData["dateEnd"]);

            return e;
        }

        public List<Event> fetch_all()
        {
            db.open(db_file);
            List<Event> events = new List<Event>();
            List<Dictionary<string, string>> eventsData = db.query("SELECT * FROM events");

            foreach(Dictionary<string,string> eData in eventsData)
            {
                events.Add(createEvent(eData));
            }

            db.close();
            return events;
        }

        public void write(Event e)
        {
            db.open(db_file);
            string query = "insert into events(name,location,description,dateStart,dateEnd)values(\"name\",\"loc\",\"dsc\",\""+ e.DateStart +"\",\"" + e.DateEnd +"\");";
            db.query(query);
            db.close();
        }
    }
}
