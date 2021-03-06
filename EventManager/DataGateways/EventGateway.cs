﻿using EventManager.DBDrivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace EventManager.DataGateways
{
    using EventPersonEntry = KeyValuePair<int, Person.PersonType>;
    using EventPersons = Dictionary<int, Person.PersonType>;

    public class EventGateway : DataGateway
    {

        public Event fetch(int i)
        {
            db.open(db_file);
            
            Event e = null;
            Dictionary<string, string> eventData = db.queryFirst("SELECT * FROM events WHERE id="+i);
            
            if (eventData.Count > 0)
            {
                e = createEvent(eventData);
            }

            db.close();
            return e;
        }

        private Event createEvent(Dictionary<string, string> eventData)
        {
            Event e = new Event();

            try
            {
                e.ID = Convert.ToInt32(eventData["id"]);
                e.Name = eventData["name"];
                e.Location = eventData["location"];
                e.Description = eventData["description"];
                e.Comment = eventData["comment"];
                e.Icon = Convert.ToInt32(eventData["icon"]);
                e.Price = Convert.ToDouble(eventData["price"]);
                e.Cv = Convert.ToInt32(eventData["cv"]);
                e.Hired = Convert.ToInt32(eventData["hired"]);
                e.Applications = Convert.ToInt32(eventData["appCount"]);
                e.Target = eventData["target"];
                e.Feedback = eventData["feedback"];

                string eventColor = eventData["color"];
                e.Color = eventColor.Equals("") ? Color.Lime : ColorTranslator.FromHtml(eventColor);

                string eventDate = eventData["date"];
                e.Date = eventDate.Equals("") ? DateTime.Now : DateTime.Parse(eventDate);

                string eventDeadline = eventData["deadline"];
                e.Deadline = eventDeadline.Equals("") ? DateTime.Now : DateTime.Parse(eventDeadline);

                loadPersons(e);
                loadFiles(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Event loading failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return e;
        }

        private void loadPersons(Event e)
        {
            List<Dictionary<string, string>> persons = db.query("SELECT person FROM eventPersons WHERE event = " + e.ID);

            foreach (Dictionary<string, string> person in persons)
            {
                e.Persons.Add(Convert.ToInt32(person["person"]));
            }
        }

        private void loadFiles(Event e)
        {
            List<Dictionary<string, string>> files = db.query("SELECT path FROM eventFiles WHERE event = " + e.ID);

            foreach (Dictionary<string, string> file in files)
            {
                e.addFile(new EventFile(file["path"]));
            }
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

            try
            {
                //db.query("ALTER TABLE events ADD COLUMN color VARCHAR(32)");                
            }
            catch(Exception){}

            if (db.exists("SELECT 1 FROM events WHERE id=" + e.ID))
            {//UPDATE
                db.query(  "UPDATE events SET "
                         + "name=\"" + e.Name + "\","
                         + "location=\"" + e.Location + "\","
                         + "description=\"" + e.Description + "\","
                         + "date=\"" + e.Date.ToString("g") + "\","
                         + "deadline=\"" + e.Deadline.ToString("g") + "\","
                         + "icon=" + e.Icon + ","
                         + "price=" + e.Price + ","
                         + "cv=" + e.Cv + ","
                         + "hired=" + e.Hired + ","
                         + "comment=\"" + e.Comment + "\", "
                         + "appCount=" + e.Applications + ","
                         + "target=\"" + e.Target + "\","
                         + "color=\"" + ColorTranslator.ToHtml(e.Color) + "\", "
                         + "feedback=\"" + e.Feedback + "\" "
                         + "WHERE id=" + e.ID
                        );                
            }
            else
            {//INSERT
                int id = Convert.ToInt32(db.query("SELECT coalesce(max(id),0) as max FROM events")[0]["max"]) + 1;
                e.ID = id;
                db.query( "INSERT INTO events(id,name,location,description,date,icon,price,cv,hired,comment,"
                         + "deadline,appCount,target,color,feedback) "
                         + "VALUES(" + e.ID + ",\"" + e.Name + "\",\"" + e.Location + "\",\"" + e.Description + "\",\""
                         + e.Date + "\"," + e.Icon + "," + e.Price + "," + e.Cv + "," + e.Hired + ",\"" + e.Comment + "\""
                         + ",\"" + e.Deadline + "\"," + e.Applications + ",\"" + e.Target + "\",\"" + ColorTranslator.ToHtml(e.Color) + "\""
                         + ",\"" + e.Feedback + "\"" 
                         +");"
                        );
            }

            deleteEventPersons(e.ID);
            foreach( int pID in e.Persons )
            {
                addPersonToEvent(e.ID, pID);
            }

            deleteEventFiles(e.ID);
            foreach( EventFile file in e.Files )
            {
                addFileToEvent(e.ID, file);
            }
            
            db.close();
        }

        public void deleteEventPersons(int eID)
        {
            db.query("DELETE FROM eventPersons WHERE event = " + eID);
        }

        public bool eventHasPerson(int eID, int pID)
        {
            return db.exists("SELECT 1 FROM eventPersons WHERE event=" + eID + " and person=" + pID);
        }

        public void addPersonToEvent(int eID, int pID)
        {
            db.query("INSERT INTO eventPersons(event, person) VALUES(" + eID + "," + pID + ")");
        }

        public void deleteEventFiles(int eID)
        {
            db.query("DELETE FROM eventFiles WHERE event = " + eID);
        }

        public void addFileToEvent(int eID, EventFile file)
        {
            db.query("INSERT INTO eventFiles(event, path) VALUES(" + eID + ",\"" + file.SubPath + "\")");
        }

        public void erase(Event e)
        {
            db.open(db_file);
            deleteEventPersons(e.ID);
            deleteEventFiles(e.ID);            
            db.query("DELETE FROM events WHERE id=" + e.ID);     
            db.close();
        }
    }
}
