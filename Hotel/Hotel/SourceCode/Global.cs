using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    static class Global
    {
        private static string _globalEmID;
        public static string dateFormat = "yyyy'-'MM'-'dd hh':'mm':'ss";
        public static string globalEmID
        {
            get { return _globalEmID; }
            set { _globalEmID = value; }
        }
        private static string _globalEmName;
        public static string globalEmName
        {
            get { return _globalEmName; }
            set { _globalEmName = value; }
        }
    }
}
