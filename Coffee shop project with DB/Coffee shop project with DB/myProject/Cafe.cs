using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace myProject
{
    class Cafe
    {
        public Cafe()
        {
            newLatte_c = 0.0;
            newafricano = 0.0;
            newblkforest = 0.0;
            newboston = 0.0;
            newbuttry = 0.0;
            newcappu = 0.0;
            newcoffecako = 0.0;
            newespresson = 0.0;
            newIcedLatte = 0.0;
            newlagoos = 0.0;
            newredvlvt = 0.0;
            newrglro = 0.0;
            
        }

        //overload

        public Cafe(double Latte_c,double cappu, double IcedLatte,double espresson,double africano,double rglro,double coffecako,double redvlvt,double blkforest,double boston,double lagoos,double buttry)
        {
            newafricano = africano;
            newblkforest = blkforest;
            newboston = boston;
            newbuttry = buttry;
           newcappu = cappu;
            newcoffecako = coffecako;
            newespresson = espresson;
            newIcedLatte = IcedLatte;
            newlagoos = lagoos;
            newLatte_c = Latte_c;
            newredvlvt = redvlvt;
            newrglro = rglro;
   


        }


        //access


        public double getLatte_c() {
            return newLatte_c;
        }
        public double getIcedLatte()
        {
            return newIcedLatte;
        }
        public double getespresson()
        {
            return newespresson;
        }
        public double getafricano()
        {
            return newafricano;
        }
        public double getrglro()
        {
            return newrglro;

        }
        public double getcappu()
        {
            return newcappu;
        }
        public double getcoffecako()
        {
            return newcoffecako;
        }
        public double getredvlvt()
        {
            return newredvlvt;
        }
        public double getblkforesto()
        {
            return newblkforest;
        }
        public double getboston()
        {
            return newboston;
        }
        public double getlagoos()
        {
            return newlagoos;
        }
        public double getbuttry()
        {
            return newbuttry;
        }









        private double newLatte_c;
        private double newIcedLatte;
        private double newespresson;
        private double newafricano;
        private double newrglro;
        private double newcappu;


        private double newcoffecako;
        private double newredvlvt;
        private double newblkforest;
        private double newboston;
        private double newlagoos;
        private double newbuttry;
        


    }
}
