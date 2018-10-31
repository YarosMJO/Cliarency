namespace Clearence
{
    public enum EngineType
    {
        VEE = 10,
        INLINE = 20
    }
    public class Engine
    {
        public int Year { get; set; }
        public double Volume { get; set; }
        public EngineType Type { get; set; }

        public Engine(double Volume,int Year, EngineType Type)
        {
            this.Volume = Volume;
            this.Year = Year;
            this.Type = Type;
        }

        public double GetExcizeDuty() => Year * Volume * (int)Type;
    }
}