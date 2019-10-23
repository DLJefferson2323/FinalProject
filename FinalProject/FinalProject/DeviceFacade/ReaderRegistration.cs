using FinalProject.SingletonDevice;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.DeviceFacade
{
    public class ReaderRegistration
    {
        public class Registration
        {
            private IReader _reader;

            public Registration(IReader reader) 
            {
                this._reader = reader;
            } // end method registration

            public void AllocateReaderNumber()
            {
                Console.WriteLine("Allocating EReader Number " + SerialNumberGenerator.Instance.NextSerial);
            } // end method allocated ereader number
        } // end class
} // end namespace
