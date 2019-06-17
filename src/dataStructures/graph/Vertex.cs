using System;
using System.Collections.Generic;

namespace src.dataStructures.graph
{
    public class Vertex<T>
    {
        string label;
        long id;
        private T data;
        private List<Edge<T>> edges = new List<Edge<T>>();
        private List<Vertex<T>> adjacentVertex = new List<Vertex<T>>();

        public Vertex(long id) => this.id = id;
        public long getId() => id;
        public void setData(T data) => this.data = data;
        public T getData() => data;
        public void addAdjacentVertex(Edge<T> e, Vertex<T> v)
        {
            edges.Add(e);
            adjacentVertex.Add(v);
        }
        public String toString() => id.ToString();
        public List<Vertex<T>> getAdjacentVertexes() => adjacentVertex;
        public List<Edge<T>> getEdges() => edges;
        public int getDegree() => edges.Count;
    }
}