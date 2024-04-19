namespace Logic
{
    public class Edge
    {
        public char Source { get; set; }
        public char Destination { get; set; }
        public int Weight { get; set; }
        public string Name { get => $"{Source}" + $"{Destination}"; }


        public int CompareTo(Edge other)
        {
            return this.Weight - other.Weight;
        }
    }
}
