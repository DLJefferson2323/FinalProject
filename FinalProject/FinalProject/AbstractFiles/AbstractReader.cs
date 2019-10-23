using FinalProject.BaseFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.AbstractFiles
{
    public abstract class AbstractReader : IReader
    {
        public IReader GetReader { get; }
        public ReaderColor ColorType { get; private set; }
        public abstract decimal Price { get; }
        public abstract void Color(ReaderColor color);

        public AbstractReader(ReaderColor color, IReader reader)
        {
            ColorType = color;
            GetReader = reader;
        } // end method abstract reader

        public AbstractReader(IReader reader)
            : this(ReaderColor.Black, reader) { }

        public virtual void CleanFrame()
        {
            Console.WriteLine("Cleaning Frame...");
        } // end method virtual void clean frame

        public virtual void CleanScreen()
        {
            Console.WriteLine("Cleaning Screen...");
        } // end method virtual void air tires

        public virtual void TestOS()
        {
            Console.WriteLine("Testing Operating System...");
        } // end method virtual void test ride

        public override string ToString()
        {
            return this.GetType().Name + " EReader Color is " + ColorType + " and costs $"
                + Price;
        } // end method override

    } // end class
} // end namespace
