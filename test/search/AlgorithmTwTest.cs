using src.algorithms.search;
using src.dataStructures.graph;
using Xunit;

namespace test.search
{
    public class AlgorithmTwTest
    {
        private readonly Graph<int> graph;

        public AlgorithmTwTest()
        {
            graph = new Graph<int>(true);
            graph.addEdge(0, 1, 5);
            graph.addEdge(0, 3, 5);
            graph.addEdge(0, 4, 7);
            graph.addEdge(1, 2, 4);
            graph.addEdge(2, 3, 8);
            graph.addEdge(2, 4, 2);
            graph.addEdge(3, 2, 8);
            graph.addEdge(3, 4, 6);
            graph.addEdge(4, 1, 3);
        }

        [Fact]
        public void test()
        {
            var tw = new AlgorithmTw<int>();
            Vertex<int> start = graph.getVertex(0);
            Vertex<int> dest = graph.getVertex(2);
            tw.search(graph,start,dest,5);
        }
    }
}