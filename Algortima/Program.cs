using Algortima.Graph;

namespace Algortima;
class Program
{
    
    static void Main(string[] args)
    {
        ImplementQuickSort();
        //ImplementInsertionSort();
        //ImplementKruskal();
        //ImplementPrim();
        //ImplementDijkstra();
        //ImplementSelfDijkstra();
        //ImplementDfs();
    }

    private static void ImplementQuickSort()
    {
        int[] arr = { 10, 7, 8, 9, 1, 5 };
        int n = arr.Length;

       SortingAlgorithm.quickSort(arr, 0, n - 1);
    }

    private static void ImplementInsertionSort()
    {
        int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
        SortingAlgorithm.InsertionSort(integerValues);
        Console.WriteLine(string.Join(" | ", integerValues));

        string[] stringValues = { "Mary", "Marcin", "Ann", "James",
       "George", "Nicole" };
        SortingAlgorithm.InsertionSort(stringValues);
        Console.WriteLine(string.Join(" | ", stringValues));
    }

    private static void ImplementSelectionSort()
    {
        int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
        SortingAlgorithm.SelectionSort(integerValues);
        Console.WriteLine(string.Join(" | ", integerValues));

        string[] stringValues = { "Mary", "Marcin", "Ann", "James",
       "George", "Nicole" };
        SortingAlgorithm.SelectionSort(stringValues);
        Console.WriteLine(string.Join(" | ", stringValues));
    }

    private static void ImplementDfs()
    {
        Graph<string> graph = new Graph<string>(false, true);
        Node<string> A = graph.AddNode("A");
        Node<string> B = graph.AddNode("B");
        Node<string> C = graph.AddNode("C");
        Node<string> D = graph.AddNode("D");
        Node<string> E = graph.AddNode("E");

        graph.AddEdge(A, B, 10);
        graph.AddEdge(A, C, 3);
        graph.AddEdge(B, C, 4);
        graph.AddEdge(B, D, 2);
        graph.AddEdge(C, D, 8);
        graph.AddEdge(C, E, 2);
        graph.AddEdge(E, D, 9);

        List<Node<string>> path =  graph.DFSStack();
        path.ForEach(e => Console.WriteLine(e.ToString()));
    }

    private static void ImplementSelfKruskal()
    {
        /* Let us create following weighted graph
                   10
               0--------1
               | \ |
           6| 5\ |15
               | \ |
               2--------3
                   4 */
        int V = 4; // Number of vertices in graph
        int E = 5; // Number of edges in graph
        KruskalBst graph = new KruskalBst(V, E);

        // add edge 0-1
        graph.edge[0].src = 0;
        graph.edge[0].dest = 1;
        graph.edge[0].weight = 10;

        // add edge 0-2
        graph.edge[1].src = 0;
        graph.edge[1].dest = 2;
        graph.edge[1].weight = 6;

        // add edge 0-3
        graph.edge[2].src = 0;
        graph.edge[2].dest = 3;
        graph.edge[2].weight = 5;

        // add edge 1-3
        graph.edge[3].src = 1;
        graph.edge[3].dest = 3;
        graph.edge[3].weight = 15;

        // add edge 2-3
        graph.edge[4].src = 2;
        graph.edge[4].dest = 3;
        graph.edge[4].weight = 4;

        // Function call
        graph.KruskalMST();
    }

    private static void ImplementSelfDijkstra()
    {
        /* Let us create the example
               graph discussed above */
        int[,] graph
            = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                            { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                            { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                            { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                            { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                            { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                            { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                            { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                            { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
        DijkstraBst t = new DijkstraBst();

        // Function call
        t.dijkstra(graph, 0);
    }

    private static void ImplementDijkstra()
    {
        Graph<string> graph = new Graph<string>(false, true);
        Node<string> A = graph.AddNode("A");
        Node<string> B = graph.AddNode("B");
        Node<string> C = graph.AddNode("C");
        Node<string> D = graph.AddNode("D");
        Node<string> E = graph.AddNode("E");

        graph.AddEdge(A, B, 10);
        graph.AddEdge(A, C, 3);
        graph.AddEdge(B, C, 4);
        graph.AddEdge(B, D, 2);
        graph.AddEdge(C, D, 8);
        graph.AddEdge(C, E, 2);
        graph.AddEdge(E, D, 9);

        List<Edge<string>> path = graph.GetShortestPathDijkstra(A, E);
        path.ForEach(e => Console.WriteLine(e.ToString()));
    }

   private static void ImplementPrim()
    {
        Graph<string> graph = new Graph<string>(false, true);
        Node<string> A = graph.AddNode("A");
        Node<string> B = graph.AddNode("B");
        Node<string> C = graph.AddNode("C");
        Node<string> D = graph.AddNode("D");
        Node<string> E = graph.AddNode("E");

        graph.AddEdge(A, B, 10);
        graph.AddEdge(A, C, 3);
        graph.AddEdge(B, C, 4);
        graph.AddEdge(B, D, 2);
        graph.AddEdge(C, D, 8);
        graph.AddEdge(C, E, 2);
        graph.AddEdge(E, D, 9);

        List<Edge<string>> mstPrim = graph.MinimumSpanningTreePrim();
        Console.WriteLine();
        mstPrim.ForEach(e => Console.WriteLine(e));
        
    }

    private static void ImplementKruskal()
    {
        Graph<string> graph = new Graph<string>(false, true);
        Node<string> A = graph.AddNode("A");
        Node<string> B = graph.AddNode("B");
        Node<string> C = graph.AddNode("C");
        Node<string> D = graph.AddNode("D");
        Node<string> E = graph.AddNode("E");

        graph.AddEdge(A, B, 10);
        graph.AddEdge(A, C, 3);
        graph.AddEdge(B, C, 4);
        graph.AddEdge(B, D, 2);
        graph.AddEdge(C, D, 8);
        graph.AddEdge(C, E, 2);
        graph.AddEdge(E, D, 9);



        List<Edge<string>> mstKruskal = graph.MinimumSpanningTreeKruskal();
        mstKruskal.ForEach(e => Console.WriteLine(e));
        Console.WriteLine( mstKruskal.Sum(s => s.Weight));
    }
}

