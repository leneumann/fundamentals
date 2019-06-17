using src.algorithms.search;
using src.dataStructures.graph;
using Xunit;

namespace test.search
{
    public class SearchTests
    {
        private readonly Graph<int> Graph;
        public SearchTests()
        {
            Graph<int> Graph = new Graph<int>(true);
            Graph.addEdge(0, 1, 3);
            Graph.addEdge(1, 2, 4);
            Graph.addEdge(2, 0, 12);
            Graph.addEdge(3, 1, 3);
            Graph.addEdge(4, 3, 8);
            Graph.addEdge(2, 4, 40);
        }
        [Fact]
        public void createGraph()
        {
            var dfs = new DepthFirst<int>();
            var dfsresult = dfs.search(Graph);

            var bfs = new BreadthFirst<int>();
           var bfsresult = bfs.search(Graph);

        }
    }
}