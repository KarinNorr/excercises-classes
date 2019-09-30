using System;

namespace EXERCISE
{
    class Cat
    {
        public string name;
        public int age;
        public string race;
        public void Mjau()
        {
            Console.WriteLine("Katten säger Mjau!");
        }
        public void HuntingRats()
        {
            Console.WriteLine("Katten går till attack!");
        }
        public void GetInfo()
        {
            Console.WriteLine("Den här katten heter " + name + " och är " + age + " år gammal " + "den är en " + race);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            myCat.name = "Doris";
            myCat.age = 3;
            myCat.race = "söt huskatt.";
            myCat.Mjau();
            myCat.HuntingRats();
            myCat.GetInfo();
        }
    }
}
