using System;

namespace src.dataStructures.graph
{
    public class Edge<T>
    {
        private bool IsDirected { get; set; } = false;
        private Vertex<T> vertex1;
        private Vertex<T> vertex2;
        private int weight;

       public Edge(Vertex<T> vertex1, Vertex<T> vertex2)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
        }
        public Edge(Vertex<T> vertex1, Vertex<T> vertex2, bool isDirected, int weight)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.weight = weight;
            this.IsDirected = isDirected;
        }

        public Edge(Vertex<T> vertex1, Vertex<T> vertex2, bool isDirected)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.IsDirected = isDirected;
        }

        public Vertex<T> getVertex1() => vertex1;

        public Vertex<T> getVertex2() => vertex2;


        public int getWeight() => weight;

        public bool isDirected() => IsDirected;

        public String toString()
        {
            return $"Edge [isDirected=" + IsDirected + ", vertex1=" + vertex1
                    + ", vertex2=" + vertex2 + ", weight=" + weight + "]";
        }
    }
}