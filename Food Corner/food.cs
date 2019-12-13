using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Corner
{
    class food
    {
        public food()
        {
            zz = 0;
            bb = 0;
            cb = 0;
            ss = 0;
            mm = 0;
            chowmen = 0;
            pp = 0;
            cg = 0;
            cr = 0;
            ctr = 0;
        }
        //accessors functions
        public double getzin()
        {
            return zz;
        }
        public double getbeef()
        {
            return bb;
        }
        public double getchikenburger()
        {
            return cb;
        }
        public double getmar()
        {
            return mm;
        }
        public double getprawn()
        {
            return pp;
        }
        public double getspag()
        {
            return ss;
        }
        public double getchickgrill()
        {
            return cg;
        }
        public double getchickroll()
        {
            return cr;
        }
        public double getchatniroll()
        {
            return ctr;
        }
        public double getchow()
        {
            return chowmen;
        }
        //default constructor
       public food(double Z, double S, double Chi, double B, double C, double M, double P, double G, double CR, double CTR)
        {
            zz = Z;
            bb = B;
            cb = Chi;
            mm = M;
            pp = P;
            cg = G;
            cr = CR;
            ctr = CTR;
            chowmen = C;
            ss= S;

        }
        private double zz, bb, cb, ss, mm, chowmen, pp, cg, cr, ctr;
    }
}
