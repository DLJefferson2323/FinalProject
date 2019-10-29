using FinalProject.BaseFiles;


namespace FinalProject.AbstractFiles
{
    public class NineOLED : AbstractReaderBase
    {
        public override decimal Price { get; } = 125.00m;

        public NineOLED(ReaderColor color)
            : base(color, true) { }

        public NineOLED()
            : this(ReaderColor.Orange) { }
 
    } // end class
} // end namespace
