using FinalProject.DeviceBase;
using System;

namespace FinalProject.AbstractFiles
{
    public abstract class AbstractDevice
    {
        public IDevice GetDevice { get; }
        public SurfaceColor ColorType { get; private set; }
        public abstract decimal Price { get; }

        public AbstractDevice(SurfaceColor color, IDeviceSize devicesize) 
        {
            ColorType = color;
            GetDevice = device;
        } // end method abstract device

        public AbstractDevice(int size, IDeviceSize devicesize)
            : this(SurfaceColor.Black, devicesize) { }

        public virtual void Color(SurfaceColor color) 
        {
            ColorType = color;
        } // end method virtual void

        public virtual void CleanFrame()
        {
            Console.WriteLine("Cleaning Frame...");
        } // end method virtual void clean frame

        public virtual void CleanScreen()
        {
            Console.WriteLine("Cleaning screen...");
        } // end method virtual void clean screen

        public virtual void TestOS()
        {
            Console.WriteLine("Testing Operating System and restarting when complete...");
        } // end method virtual void test operating system

        public override string ToString()
        {
            return this.GetType().Name + " Device Color is " + ColorType + " and costs $"
                + Price;
        } // end method override
    } // end class
} // end namespace
