using System;

namespace ChuanHoangUtilLive
{
    class Program
    {
        static void Main()
        {
            Person p1;
            p1.Age = 18;
            p1.Name = "Chuan";
            Person p2 = p1;
            p2.Age = 20;
            p2.Name = "Chuan Hoang";
            var r1 = p1.ShowInfo();
            var r2 = p2.ShowInfo();
            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }
    }
    struct Person
    {
        public byte Age;
        public string Name;
        public Person(byte age, string name)
        {
            Age = age;
            Name = name;
        }
        public string ShowInfo() => $"{Name} | {Age}";
    }
}