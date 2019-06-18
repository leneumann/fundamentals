using src.algorithms.search;
using src.dataStructures.graph;
using Xunit;

namespace test.search
{
    public class CycleInDirectedGraphTest
    {
        private readonly Graph<int> graph;
        public CycleInDirectedGraphTest()
        {
            graph = new Graph<int>(true);
            graph.addEdge(0, 1, 3);
            graph.addEdge(1, 2, 4);
            graph.addEdge(2, 0, 12);
            graph.addEdge(3, 1, 3);
            graph.addEdge(4, 3, 8);
            graph.addEdge(2, 4, 40);

        }
        [Fact]
        public void IfTheGraphHasCyclesShouldReturnTrue()
        {
            var cycles = new CycleInDirectedGraph<int>();
            var hasCycles = cycles.hasCycle(graph);
            Assert.True(hasCycles);
        }
    }
}