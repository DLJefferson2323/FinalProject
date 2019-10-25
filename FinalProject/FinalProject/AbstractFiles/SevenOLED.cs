using FinalProject.BaseFiles;


namespace FinalProject.AbstractFiles
{
    public abstract class SevenOLED : AbstractReaderBase
    {
        public override decimal Price { get; } = 99.00m;

        public SevenOLED(ReaderColor color)
            : base(color, true) { }

        public SevenOLED()
            : this(ReaderColor.Bronze) { }
 
    } // end class
} // end namespace
