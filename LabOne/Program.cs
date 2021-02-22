using System;
using System.Collections.Generic;
using System.Linq;


namespace LabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myFirstCar = new Car();
            Car mySecondCar = new Car(13);

            myFirstCar.CarId = 14;
            mySecondCar.editCarId(66);

            Console.WriteLine(myFirstCar.editCarId());
            Console.WriteLine(mySecondCar.editCarId());

        }
    }

    class Car
    {
        private int carId;
        public int CarId
        {
            get 
            { 
                return carId; 
            }   
            set 
            { 
                carId = value; 
            }  
        }

        public string IDKWhyThisNeeded
        { get; set; }

        public Car() { }
        public Car(int carId)
        {
            this.carId = carId;
        }
    
        public string editCarId()
        {
            return ("#" + carId.ToString());
        }

        public void editCarId(int addToId)
        {
            carId += addToId;
        }
    }
}
