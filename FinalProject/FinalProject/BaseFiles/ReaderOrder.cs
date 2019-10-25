using FinalProject.AbstractFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.BaseFiles
{
    public class ReaderOrder
    {
        public static void Main()
        {
            SevenInch EInk7 = new SevenInch()
            {
                price  = 85.00,
                prefix  = "753901",
                count = 7593,
            }

            NineInch EInk9 = new NineInch()
            {
                price = 99.00,
                prefix = "426852",
                count = 6487,
            }

            TwelveInch EInk12 = new TwelveInch()
            {
                price = 120.00,
                prefix = "153790",
                count = 3276,
            }
        }
        (string[] args)
        {
            public int ReaderType { get; set; }
            public string ReaderSize { get; set; }
            public int Price { get; set; }

        } // end method static void
    } // end class
} // end namespace
