using FinalProject.BaseFiles;


namespace FinalProject.AbstractFiles
{
    public class NineInch : AbstractReaderBase
    {
        public override decimal Price { get; } = 99.00m;
        public override string EReaderDescript { get; } = "9 inch EInk";
        public NineInch(ReaderColor color)
            : base(color, false) { }

        public NineInch()
            : this(ReaderColor.Candy_Blue) { }

    } // end class
} // end namespace
