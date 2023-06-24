//@mokhc
//Program demonstrates delegate...
//...and assignment using lambda expression
using System;

namespace Delegate3
{
    class Program
    {//declaration of delegate
        delegate double Acepdb(double num);

        //class
        class Ops
        {
            //constructor
            public Ops(double[] dbarray, Acepdb acepdb)
            {
                int len = dbarray.Length;
                int count = 0;
                while (count != len)
                {
                    dbarray[count] = acepdb(dbarray[count]);
                    Console.WriteLine(dbarray[count]);
                    count++;
                }
            }
        }

        //main
        static void Main(string[] args)
        {
            //declaration of an array
            double[] dbarray = { 0.0, 0.1, 0.2 };
            //assignment of method with similar signature
            Acepdb acepdb1 = (double x) =>
            {
                double ret;
                ret = x - 2;
                return ret;
            };
            //Instantiation of class Ops
            Ops ops1 = new Ops(dbarray, acepdb1);
        }
    }
}
