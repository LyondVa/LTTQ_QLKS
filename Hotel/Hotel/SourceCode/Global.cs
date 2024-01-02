using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    static class Global
    {
        public static string dateFormat = "yyyy'-'MM'-'dd hh':'mm':'ss";
        private static string _globalEmID;
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
        private static int _globalPermission = 0;
        public static int globalPermission
        {
            get { return _globalPermission; }
            set { _globalPermission = value; }
        }
        private static int _isAdmin = 0;
        public static int isAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        }   
    }
}
