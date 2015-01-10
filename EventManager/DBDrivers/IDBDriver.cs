using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager.DBDrivers
{
    abstract class IDBDriver
    {
        abstract public void open(string db);
        abstract public void close();

        abstract public List< Dictionary<string, string> > query(string query);
    }
}
