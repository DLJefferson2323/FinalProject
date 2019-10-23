using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.SingletonDevice
{
    public class SerialNumberGenerator
    {
        public class EReaderFacade
        {
            public void PrepareForSale(IReader reader)
            {
                ReaderRegistration reg = new ReaderRegistration(reader);
                reg.AllocateReaderNumber();

                ReaderDocumentation.PrintBrochure(reader);

                reader.CleanFrame();
                reader.CleanScreen();
                reader.TestOS();
            } // end method prepare for sale
        } // end class
} // end namespace
