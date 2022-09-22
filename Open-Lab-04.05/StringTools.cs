using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string nlet = "";
            {
                foreach (char c in orig)
                {
                    for (int i = 0; i < n; i++)
                    nlet = nlet + c;
                }
            }
            return nlet;
        } 
    }
}
