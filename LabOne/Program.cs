using System;
using System.Collections.Generic;
using System.Linq;


namespace LabOne
{
 class Program
    {
        static void Main(string[] args)
        {
            God newGod = God.GetGod(false);
            Animal myAnimal = new Animal("dog", 4, false);
            Human jack = new Human("Jack Doe", "primacy", true);

            myAnimal.Resurrect();
            jack.Kill();
            jack.Name = "Jonh Doe";


            Console.WriteLine(newGod.GetInfo());
            Console.WriteLine(myAnimal.GetInfo());
            Console.WriteLine(jack.GetInfo());
        }
    }


    class God
    {
        private float researchPercentage;
        protected bool isLive;
        protected bool IsLifeSet
        {
            set { isLive = value; }
        }

        public bool IsLifeGet
        {
            get { return isLive; }
        }

        protected God(bool isLive) 
        {
            this.isLive = isLive;
        }

        private static God godInstance;
        public static God GetGod(bool isLive)
        {
            if (godInstance == null)
            {
                godInstance = new God(isLive);
            }
            return godInstance;
        }

        public string GetInfo()
        {
            if (isLive)
            {
                return "God is alive!";
            }
            else
            {
                return "God is Dead!";
            }
        }
    }

    class Animal : God
    {
        private int legs;
        public int Legs
        {
            set { legs = value; }
            get { return legs; }
        }
        protected string animalKingdom;
        public string AnimalKingdom
        {
            set { animalKingdom = value; }
            get { return animalKingdom; }
        }
        public Animal(string animalKingdom, int legs, bool isLive) : base(isLive) 
        {
            this.AnimalKingdom = animalKingdom;
            this.legs = legs;
        }
        protected Animal(string animalKingdom, bool isLive) : base(isLive)
        {
            this.AnimalKingdom = animalKingdom;
        }

        public void Kill()
        {
            if (isLive)
            {
                isLive = false;
            }
        }
        public void Resurrect()
        {
            if (!isLive)
            {
                isLive = true;
            }
        }

        public new string GetInfo()
        {
            string res = animalKingdom + " " + legs + " " + (isLive ? "animal is alive." : "animal is dead.");
            return res; 
        }
    }

    class Human : Animal
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public Human(string name, string animalKingdom, bool isLive) : base(animalKingdom, isLive)
        {
            this.name = name;
        }

        public new string GetInfo()
        {
            string res = name + " is " + animalKingdom + " and  " + (isLive ? "is alive." : "is dead.");
            return res;
        }
    }
}
