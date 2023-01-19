using Algortima.Graph;

namespace Algortima;
class Program
{
    
    static void Main(string[] args)
    {
        //ImplementKruskal();
        //ImplementPrim();
        ImplementDijkstra();
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

