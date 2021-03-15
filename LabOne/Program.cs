using System;
using System.Collections.Generic;
using System.Linq;


namespace LabOne
{
  class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt32 = { 1, 1, 2, 3, 5, 8, 13, 1, -1 };
            new MyClass<int>(arrInt32).Task3();

            string[] arrString = { "Where ever something breathes", "Heart beating the rise and fall", "Of mountains, the waves upon the sky", "Of seas, the terror is our ignorance, that’s", "Why it is named after our home, earth" };
            new MyClass<string>(arrString).Task3();


            Human[] arrHuman = { new Human(39, 167.3f, 10000.0f), new Human(6000.0f), new Human(4300.1f) };
            new MyClass<Human>(arrHuman).Task3();
        }
    }


    class MyClass<T>
    {

        private T[] genericArray;


        public MyClass(T[] genericArray)
        {
            this.genericArray = genericArray;
        }



        public void Task3()
        {

            if (typeof(T) == typeof(Int32))
            {
                int max = 0;
                for(int i = 0; i < genericArray.Length; i++)
                {
                    int num = Convert.ToInt32(genericArray[i]);
                    if (num > max)
                    {
                        max = num;
                    }
                }
                Console.WriteLine("Max Number in Int32 Array is {0}", max);
            }
            else if (typeof(T) == typeof(Human))
            {

                float res = 0;
                foreach (Human man in genericArray as Human[])
                {
                    res += man.Salary;
                }
                Console.WriteLine("Human array Salarys Sum: {0}", res);
                
            }
            else if(typeof(T) == typeof(string))
            {
                // A, E, I, O, U, and sometimes Y.
                char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'y' };

                Console.Write("Find Vowels: ");
                foreach (string str in genericArray as string[])
                {
                    foreach(char ch in str.ToLower())
                    {
                        char a = (Array.Find(vowel, ele => ele == ch));
                        if(a != default(char))
                        { 
                            Console.Write(a + " ");
                        }
                            
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class Human
    {
        private int age;
        private float height;
        private float salary;
        public int Years
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        public float Height
        {
            set
            {
                height = value;
            }
            get
            {
                return height;
            }
        }

        public float Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }           
    
        public Human(int age, float height, float salary)
        {
            this.age = age;
            this.height = height;
            this.salary = salary;
        }
        public Human(float salary)
        {
            this.salary = salary;
        }
    }
}
