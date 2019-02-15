using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace OpenHouseProject
{
    static class HelperMethods
    {
        public static void Type(string text)
        {
            foreach(char letter in text)
            {
                Thread.Sleep(40);
                Console.Write(letter);
            }
        }
    }
}
