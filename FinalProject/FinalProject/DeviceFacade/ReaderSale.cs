using System;
using System.Collections.Generic;
using System.Text;
using static FinalProject.DeviceFacade.ReaderRegistration;

namespace FinalProject.DeviceFacade
{
    public class ReaderSale
    {
        public void PrepareForSale(IReader reader)
        {
            ReaderRegistration reg = new Registration(reader);
            reg.AllocateReaderNumber();

            ReaderDocumentation.PrintBrochure(reader);

            reader.CleanFrame();
            reader.CleanScreen();
            reader.TestOS();
        } // end method prepare for sale
    } // end class
} // end namespace
