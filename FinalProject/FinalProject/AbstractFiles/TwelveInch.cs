﻿using FinalProject.BaseFiles;


namespace FinalProject.AbstractFiles
{
    public class TwelveInch : AbstractReaderBase
    {
        public override decimal Price { get; } = 120.00m;

        public TwelveInch(ReaderColor color)
            : base(color, false) { }

        public TwelveInch()
            : this(ReaderColor.Rose_Gold) { }

    } // end class
}
