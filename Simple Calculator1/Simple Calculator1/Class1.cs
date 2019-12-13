using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator1
{
    class Class1
    {

        public string Calc(string f, string s, string work)
        {
            float a;
            float ff = float.Parse(f);
            float ss= float.Parse(s);
            if(work == "+")
            {
                a= ff +ss;
            }
            else if ( work == "-")
            {
                a= ff-ss;
            }
            else if (work == "x")
            {
                a= ff*ss;
            }
            else
            {
                a=ff/ss;
            }
            return a.ToString();
        }
    }
}
