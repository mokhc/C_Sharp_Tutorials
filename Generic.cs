//@mokhc
//program demonstrates Generic type
using System;

namespace Generic1
{
    //interface
    interface Interface<Type>
    {
        public void InterGetInput(Type name);
        public Type IntReply();
    }

    //class
    class Fruit<Type>
    {
        Type name;
        public Fruit(Type name)
        {
            this.name = name;
        }

        public Type Reply()
        { 
            return name;
        }
    }

    //struct
    struct FruitType<Type>
    {
        Type name;
        public Type Getinput(Type name)
        {
            this.name = name;
            return name;
        }

        public Type Replystruct()
        {
            return name;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Fruit<string> one = new Fruit<string>("Banana");
            Console.WriteLine(one.Reply());
            FruitType<string> two = new FruitType<string>();
            two.Getinput("Orange");
            Console.WriteLine(two.Replystruct());
            FromInt<string> three = new FromInt<string>();
            three.InterGetInput("Apple");
            Console.WriteLine(three.IntReply());
            OutsideFruit<string> of1 = new OutsideFruit<string>("Watermelon");
            Console.WriteLine(of1.ReplyOF());
        }

        //class - derived from interface
        class FromInt<Type> : Interface<Type>
        {
            Type name;
            public void InterGetInput(Type name)
            {
                this.name = name;
            }

            public Type IntReply()
            {
                return name;
            }
        }
    }
}
