using FinalProject.AbstractFiles;
using FinalProject.SingletonDevice;
using System;
using System.Collections.Generic;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! My name is Argos and I am here to assist you.");
            //AbstractReaderDemo();
            //SingletonDeviceDemo();
            //DeviceFacadeDemo();
        }

        static void AbstractReaderDemo()
        {
            
        } // end method abstract device demo

    } // end class

      public void StartOrder()
    {
        Console.WriteLine("Welcome to The Acme Umbrella Company where we sell EReaders of the future.");
        //AddToOrder();
    }

    private void CreateOrder()
    {
        //Ask what type of EReader would you like to purchase
        Console.WriteLine("What type of EReader would you like to purchase?");
        Console.WriteLine("(E)Ink and (O)LED");
        String ReaderType = Console.ReadLine();

        //Which type did they pick?
        Console.WriteLine("We have three available sizes to choose from: 7, 9, and 12");
        Console.WriteLine("Please make your selection from the following below: ");
        String ReaderSize = Console.ReadLine();
       // EInk7, EInk9, EInk12, OLED7, OLED9, OLED12
        if (ValidateType(readerType)) { }
        else
        {
            Console.WriteLine("You have made an invalid response. Please try your selection again");
            AddType();
        }

        public bool ValidateColor(string color)
        {
            Switch(color.ToLower());
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                default:
                    return false;
            }
    } // end class
} // end namespace
