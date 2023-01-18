using System;
namespace Algortima
{
	public class AdjacencyListGraph
	{
		private int numVertices;
		private Dictionary<int, List<int>> AdjacencyListOfVertices;

		public AdjacencyListGraph(int v)
		{
			numVertices = v;
			AdjacencyListOfVertices = new Dictionary<int, List<int>>();
		}

		public void AddAdge(int vertice,int adjacencyVertice)
		{
			if (!AdjacencyListOfVertices.ContainsKey(vertice))
				AdjacencyListOfVertices.Add(vertice, new List<int>());

			if (AdjacencyListOfVertices[vertice].Contains(adjacencyVertice))
				return;

			AdjacencyListOfVertices[vertice].Add(adjacencyVertice);
        }

    }
}

