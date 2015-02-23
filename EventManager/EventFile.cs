using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager
{
    public class EventFile
    {        
        private string _subpath;
        private string _path;

        public EventFile()
        {
        }

        public EventFile(string fileSubPath)
        {
            _subpath = fileSubPath;            
        }
        
        public string Filename
        {
            get { return System.IO.Path.GetFileName(_subpath); }            
        }

        public string Directory
        {
            get { return System.IO.Path.GetDirectoryName(_subpath); }            
        }

        public string SubPath
        {
            get { return _subpath; }
            set { _subpath = value; }
        }
    }
}
