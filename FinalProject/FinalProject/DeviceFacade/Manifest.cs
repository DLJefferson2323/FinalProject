using FinalProject.AbstractFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.DeviceFacade
{
    public class Manifest
    {
        private List<AbstractReaderBase> _readers;
        private int _formWidth = 100;

        public Manifest(List<AbstractReaderBase> readers)
        {
            this._readers = readers;

            string manifestTitle = "MANIFEST";
            string titleFormat = String.Format("{0,9}", manifestTitle);
            Console.WriteLine(titleFormat);
            Console.WriteLine();

            Title();
        } // end method public manifest

        private void Title()
        {
            Console.WriteLine();
            string title = "ACME Umbrella Company";
            string address = "5552 Regal Spec Drive";
            string city = "Amityville, CO, 65397";
            string titleFormat = String.Format("{0,30}", title);
            string addressFormat = String.Format("{0,17}", address);
            string cityFormat = String.Format("{0,28 }", city);
            Console.WriteLine(titleFormat);
            Console.WriteLine(addressFormat);
            Console.WriteLine(cityFormat);
            Console.WriteLine();
            DataHeaders();
        } // end method private void title

        private void DataHeaders()
        {
            Underline();
            Console.WriteLine();
            String data = String.Format("{0,5} {1,25} {2,35} {3,30}", "QTY", "DESCRIPTION", "UNIT PRICE", "AMOUNT");
            Console.WriteLine(data);
            Underline();
            Console.WriteLine();
            Console.WriteLine();
        } // end method private void dataheaders

    private void Underline()
    {
        for (int i = 0; i < _formWidth; i++)
        {
            Console.Write("-");
        } // end method for
    } // end method void underline
} // end class
} // end namespace
