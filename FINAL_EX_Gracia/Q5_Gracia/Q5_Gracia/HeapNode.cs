using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_Gracia
{
    internal class HeapNode
    {
        public int Vertex { get; set; }
        public int Distance { get; set; }

        public HeapNode(int vertex, int distance)
        {
            Vertex = vertex;
            Distance = distance;
        }
    }
}
