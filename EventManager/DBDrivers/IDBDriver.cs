using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager.DBDrivers
{
    abstract public class IDBDriver
    {
        abstract public bool open(string db);
        abstract public bool close();

        abstract public List< Dictionary<string, string> > query(string query);
        abstract public Dictionary<string, string> queryFirst(string query);
        abstract public bool exists(string query);
    }
}
