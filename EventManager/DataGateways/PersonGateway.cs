using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventManager.DataGateways
{
    public class PersonGateway : DataGateway
    {
        public Person fetch(int i)
        {
            db.open(db_file);

            Person e = null;
            Dictionary<string, string> personData = db.queryFirst("SELECT * FROM persons WHERE id=" + i);

            if (personData.Count > 0)
            {
                e = createPerson(personData);
            }

            db.close();
            return e;
        }

        private static Person createPerson(Dictionary<string, string> personData)
        {
            Person p = new Person();

            try
            {
                p.ID = Convert.ToInt32(personData["id"]);
                p.FName = personData["fname"];
                p.SName = personData["sname"];
                p.Company = personData["company"];
                p.Phone = personData["phone"];
                p.Email = personData["email"];
                p.Type = (Person.PersonType)Convert.ToInt32(personData["type"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Person loading failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return p;
        }

        public List<Person> fetch_all()
        {
            db.open(db_file);
            List<Person> persons = new List<Person>();
            List<Dictionary<string, string>> personsData = db.query("SELECT * FROM persons");

            foreach (Dictionary<string, string> pData in personsData)
            {
                persons.Add(createPerson(pData));
            }

            db.close();
            return persons;
        }

        public void write(Person p)
        {
            db.open(db_file);

            if (db.exists("SELECT 1 FROM persons WHERE id=" + p.ID))
            {//UPDATE
                db.query("UPDATE persons SET "
                         + "fname=\"" + p.FName + "\","
                         + "sname=\"" + p.SName + "\","
                         + "company=\"" + p.Company + "\","
                         + "phone=\"" + p.Phone + "\","                                                  
                         + "email=\"" + p.Email + "\", "
                         + "type=" + (int)p.Type + " "
                         + "WHERE id=" + p.ID
                        );
            }
            else
            {//INSERT            
                int id = Convert.ToInt32(db.query("SELECT coalesce(max(id),0) as max FROM persons")[0]["max"]) + 1;
                p.ID = id;
                db.query("INSERT INTO persons(id,fname,sname,company,phone,email, type)"
                         + "VALUES(" + p.ID + ",\"" + p.FName + "\",\"" + p.SName + "\",\"" + p.Company + "\",\"" 
                         + p.Phone + "\",\"" + p.Email + "\","+(int)p.Type+");"
                        );
            }

            db.close();
        }

        public void erase(Person p)
        {
            db.open(db_file);
            db.query("DELETE FROM eventPersons WHERE person=" + p.ID);
            db.query("DELETE FROM persons WHERE id=" + p.ID);
            db.close();
        }
    }
}
