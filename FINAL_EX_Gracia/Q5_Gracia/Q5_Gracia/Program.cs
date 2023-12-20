// See https://aka.ms/new-console-template for more information

using Q5_Gracia;
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

    int startVertex = 0; // 'R' is at index 0
    int endVertex = 3;   // 'G' is at index 3

    // Find and print the shortest path from 'R' to 'G'
    List<int> shortestPath = directedGraph.DijkstraShortestPath(startVertex, endVertex);
}

