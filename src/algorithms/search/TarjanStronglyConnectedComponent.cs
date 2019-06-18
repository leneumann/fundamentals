using System;
using System.Collections.Generic;
using src.dataStructures.graph;

namespace src.algorithms.search
{
    public class TarjanStronglyConnectedComponent
    {
        private Dictionary<Vertex<int>, int> visitedTime;
        private Dictionary<Vertex<int>, int> lowTime;
        private LinkedList<Vertex<int>> onStack;
        private LinkedList<Vertex<int>> stack;
        private LinkedList<Vertex<int>> visited;
        private List<LinkedList<Vertex<int>>> result;
        private int time;
        public List<LinkedList<Vertex<int>>> scc(Graph<int> graph)
        {
            //keeps the time when every vertex is visited
            time = 0;

            //keeps map of vertex to time it was visited
            visitedTime = new Dictionary<Vertex<int>, int>();

            //keeps map of vertex and time of first vertex visited in current DFS
            lowTime = new Dictionary<Vertex<int>, int>();

            //tells if a vertex is in stack or not
            onStack = new LinkedList<Vertex<int>>();

            //stack of visited vertices
            stack = new LinkedList<Vertex<int>>();

            //tells if vertex has ever been visited or not. This is for DFS purpose.
            visited = new LinkedList<Vertex<int>>();

            //stores the strongly connected components result;
            result = new List<LinkedList<Vertex<int>>>();

            //start from any vertex in the graph.
            foreach (var vertex in graph.getAllVertex())
            {
                if (visited.Contains(vertex))
                {
                    continue;
                }
                sccUtil(vertex);
            }

            return result;

        }

        private void sccUtil(Vertex<int> vertex)
        {
            visited.AddLast(vertex);
            visitedTime.Add(vertex, time);
            lowTime.Add(vertex, time);
            time++;
            stack.AddFirst(vertex);
            onStack.AddLast(vertex);

            foreach (var child in vertex.getAdjacentVertexes())
            {
                //if child is not visited then visit it and see if it has link back to vertex's ancestor. In that case update
                //low time to ancestor's visit time
                if (!visited.Contains(child))
                {
                    sccUtil(child);
                    //sets lowTime[vertex] = min(lowTime[vertex], lowTime[child]);
                    lowTime[vertex] = Math.Min(lowTime[vertex], lowTime[child]);
                    // lowTime.compute(vertex, (v, low)->
                    //     Math.min(low, lowTime.get(child))

                } //if child is on stack then see if it was visited before vertex's low time. If yes then update vertex's low time to that.
                else if (onStack.Contains(child))
                {
                    lowTime[vertex] = Math.Min(lowTime[vertex], visitedTime[child]);
                    //lowTime.compute(vertex, (v, low)->Math.min(low, visitedTime.get(child))
                }

            }
            //if vertex low time is same as visited time then this is start vertex for strongly connected component.
            //keep popping vertices out of stack still you find current vertex. They are all part of one strongly
            //connected component.
            if (visitedTime[vertex] == lowTime[vertex])
            {
                LinkedList<Vertex<int>> stronglyConnectedComponenet = new LinkedList<Vertex<int>>();
                Vertex<int> v;
                do
                {
                    v = stack.First.Value;
                    stack.Remove(v);
                    onStack.Remove(v);
                    stronglyConnectedComponenet.AddLast(v);
                } while (!vertex.Equals(v));
                result.Add(stronglyConnectedComponenet);
            }
        }
    }
}