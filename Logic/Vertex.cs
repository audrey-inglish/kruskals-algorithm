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
    }
}
