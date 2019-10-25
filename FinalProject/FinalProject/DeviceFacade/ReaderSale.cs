using FinalProject.BaseFiles;
using System;
using System.Collections.Generic;
using System.Text;
using static FinalProject.DeviceFacade.ReaderRegistration;

namespace FinalProject.DeviceFacade
{
    public class ReaderSale
    {
        public ReaderRegistration  Register { get; private set; }

        public void PrepareForSale(IReader reader)
        {
            Register = new ReaderRegistration(reader);
            //AllocateEReaderNumber();

            ReaderDocumentation.PrintBrochure(reader);

            reader.CleanFrame();
            reader.CleanScreen();
            reader.TestOS();
        } // end method prepare for sale
    } // end class
} // end namespace
