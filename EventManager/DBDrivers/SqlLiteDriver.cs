using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace EventManager.DBDrivers
{
    class SqlLiteDriver : IDBDriver
    {
        private SQLiteConnection _cnn = null;

        override public void open(string db) 
        {            
            _cnn = new SQLiteConnection(@"data source=" + db);
            _cnn.Open();
        }

        override public void close()
        {
            _cnn.Close();
        }

        override public List<Dictionary<string, string>> query(string query)
        {
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            
            SQLiteCommand command = new SQLiteCommand(query, _cnn);            
            SQLiteDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                Dictionary<string, string> row = new Dictionary<string,string>();
                
                for( int i = 0; i < reader.FieldCount; ++i)
                {
                    row[reader.GetName(i)] = reader[i].ToString();
                }
                data.Add(row);                
            }

            return data;
        }
    }
}
