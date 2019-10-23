using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.BaseFiles
{
    public interface IReader
    {
        IReader GetReader { get; } 
        ReaderColor ColorType { get; }

        decimal Price { get; }
        void Color(ReaderColor color);

        void CleanFrame();
        void CleanScreen();
        void TestOS();
    } // end class
} // end namespace
