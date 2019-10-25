using FinalProject.BaseFiles;


namespace FinalProject.AbstractFiles
{
    public abstract class AbstractReaderBase : IReader
    {
        // Add the base objects the child class EInk7, 9  and 12 also OLED7, 9 and 12 will call from
        public string AndroidOS { get; set; }
        public string GPS { get; set; }
        public string WiFi { get; set; }
        public string HeadPhoneJack { get; set; }
        public string SDCardReader { get; set; }
        public string Charger { get; set; }
        public string Manual { get; set; }
        public string Headphones { get; set; }
        public bool PlayGames { get; set; }
        

        public string ColorDisplay { get; set; }

        public ReaderColor ColorType { get; private set; }
        public abstract decimal Price { get; }

        public AbstractReaderBase(ReaderColor color, bool playGames)
        {
            ColorType = color;
            PlayGames = playGames;
        } // end method abstract reader

        public override string ToString()
        {
            return this.GetType().Name + " EReader Color is " + ColorType + " and costs $"
                + Price;
        } // end method override
    } // end class
} // end namespace
