namespace Logic
{
    public class Edge
    {
        public Vertex Source { get; set; }
        public Vertex Destination { get; set; }
        public int Weight { get; set; }
        public string Name { get => $"{Source.Name}" + $"{Destination.Name}"; }


        public int CompareTo(Edge other)
        {
            return this.Weight - other.Weight;
        }
    }
}
