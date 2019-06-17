using System.Collections.Generic;
using src.dataStructures.graph;

namespace src.algorithms.search
{
    public class BreadthFirst<T>
    {
        public string search(Graph<T> graph)
        {
            string result = "";
            List<long> visited = new List<long>();
            LinkedList<Vertex<T>> queue = new LinkedList<Vertex<T>>();
            foreach (var vertex in graph.getAllVertex())
            {
                if (!visited.Contains(vertex.getId()))
                {
                    queue.AddLast(vertex);
                    visited.Add(vertex.getId());
                    while (queue.Count != 0)
                    {
                        var vq = queue.First;
                        queue.Remove(vq);
                        result += vq.Value.getId() + " ";
                        foreach (var adjacentVertex in vq.Value.getAdjacentVertexes())
                        {
                            if (!visited.Contains(adjacentVertex.getId()))
                            {
                                queue.AddLast(adjacentVertex);
                                visited.Add(adjacentVertex.getId());
                            }
                        }
                    }
                }

            }
            return result;
        }
    }
}