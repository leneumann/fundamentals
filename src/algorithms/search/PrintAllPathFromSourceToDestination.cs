using System.Collections.Generic;
using src.dataStructures.graph;

namespace src.algorithms.search
{
    public class PrintAllPathFromSourceToDestination
    {
        public void printPath(Graph<int> graph, Vertex<int> start, Vertex<int> destination)
        {
            LinkedList<Vertex<int>> visiting = new LinkedList<Vertex<int>>();
            printPath(visiting, destination, start);
        }

        private void printPath(LinkedList<Vertex<int>> visiting, Vertex<int> destination, Vertex<int> current)
        {
            if (visiting.Contains(current))
            {
                return;
            }
            if (destination.Equals(current))
            {
                foreach (var v in visiting)
                {
                    System.Console.Write($"{v.getId()} +  ");
                }
                System.Console.WriteLine(destination.getId());
                return;
            }

            visiting.AddLast(current);
            foreach (var child in current.getAdjacentVertexes())
            {
                printPath(visiting, destination, child);
            }
            visiting.Remove(current);
        }
    }
}