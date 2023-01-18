namespace Algortima;
class Program
{
    static void Main(string[] args)
    {
        AdjacencyMatrixOfGraph g = new AdjacencyMatrixOfGraph(4);

        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);

        Console.WriteLine(g.toString());
    }
}

