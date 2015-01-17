using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace EventManager.DBDrivers
{
    public class SqlLiteDriver : IDBDriver
    {
        private SQLiteConnection _cnn = null;

        override public bool open(string db) 
        {            
            _cnn = new SQLiteConnection(@"data source=" + db);
            _cnn.Open();

            return _cnn.State == ConnectionState.Open;
        }

        override public bool close()
        {
            _cnn.Close();

            return _cnn.State == ConnectionState.Closed;
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

        override public Dictionary<string, string> queryFirst(string _query)
        {
            List<Dictionary<string, string>> data = query(_query);                        
            return data.Count > 0 ? data[0] : null;
        }

        override public bool exists(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, _cnn);
            SQLiteDataReader reader = command.ExecuteReader();

            return reader.HasRows;
        }
    }
}
