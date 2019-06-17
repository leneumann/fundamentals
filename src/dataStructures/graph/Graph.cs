using System.Collections.Generic;

namespace src.dataStructures.graph
{
    public class Graph<T>
    {
        private List<Edge<T>> allEdges;
        private List<Vertex<T>> allVertex;
        bool isDirected = false;

        public Graph(bool isDirected)
        {
            allEdges = new List<Edge<T>>();
            allVertex = new List<Vertex<T>>();
            this.isDirected = isDirected;
        }
        public List<Vertex<T>> getAllVertex()
        {
            return allVertex;
        }
        public void addEdge(long id1, long id2, int weight)
        {
            Vertex<T> vertex1 = null;
            if (allVertex.Exists(x => x.getId() == id1))
                vertex1 = allVertex.Find(x => x.getId() == id1);
            else
            {
                vertex1 = new Vertex<T>(id1);
                allVertex.Add(vertex1);
            }
            Vertex<T> vertex2 = null;
            if (allVertex.Exists(x => x.getId() == id2))
                vertex2 = allVertex.Find(x => x.getId() == id2);
            else
            {
                vertex2 = new Vertex<T>(id2);
                allVertex.Add(vertex2);
            }

            Edge<T> edge = new Edge<T>(vertex1, vertex2, isDirected, weight);
            allEdges.Add(edge);
            vertex1.addAdjacentVertex(edge, vertex2);
            if (!isDirected)
                vertex2.addAdjacentVertex(edge, vertex1);
        }
    }
}