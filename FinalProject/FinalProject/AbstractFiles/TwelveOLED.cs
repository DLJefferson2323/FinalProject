using FinalProject.BaseFiles;


namespace FinalProject.AbstractFiles
{
    public abstract class TwelveOLED : AbstractReaderBase
    {
        public override decimal Price { get; } = 150.00m;

        public TwelveOLED(ReaderColor color)
            : base(color, true) { }

        public TwelveOLED()
            : this(ReaderColor.Candy_Apple) { }
 
    } // end class
} // end namespace
