using System;
using System.Collections.Generic;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person("Fred", 10, "soup");
            Person1.Speak();
            Person Person2 = new Person("Harry", 4, "pizza");
            Person2.Speak();

            // TODO: instantiate a new Person and get them to talk!
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();
            Person1.Tickle();

            // make person 2 eat
            Person2.Eat();
            Person1.Eat();
        }
    }
}
