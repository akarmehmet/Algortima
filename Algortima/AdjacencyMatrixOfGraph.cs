using System;
using System.Text;

namespace Algortima
{
	public class AdjacencyMatrixOfGraph
	{
		private bool[,] adjMatrix;
		private int numVertices;

		public AdjacencyMatrixOfGraph(int v)
		{
			numVertices = v;
			adjMatrix = new bool[numVertices, numVertices];
		}

		public void AddEdge(int i , int j)
		{
			adjMatrix[i, j] = true;
			adjMatrix[j, i] = true;
		}

        public void RemoveEdge(int i, int j)
        {
            adjMatrix[i, j] = false;
            adjMatrix[j, i] = false;
        }

		public string toString()
		{
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < numVertices; i++)
			{
				sb.Append(i + ": ");

				for (int j = 0; j < adjMatrix.GetValue(0).; j++)
				{

				}

				foreach (var j in adjMatrix.GetValue(i))
					sb.Append(j ? 1 : 0 + " ");
			}

			sb.Append("\n");

			return sb.ToString();
		}
    }
}

