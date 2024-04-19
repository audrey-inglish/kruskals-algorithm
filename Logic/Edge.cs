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
        public string Name { get => $"{Source.Name.ToString()}" + $"{Destination.Name.ToString()}"; }

        public Edge(int weight, Vertex src, Vertex dest)
        {
           
            Weight = weight;
            Source = src;
            Destination = dest;
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
