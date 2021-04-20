using System;
using System.Collections.Generic;
using System.Linq;


namespace LabOne
{
public abstract class Device
    {
        protected int number;

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public Device(int number)
        {
            this.number = number;
        }

        public abstract void Action();
    }


    class MobileDevice : Device
    {
        public MobileDevice(int number) : base(number) { }
        public override void Action()
        {
            Console.WriteLine($"Device {number} On");
        }
    }

    abstract class Decorator : Device
    {
        protected Device myDevice;

        public Device MyDevice
        {
            get
            {
                return myDevice;
            }
        }

        public Decorator(Device myDevice) : base(myDevice.Number)
        {
            this.myDevice = myDevice;
        }


        public override void Action()
        {
            if (this.myDevice != null)
            {
                this.myDevice.Action();
            }
            
        }
    }

    class Racia : Decorator
    {
        public Racia(Device myDevice) : base(myDevice)
        {
        }

        public override void Action()
        {
            base.Action();
            Console.WriteLine($"GetConact with {myDevice.Number}");
        }
    }

    class LandlinePhone : Decorator
    {
        public LandlinePhone(Device myDevice) : base(myDevice)
        {
        }

        public override void Action()
        {
            base.Action();
            Console.WriteLine($"Press the buttons on {myDevice.Number} device");
        }
    }

    class MobilePhone : Decorator
    {
        public MobilePhone(Device myDevice) : base(myDevice)
        {
        }

        public override void Action()
        {
            base.Action();
            Console.WriteLine("On Light");
        }
    }

    class SmartPhone : Decorator
    {
        public SmartPhone(Device myDevice) : base(myDevice)
        {
        }

        public override void Action()
        {
            base.Action();
            Console.WriteLine($"Open Instagram on {myDevice.Number}");

        }
    }

    class Devices
    {
        public Device IPhone(Device md)
        {

            Racia rc = new Racia(md);
            LandlinePhone lp = new LandlinePhone(rc);
            MobilePhone mp = new MobilePhone(lp);
            SmartPhone sp = new SmartPhone(mp);
            return sp;
        }

        public Device Nokia(Device md)
        {

            Racia rc = new Racia(md);
            LandlinePhone lp = new LandlinePhone(rc);
            MobilePhone mp = new MobilePhone(lp);
            return mp;
        }

        public Device Panasonic(Device md)
        {

            Racia rc = new Racia(md);
            LandlinePhone lp = new LandlinePhone(rc);
            return lp;
        }

        public Device Motorola(Device md)
        {

            Racia rc = new Racia(md);
            return rc;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Devices d = new Devices();

            Device myDevice = new MobileDevice(813);

            myDevice = d.IPhone(myDevice);
            myDevice.Action();
        }
    }
}
