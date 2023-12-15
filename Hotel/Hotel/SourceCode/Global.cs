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
        public static string globalEmID
        {
            get { return _globalEmID; }
            set { _globalEmID = value; }
        }
    }
}
