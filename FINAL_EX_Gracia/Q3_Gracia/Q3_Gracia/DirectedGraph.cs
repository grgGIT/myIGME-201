using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_Gracia
{
    public class DirectedGraph
    {
        private int vertices;
        private int[,] adjacencyMatrix;
        private char[] labels = { 'R', 'B', 'Y', 'G', 'P', 'O', 'C', 'K' };

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

        public void DisplayMatrix()
        {
            Console.WriteLine("Adjacency Matrix:");
            Console.Write("    ");
            for (int i = 0; i < vertices; i++)
            {
                Console.Write($"{labels[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < vertices; i++)
            {
                Console.Write($"{labels[i]} | ");
                for (int j = 0; j < vertices; j++)
                {
                    Console.Write($"{adjacencyMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
