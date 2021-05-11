using System;
using System.Collections.Generic;
using System.Linq;


namespace LabOne
{
 interface IHuman
    {

        int Age { get; }

        void Drink();

    }

    abstract class Pensioner
    {
        protected int pensiya;
        public int Pensiya
        {
            get
            {
                return pensiya;
            }
        }
        public Pensioner(int pensiya)
        {
            this.pensiya = pensiya;
        }

        public virtual void Vorchat()
        {
            Console.WriteLine("Ворчит.");
        } 
    }

    abstract class WebDeveloper
    {
        protected string framework;
        public string Fraemwork
        {
            get
            {
                return framework;
            }
        }

        public WebDeveloper(string fraemwork)
        {
            this.framework = fraemwork;
        }

        public virtual void Work()
        {
            Console.WriteLine("Верстать");
        }
        public virtual void Work(int workHour)
        {
            Console.WriteLine("Страдать");
        }

    }
    abstract class Domohozyaika
    {
        private string adres;
        public string Adres
        {
            get
            {
                return adres;
            }
        }
        public Domohozyaika(string adress)
        {
            this.adres = adress;
        }

        public virtual void Work() { }
    }
    abstract class Scholnik
    {
        private int schoolClass;
        public int SchoolClass
        {
            get
            {
                return schoolClass;
            }
        }

        public Scholnik(int schoolClass)
        {
            this.schoolClass = schoolClass;
        }

        public virtual void Edu() { }
    }
    abstract class Dedsadovec
    {
        private string group;
        public string Group
        {
            get
            {
                return group;
            }
        }

        public Dedsadovec(string group)
        {
            this.group = group;
        }
    }

    class GrandFather : Pensioner, IHuman
    {
        int age;
        public int Age { get { return age; } }


        public GrandFather(int age, int pensiya = 100) : base(pensiya)
        {
            this.age = age;
        }

        public void Drink() { }

    }

    class GrandMother : Pensioner, IHuman
    {
        int age;
        public int Age { get { return age; } }


        public GrandMother(int age, int pensiya) : base(pensiya)
        {
            this.age = age;
        }

        public void Drink() { }

    }

    class Father : GrandFather
    {
        protected static Father fatherInstance;

        public static Father GetFather(int age)
        {
            if (fatherInstance == null) fatherInstance = new Father(age);
            return fatherInstance;
        }

        private Father(int age) : base(age)
        {

        }

        public void Drink() { }

    }

    class Mother : Domohozyaika, IHuman
    {
        int age;
        public int Age { get { return age; } }

        protected static Mother motherInstance;

        public static Mother GetMother(string adress, int age)
        {
            if (motherInstance == null) return new Mother(adress, age);
            else return motherInstance;
        }

        private Mother(string adress, int age) : base(adress)
        {
            this.age = age;
        }

        public void Drink() { }

    }

    class Daughter : Scholnik, IHuman
    {
        private int age;
        public int Age { get { return age; } }

        public Daughter(int age, int schoolClass) : base(schoolClass)
        {
            this.age = age;
        }
        public void Drink() { }
        public override void Edu() { Console.WriteLine("Edu"); }
    }

    class Son : Dedsadovec, IHuman
    {
        private int age;
        public int Age { get { return age; } }

        public Son(string group, int age) : base(group)
        { 
            this.age = age; 
        }
        public void Drink() { Console.WriteLine("Drink Sok"); }
    }


    class Semya
    {
        private List<IHuman> family;

        public Semya()
        {
            family = new List<IHuman>();
            family.Add(new GrandFather(66, 20));
            family.Add(new GrandMother(66, 21));
            family.Add(Father.GetFather(42));
            family.Add(Mother.GetMother("42/13", 42));
            family.Add(new Daughter(14, 7));
            family.Add(new Son("Zebra", 4));
        }

        public void PrintSemya()
        {
            foreach(IHuman human in family)
            {
                Console.WriteLine(human.Age);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            new Semya().PrintSemya();
        }
    }
}
