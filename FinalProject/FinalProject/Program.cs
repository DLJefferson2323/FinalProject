using FinalProject.AbstractFiles;
using FinalProject.BaseFiles;
using System;


namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            AbstractDeviceDemo();
        }

        static void AbstractDeviceDemo() 
        {
            AbstractDeviceFactory factory = new SmallDeviceFactory();
            IDeviceFrame deviceFrame = factory.CreateDeviceFrame();
            IDeviceScreen deviceScreen = factory.CreateDeviceScreen();

            Console.WriteLine(deviceFrame.DeviceFramePart);
            Console.WriteLine(deviceScreen.DeviceScreenPart);
        } // end method abstract factory demo
    }
}
