// See https://aka.ms/new-console-template for more information

using Q4_Gracia;
static void Main()
{
    DirectedGraph directedGraph = new DirectedGraph(8);

    int[,] adjacencyMatrix = new int[,]
    {
            {0, 1, 0, 0, 0, 0, 0, 1},
            {0, 0, 1, 0, 0, 0, 1, 0},
            {0, 0, 0, 1, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 1, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 1, 0, 0, 0},
            {0, 1, 0, 0, 0, 0, 0, 1},
            {0, 0, 0, 0, 0, 1, 1, 0},
    };

    directedGraph.SetMatrix(adjacencyMatrix);

    Console.WriteLine("DFS starting from 'R' (Red):");
    directedGraph.DFS(0); // 'R' is at index 0
}