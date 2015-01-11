using EventManager.DBDrivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager.DataGateways
{
    public class EventGateway
    {
        private IDBDriver db = null;
        private string db_file = @"..\..\..\Database\event_manager.s3db";

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
            e.Comment = eventData["comment"];
            e.Date = DateTime.Parse(eventData["date"]);
            e.Icon = Convert.ToInt32(eventData["icon"]);
            e.Price = Convert.ToDouble(eventData["price"]);
            e.Cv = Convert.ToInt32(eventData["cv"]);
            e.Hired = Convert.ToInt32(eventData["hired"]);

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

            if (db.exists("SELECT 1 FROM events WHERE id=" + e.ID))
            {//UPDATE
                db.query(  "UPDATE events SET "
                         + "name=\"" + e.Name + "\","
                         + "location=\"" + e.Location + "\","
                         + "description=\"" + e.Description + "\","
                         + "date=\"" + e.Date + "\","
                         + "icon=" + e.Icon + ","
                         + "price=" + e.Price + ","
                         + "cv=" + e.Cv + ","
                         + "hired=" + e.Hired + ","
                         + "comment=\"" + e.Comment + "\" "
                         + "WHERE id=" + e.ID
                        );
            }
            else
            {//INSERT            
                int id = Convert.ToInt32( db.query("SELECT max(id) as max FROM events")[0]["max"] ) + 1;
                e.ID = id;
                db.query( "INSERT INTO events(id,name,location,description,date,icon,price,cv,hired,comment)"
                         +"VALUES("+e.ID+",\""+e.Name+"\",\""+e.Location+"\",\""+e.Description+"\",\""+e.Date+"\","
                         +e.Icon+","+e.Price+","+e.Cv+","+e.Hired+",\""+e.Comment+"\");"                       
                        );                
            }
            
            db.close();
        }

        public void erase(Event e)
        {
            db.open(db_file);
            db.query("DELETE FROM events WHERE id=" + e.ID);
            db.close();
        }
    }
}
