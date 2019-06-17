using System.Collections.Generic;
using src.dataStructures.graph;

namespace src.algorithms.search
{
    public class DepthFirst<T>
    {
        public string search(Graph<T> graph)
        {
            string result ="";
            List<long> visited = new List<long>();
            foreach (var vertex in graph.getAllVertex())
            {
                if(!visited.Contains(vertex.getId()))
                  result += innerSearch(vertex, visited);
            }
            return result;
        }

        private string innerSearch(Vertex<T> v, List<long> visited)
        {
            string result ="";
            visited.Add(v.getId());
            result += v.getId() + " ";
            foreach (var vertex in v.getAdjacentVertexes())
            {
                if(!visited.Contains(vertex.getId()))
                    result += innerSearch(vertex, visited);
            }
            return result;
        }
    }
}