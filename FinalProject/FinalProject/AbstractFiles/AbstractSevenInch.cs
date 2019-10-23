using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.AbstractFiles
{
    public abstract class AbstractSevenInch : AbstractReader
    {
        public override decimal Price { get; } = 740.00m;

            public AbstractSevenInch(ReaderColor color, IReader reader)
                : base(color, reader) { }

            public AbstractSevenInch(IReader reader)
                : this(ReaderColor.Black, reader) { }

        } // end class
} // end namespace
