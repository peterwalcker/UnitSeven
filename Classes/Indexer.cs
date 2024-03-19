using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSeven.Classes
{
    //MVP using just a counter
    internal static class Indexer
    {
        private static int _index;

        private static void GetLastIndex()
        {
            _index = 0;
            //Not implemented, gets last id from saved state
        }

        internal static int GenerateID()
        {
            return _index++;
            //Not implemented, using just a counter now
        }
    }
}
