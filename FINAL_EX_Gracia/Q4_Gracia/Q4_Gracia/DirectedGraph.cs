using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_Gracia
{
    internal class DirectedGraph
    {
        private int vertices;
        private int[,] adjacencyMatrix;
        private string[] labels = { "Red", "Blue", "Yellow", "Green", "Purple", "Orange", "Cyan", "Gray" };

        public DirectedGraph(int vertices)
        {
            this.vertices = vertices;
            this.adjacencyMatrix = new int[vertices, vertices];
        }

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

        public void DFS(int startVertex)
        {
            bool[] visited = new bool[vertices];
            Stack<int> stack = new Stack<int>();

            stack.Push(startVertex);

            while (stack.Count > 0)
            {
                int vertex = stack.Pop();

                if (!visited[vertex])
                {
                    Console.Write($"{labels[vertex]} "); // Output the color
                    visited[vertex] = true;

                    for (int i = 0; i < vertices; i++)
                    {
                        if (adjacencyMatrix[vertex, i] == 1 && !visited[i])
                        {
                            stack.Push(i);
                        }
                    }
                }
            }
        }
    }
}
