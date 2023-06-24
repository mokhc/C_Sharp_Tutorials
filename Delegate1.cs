//@mokhc
//Program demonstrates delegate...
//...and assignment of a method with similar signature
using System;

namespace Delegate1
{
    class Program
    {
        //declaration of delegate
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

        //static method sub2
        static double sub2(double num)
        {
            double ret;
            ret = num - 2;
            return ret;
        }

        //main
        static void Main(string[] args)
        {
            //declaration of an array
            double[] dbarray = { 0.0, 0.1, 0.2 };
            //assignment of method with similar signature
            Acepdb acepdb1 = sub2;
            //Instantiation of class Ops
            Ops ops1 = new Ops(dbarray, acepdb1);
        }
    }
}
