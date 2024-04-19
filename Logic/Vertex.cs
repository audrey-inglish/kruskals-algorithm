using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Vertex
    {
        private char name;
        public char Name { get; }
        public int Rank { get; set; } //rank is used when you want to union sets and limit the depth of the overall tree
        public Vertex Root { get; set; }


        public Vertex(char _name)
        {
            name = _name;
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
            //using rank comparisons to minimize the depth of the tree
            if(root2.Rank < root1.Rank)
            {
                root2.Root = root1; //make root1 the parent of root2 if root2 has a lower rank
            }
            else if(root2.Rank > root1.Rank)
            {
                root1.Root = root2;
            }
            else //the roots are equal
            {
                root2.Rank++;
            }
        }
    }
}
