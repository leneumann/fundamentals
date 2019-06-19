using src.algorithms.search;
using src.dataStructures.graph;
using Xunit;

namespace test.search
{
    public class SearchTests
    {
        private readonly Graph<int> graph;
        public SearchTests()
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
        public void whenDoDepthFirstSearchInTheGraphShouldEqualToResult()
        {
            var dfs = new DepthFirst<int>();
            var dfsresult = dfs.search(graph);
            Assert.Equal("0 1 2 4 3 ", dfsresult);
        }


        [Fact]
        public void whenDoBreadthFirstSearchInTheGraphShouldEqualToResult()
        {
            var bfs = new BreadthFirst<int>();
            var bfsresult = bfs.search(graph);
            Assert.Equal("0 1 2 4 3 ", bfsresult);
        }
    }
}