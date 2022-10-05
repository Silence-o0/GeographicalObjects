namespace GeographicalObjects
{
    interface IGeographicalObjects
    {
        public void displayInfo();
    }

    class River : IGeographicalObjects
    {
        double streamSpeed;                //  sm/sec
        double generalLength;
        public void displayInfo()
        {
            Console.WriteLine($"Stream speed = {this.streamSpeed}");
            Console.WriteLine($"General length = {this.generalLength}");
        }
    }

    class Mountain : IGeographicalObjects
    {
        string highestPoint;
        public void displayInfo()
        {
            Console.WriteLine($"The highest point is {this.highestPoint}");
        }
    }
}
