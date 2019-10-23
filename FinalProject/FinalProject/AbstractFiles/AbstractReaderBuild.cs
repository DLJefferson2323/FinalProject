using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.AbstractFiles
{
    public abstract class AbstractReaderBuild
    {
        public abstract IReaderFrame CreateReaderFrame();
        public abstract IReaderScreen CreateReaderScreen();
    } // end class
} // end namespace
