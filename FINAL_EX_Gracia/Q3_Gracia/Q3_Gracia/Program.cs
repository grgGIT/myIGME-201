// See https://aka.ms/new-console-template for more information

using Q3_Gracia;

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

        // Displaying the adjacency matrix
        directedGraph.DisplayMatrix();
    }
