using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_Gracia
{
    internal class DirectedGraph
    {
        private int vertices;
        private int[,] adjacencyMatrix;
        private string[] labels = { "Red", "Blue", "Yellow", "Green", "Purple", "Orange", "Cyan", "Gray" };

        // Constructor to initialize the graph with a given number of vertices
        public DirectedGraph(int vertices)
        {
            this.vertices = vertices;
            this.adjacencyMatrix = new int[vertices, vertices];
        }

        // Sets the adjacency matrix based on a provided matrix
        public void SetMatrix(int[,] matrix)
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    adjacencyMatrix[i, j] = matrix[i, j];
                }
            }
        }

        // Finds the shortest path from a start vertex to an end vertex using Dijkstra's algorithm
        public List<int> DijkstraShortestPath(int startVertex, int endVertex)
        {
            int[] distance = new int[vertices];
            int[] parent = new int[vertices];
            bool[] visited = new bool[vertices];

            for (int i = 0; i < vertices; i++)
            {
                distance[i] = int.MaxValue;
                parent[i] = -1;
            }

            distance[startVertex] = 0;

            MinHeap minHeap = new MinHeap(vertices);
            minHeap.Insert(new HeapNode(startVertex, 0));

            while (!minHeap.IsEmpty())
            {
                HeapNode currentNode = minHeap.ExtractMin();
                int currentVertex = currentNode.Vertex;
                visited[currentVertex] = true;

                for (int i = 0; i < vertices; i++)
                {
                    if (adjacencyMatrix[currentVertex, i] != 0 && !visited[i])
                    {
                        int newDistance = distance[currentVertex] + adjacencyMatrix[currentVertex, i];

                        if (newDistance < distance[i])
                        {
                            distance[i] = newDistance;
                            parent[i] = currentVertex;
                            minHeap.Insert(new HeapNode(i, distance[i]));
                        }
                    }
                }
            }

            // Reconstruct the path
            List<int> path = new List<int>();
            int current = endVertex;
            while (current != -1)
            {
                path.Insert(0, current);
                current = parent[current];
            }

            return path;
        }
    }
}
