using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsApp.Helpers
{
    public static class Randomize
    {
        static Random rnd = new Random();

        public static int RandomUnitSize()
        {
            return rnd.Next(50);
        }
    }
}
