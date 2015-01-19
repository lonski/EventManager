using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventManager.DBDrivers;

namespace EventManager.DataGateways
{
    public class DataGateway
    {
        protected IDBDriver db = null;
        protected string db_file = Properties.Settings.Default.DatabasePath;

        public string DBFile
        {
            get { return db_file; }
            set { db_file = value; }
        }

        public DataGateway()
        {
            db = new SqlLiteDriver();
        }
    }
}
