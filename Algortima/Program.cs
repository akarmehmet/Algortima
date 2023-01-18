using Algortima.Graph;

namespace Algortima;
class Program
{
    static void Main(string[] args)
    {
        Graph<int> graph = new Graph<int>(true, true);
        Node<int> n1 = graph.AddNode(1); 
        Node<int> n8 = graph.AddNode(8);
        graph.AddEdge(n1, n8, 9); 
        
        List<Node<int>> dfsNodes = graph.DFS();
        dfsNodes.ForEach(n => Console.WriteLine(n));
    }
}

