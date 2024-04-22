using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Vertex
    {
        //private char name;
        public char Name { get; }
        public int Rank { get; set; } //rank is used when you want to union sets and limit the depth of the overall tree
        public Vertex Root { get; set; }
        public (int x, int y) Location { get; set; }


        public Vertex(char name)
        {
            Name = name;
            Rank = 0;
            this.Root = this;
        }

        public Vertex GetRoot()
        {
            //using recursion to move up the tree until the root is found
            if (this.Root != this) //am I my own parent?
            {
                this.Root = this.Root.GetRoot();
            }
            return this.Root;
        }

        public static void Join(Vertex root1, Vertex root2)
        {
            // Using rank comparisons to minimize the depth of the tree
            if (root1.Rank < root2.Rank)
            {
                root1.Root = root2; // Make root2 the parent of root1 if root1 has a lower rank
            }
            else if (root1.Rank > root2.Rank)
            {
                root2.Root = root1;
            }
            else // The roots have equal rank
            {
                root2.Root = root1; // Arbitrarily choose root1 as the parent of root2
                root1.Rank++; // Increment the rank of root1 to maintain balance
            }
        }

    }
}
