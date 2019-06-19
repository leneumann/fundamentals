using System;
using System.Collections.Generic;
using src.dataStructures.graph;

namespace src.algorithms.search
{
    public class AlgorithmTw<T>
    {
        private LinkedList<Vertex<T>> stack = new LinkedList<Vertex<T>>();
        LinkedList<Vertex<T>> scheduled = new LinkedList<Vertex<T>>();
        private Vertex<T> _start { get; set; }
        private Vertex<T> _destination { get; set; }
        private int _maxDepth { get; set; }
        public void search(Graph<T> graph, Vertex<T> start, Vertex<T> destination, int maxDepth)
        {
            _start = start;
            _destination = destination;
            _maxDepth = maxDepth;
            LinkedList<Vertex<T>> visiting = new LinkedList<Vertex<T>>();
            scheduled.AddFirst(start);
            visiting.AddFirst(start);

            while (scheduled.Count > 0)
            {
                //Remove the schedule of first level
                stack.AddLast(scheduled.First.Value);
                scheduled.RemoveFirst();
                foreach (var adjacent in start.getAdjacentVertexes())
                {
                    visiting.AddLast(adjacent);
                    scheduled.AddFirst(adjacent);
                    depthFirst(adjacent);
                }
                //After visiting, remove from the queue
                visiting.RemoveFirst();
            }
        }

        private void depthFirst(Vertex<T> vertex)
        {
            LinkedList<Vertex<T>> visiting = new LinkedList<Vertex<T>>();
            LinkedList<Vertex<T>> scheduled = new LinkedList<Vertex<T>>();
            visiting.AddLast(vertex);
            stack.AddLast(vertex);
            while (scheduled.Count > 0)
            {
                //Remove the schedule of first level
                stack.AddLast(scheduled.First);
                scheduled.RemoveFirst();
                foreach (var adjacent in vertex.getAdjacentVertexes())
                {
                    visiting.AddLast(adjacent);
                    scheduled.AddFirst(adjacent);
                    depthFirst(adjacent);
                    if (adjacent.Equals(_destination) && stack.Count == _maxDepth)
                        System.Console.WriteLine("FOund");
                        stack.RemoveLast();
                }
                //After visiting, remove from the queue
                visiting.RemoveFirst();
            }
        }
    }
}