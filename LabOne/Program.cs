using System;
using System.Collections.Generic;
using System.Linq;


namespace LabOne
{
     class MrPresident
    {
        private string presidentName;
        public string PresidentName
        {
            set
            {
                presidentName = value;
            }
            get
            {
                return presidentName;
            }
        }

        private string presidentSureName;
        public string PresidentSureName
        {
            set
            {
                presidentSureName = value;
            }
            get
            {
                return presidentSureName;
            }
        }

        private int presidentSalary;
        public int PresidentSalary
        {
            set
            {
                presidentSalary = value;
            }
            get
            {
                return presidentSalary;
            }
        }

        private static MrPresident singletonPresident;

        private MrPresident() 
        { }

        public static MrPresident GetPresident()
        {
            if (singletonPresident == null)
            {
                singletonPresident = new MrPresident();     
            }
            return singletonPresident;
        }

        public string PassLaw()
        {
            string[] laws = { "Dont Kill", "Dont Say", "Dont lie", "Dont thoughts" };
            var rand = new Random();
            return laws[rand.Next(4)];
        }

        public void SignLaw(string law)
        {
            Console.WriteLine(law + " be signed.");
        }

        public void CancelLaw(string law)
        {
            Console.WriteLine(law + " cancelled.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MrPresident mypresident = MrPresident.GetPresident();
            mypresident.PresidentSureName = "Lenin";
            MrPresident alsomypresident = MrPresident.GetPresident();


            Console.WriteLine(alsomypresident.PresidentSureName);

            Console.WriteLine(mypresident.PassLaw());
            
        }
    }
}
