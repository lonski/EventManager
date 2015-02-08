using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager.DataGateways
{
    public class TargetGateway : DataGateway
    {
        public List<string> fetch_all()
        {
            db.open(db_file);
            List<string> targets = new List<string>();
            List<Dictionary<string, string>> targetsData = db.query("SELECT * FROM targets");

            foreach (Dictionary<string, string> target in targetsData)
            {
                targets.Add(target["name"]);
            }

            db.close();
            return targets;
        }

        public void write(string target)
        {
            db.open(db_file);

            if (!db.exists("SELECT 1 FROM targets WHERE name=\"" + target + "\""))
            {
                db.query("INSERT INTO targets(name) VALUES(\""+ target +"\");");
            }

            db.close();
        }

        public void erase(string target)
        {
            db.open(db_file);
            db.query("DELETE FROM targets WHERE name=\"" + target + "\"");
            db.close();
        }
    }
}
