using System.Collections.Generic;
using src.algorithms.search;
using src.dataStructures.graph;
using Xunit;

namespace test.search
{
    public class TarjanStronglyConnectedComponentTest
    {
        private readonly Graph<int> graph;
        public TarjanStronglyConnectedComponentTest()
        {
            graph = new Graph<int>(true);
            graph.addEdge(0,1,5);
            graph.addEdge(0,3,5);
            graph.addEdge(0,4,7);
            graph.addEdge(1,2,4);
            graph.addEdge(2,3,8);
            graph.addEdge(2,4,2);
            graph.addEdge(3,2,8);
            graph.addEdge(3,4,6);
            graph.addEdge(4,1,3);
        }

        [Fact]
        public void test()
        {
            TarjanStronglyConnectedComponent tarjanStronglyConnectedComponent = new TarjanStronglyConnectedComponent();
            List<LinkedList<Vertex<int>>> result = tarjanStronglyConnectedComponent.scc(graph);
            result = result;
        }
    }
}