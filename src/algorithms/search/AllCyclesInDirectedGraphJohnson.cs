using System;
using System.Collections.Generic;
using src.dataStructures.graph;

namespace src.algorithms.search
{
    public class AllCyclesInDirectedGraphJohnson
    {
        private LinkedList<Vertex<int>> blockedSet;
        private Dictionary<Vertex<int>, LinkedList<Vertex<int>>> blockedMap;
        private LinkedList<Vertex<int>> stack;
        private List<List<Vertex<int>>> allCycles;

        public List<List<Vertex<int>>> simpleCyles(Graph<int> graph)
        {
            blockedSet = new LinkedList<Vertex<int>>();
            blockedMap = new Dictionary<Vertex<int>, LinkedList<Vertex<int>>>();
            stack = new LinkedList<Vertex<int>>();
            allCycles = new List<List<Vertex<int>>>();
            long startIndex = 1;
            TarjanStronglyConnectedComponent tarjan = new TarjanStronglyConnectedComponent();
            while (startIndex <= graph.getAllVertex().Count)
            {
                Graph<int> subGraph = createSubGraph(startIndex, graph);
                List<LinkedList<Vertex<int>>> sccs = tarjan.scc(subGraph);
                //this creates graph consisting of strongly connected components only and then returns the
                //least indexed vertex among all the strongly connected component graph.
                //it also ignore one vertex graph since it wont have any cycle.
                Vertex<int> maybeLeastVertex = leastIndexSCC(sccs, subGraph);
                if (maybeLeastVertex != null)
                {
                    Vertex<int> leastVertex = maybeLeastVertex;
                    blockedSet.Clear();
                    blockedMap.Clear();
                    findCyclesInSCG(leastVertex, leastVertex);
                    startIndex = leastVertex.getId() + 1;
                }
                else
                {
                    break;
                }
            }
            return allCycles;
        }

        private Graph<int> createSubGraph(long startVertex, Graph<int> graph)
        {
            Graph<int> subGraph = new Graph<int>(true);
            foreach (Edge<int> edge in graph.getAllEdges())
            {
                if (edge.getVertex1().getId() >= startVertex && edge.getVertex2().getId() >= startVertex)
                {
                    subGraph.addEdge(edge.getVertex1().getId(), edge.getVertex2().getId(), edge.getWeight());
                }
            }
            return subGraph;
        }

        private Vertex<int> leastIndexSCC(List<LinkedList<Vertex<int>>> sccs, Graph<int> subGraph)
        {
            long min = int.MaxValue;
            Vertex<int> minVertex = null;
            LinkedList<Vertex<int>> minScc = null;
            foreach (var scc in sccs)
            {
                if (scc.Count == 1)
                {
                    continue;
                }
                foreach (var vertex in scc)
                {
                    if (vertex.getId() < min)
                    {
                        min = vertex.getId();
                        minVertex = vertex;
                        minScc = scc;
                    }
                }
            }

            if (minVertex == null)
            {
                return null;
            }
            Graph<int> graphScc = new Graph<int>(true);
            foreach (var edge in subGraph.getAllEdges())
            {
                if (minScc.Contains(edge.getVertex1()) && minScc.Contains(edge.getVertex2()))
                {
                    graphScc.addEdge(edge.getVertex1().getId(), edge.getVertex2().getId(), edge.getWeight());
                }
            }
            return graphScc.getVertex(minVertex.getId());
        }

        private bool findCyclesInSCG(Vertex<int> startVertex, Vertex<int> currentVertex)
        {
            bool foundCycle = false;
            stack.AddFirst(currentVertex);
            blockedSet.AddLast(currentVertex);

            foreach (Edge<int> e in currentVertex.getEdges())
            {
                Vertex<int> neighbor = e.getVertex2();
                //if neighbor is same as start vertex means cycle is found.
                //Store contents of stack in final result.
                if (neighbor == startVertex)
                {
                    List<Vertex<int>> cycle = new List<Vertex<int>>();
                    stack.AddFirst(startVertex);
                    cycle.AddRange(stack);
                    cycle.Reverse();
                    stack.RemoveFirst();
                    allCycles.Add(cycle);
                    foundCycle = true;
                } //explore this neighbor only if it is not in blockedSet.
                else if (!blockedSet.Contains(neighbor))
                {
                    bool gotCycle =
                            findCyclesInSCG(startVertex, neighbor);
                    foundCycle = foundCycle || gotCycle;
                }
            }
            //if cycle is found with current vertex then recursively unblock vertex and all vertices which are dependent on this vertex.
            if (foundCycle)
            {
                //remove from blockedSet  and then remove all the other vertices dependent on this vertex from blockedSet
                unblock(currentVertex);
            }
            else
            {
                //if no cycle is found with current vertex then don't unblock it. But find all its neighbors and add this
                //vertex to their blockedMap. If any of those neighbors ever get unblocked then unblock current vertex as well.
                foreach (var e in currentVertex.getEdges())
                {
                    Vertex<int> w = e.getVertex2();
                    LinkedList<Vertex<int>> bSet = getBSet(w);
                    bSet.AddLast(currentVertex);
                }
            }
            //remove vertex from the stack.
            stack.RemoveFirst();
            return foundCycle;
        }

        private void unblock(Vertex<int> u)
        {
            blockedSet.Remove(u);
            if (blockedMap.ContainsKey(u))
            {
                var blockeMapList = blockedMap[u];
                foreach (var item in blockeMapList)
                {
                    if (blockedSet.Contains(item))
                    {
                        unblock(item);
                    }
                }
                blockedMap.Remove(u);
            }
        }
        private LinkedList<Vertex<int>> getBSet(Vertex<int> v)
        {
            if (!blockedMap.ContainsKey(v))
                blockedMap.Add(v, new LinkedList<Vertex<int>>());
            return blockedMap[v];
        }
    }
}
