using System.Collections.Generic;
using src.dataStructures.graph;

namespace src.algorithms.search
{
    public class CycleInDirectedGraph<T>
    {
        private LinkedList<Vertex<T>> whiteSet = new LinkedList<Vertex<T>>();
        private LinkedList<Vertex<T>> graySet = new LinkedList<Vertex<T>>();
        private LinkedList<Vertex<T>> blackSet = new LinkedList<Vertex<T>>();

        public bool hasCycle(Graph<T> graph)
        {
            foreach (var vertex in graph.getAllVertex())
            {
                whiteSet.AddLast(vertex);
            }

            while (whiteSet.Count != 0)
            {
                var current = next();
                if (dfs(current, whiteSet, graySet, blackSet))
                {
                    return true;
                }
            }
            return false;

        }
        private Vertex<T> next()
        {
            var next = whiteSet.First.Value;
            whiteSet.RemoveFirst();
            return next;
        }
        private bool dfs(Vertex<T> current, LinkedList<Vertex<T>> whiteSet,
                        LinkedList<Vertex<T>> graySet, LinkedList<Vertex<T>> blackSet)
        {
            //move current to gray set from white set and then explore it.
            moveVertex(current, whiteSet, graySet);
            foreach (Vertex<T> neighbor in current.getAdjacentVertexes())
            {
                //if in black set means already explored so continue.
                if (blackSet.Contains(neighbor))
                {
                    continue;
                }
                //if in gray set then cycle found.
                if (graySet.Contains(neighbor))
                {
                    return true;
                }
                if (dfs(neighbor, whiteSet, graySet, blackSet))
                {
                    return true;
                }
            }
            //move vertex from gray set to black set when done exploring.
            moveVertex(current, graySet, blackSet);
            return false;
        }
        private void moveVertex(Vertex<T> vertex, LinkedList<Vertex<T>> sourceSet,
                            LinkedList<Vertex<T>> destinationSet)
        {
            sourceSet.Remove(vertex);
            destinationSet.AddLast(vertex);
        }
    }
}