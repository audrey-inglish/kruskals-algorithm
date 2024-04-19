using FluentAssertions;
using Logic;

namespace Tests;

public class FindMinimalTreeTests
{
    [Fact]
    public void SimpleGraphWithSingleCycle()
    {
        List<Vertex> vertices = new()
        {
            new Vertex('a'),
            new Vertex('b'),
            new Vertex('c'),
            new Vertex('d')
        };

        List<Edge> edges = new()
        {
            new Edge( 2, vertices[0], vertices[1]),
            new Edge(3, vertices[1], vertices[2]),
            new Edge(5, vertices[2], vertices[3]),
            new Edge(12, vertices[3], vertices[0])
        };

        var kruskal = new Kruskal();
        var minSpanning = kruskal.FindMinimumSpanningTree(edges, out int totalCost);

        totalCost.Should().Be(10);
        minSpanning.Should().HaveCount(vertices.Count - 1); // The MST should have V - 1 edges

        //checking that expected edges are present
        minSpanning.Should().ContainEquivalentOf(new Edge(2, vertices[0], vertices[1]));
        minSpanning.Should().ContainEquivalentOf(new Edge(3, vertices[1], vertices[2]));
        minSpanning.Should().ContainEquivalentOf(new Edge(5, vertices[2], vertices[3]));
        minSpanning.Should().NotContainEquivalentOf(new Edge(10, vertices[3], vertices[0]));

        //can check whether the names of each edge are present

    }

    [Fact]
    public void StartingWithASpanningTreeMeansNoChanges()
    {
        List<Vertex> vertices = new()
        {
            new Vertex('a'),
            new Vertex('b'),
            new Vertex('c'),
            new Vertex('d')
        };

        List<Edge> edges = new()
        {
            new Edge( 2, vertices[0], vertices[1]),
            new Edge(3, vertices[1], vertices[2]),
            new Edge(8, vertices[2], vertices[3]),
        };

        var kruskal = new Kruskal();
        var minSpanning = kruskal.FindMinimumSpanningTree(edges, out int totalCost);


        totalCost.Should().Be(13);
        minSpanning.Should().HaveCount(vertices.Count - 1);

        //checking that expected edges are present
        minSpanning.Should().ContainEquivalentOf(new Edge(2, vertices[0], vertices[1]));
        minSpanning.Should().ContainEquivalentOf(new Edge(3, vertices[1], vertices[2]));
        minSpanning.Should().ContainEquivalentOf(new Edge(8, vertices[2], vertices[3]));
    }

    [Fact]
    public void MoreComplexGraph()
    {
        List<Vertex> vertices = new()
        {
            new Vertex('a'),
            new Vertex('b'),
            new Vertex('c'),
            new Vertex('d')
        };

        List<Edge> edges = new()
        {
            new Edge(7, vertices[0], vertices[1]),
            new Edge(4, vertices[1], vertices[2]),
            new Edge(3, vertices[2], vertices[3]),
            new Edge(2, vertices[3], vertices[0]),
            new Edge(1, vertices[0], vertices[2]),
        };

        var kruskal = new Kruskal();
        var minSpanning = kruskal.FindMinimumSpanningTree(edges, out int totalCost);


        totalCost.Should().Be(7);
        minSpanning.Should().HaveCount(vertices.Count - 1);

        //checking that expected edges are present
        minSpanning.Should().ContainEquivalentOf(new Edge(1, vertices[0], vertices[2]));
        minSpanning.Should().ContainEquivalentOf(new Edge(4, vertices[1], vertices[2]));
        minSpanning.Should().ContainEquivalentOf(new Edge(2, vertices[0], vertices[3]));

    }
}