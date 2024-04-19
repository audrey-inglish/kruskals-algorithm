namespace Logic
{
    public class Edge
    {
        private string name;
        private int weight;
        private Vertex src;
        private Vertex dest;

        public Vertex Source { get; set; }
        public Vertex Destination { get; set; }
        public int Weight { get; set; }
        public string Name { get => $"{Source.Name}" + $"{Destination.Name}"; }

        public Edge(string name, int weight, Vertex src, Vertex dest)
        {
            this.name = name;
            this.weight = weight;
            this.src = src;
            this.dest = dest;
        }

        public int CompareTo(Edge other)
        {
            int weightComparison = this.Weight.CompareTo(other.Weight);
            //if (weightComparison != 0)
            //{
                return weightComparison;
            //}
            //return this.Name.CompareTo(other.Name);

            //above commented lines are optional -- I think I'll account for equal comparisons somewhere else
        }



    }
}
