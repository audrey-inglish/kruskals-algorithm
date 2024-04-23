# Notes

## General Overview
Kruskal's Algorithm is a tool for constructing a minimal spanning tree from a weighted graph.
This allows us to analyze the most efficient path between vertices, based on the weights of the edges.

## Potential Applications
- network planning (infrastructure)
- social network analysis
- traveling salesman problem

Instead of picking a specific application for this implementation, I'm simply showing vertices
and edges. The user has the freedom to apply the tool however they choose.

## More About Kruskal's Algorithm
Kruskal's algorithm is a greedy algorithm. Greedy algorithms are an approach towards optimization, 
implemented by always taking the best possible option at a given moment. 
This type of algorithm finds solutions to problems in the smallest amount of time possible.

## Time Complexity Analysis


## UI
The user fills out an adjacency matrix, specifying the edge weights between given vertices.

Once the matrix is filled out, the user can press "Build Tree" to see a visual representation of the weighted adjacency matrix.
Vertices are represented by circles labeled with characters, and weighted edges connect the vertices.
The user can also press "Reset" to clear the matrix and start over.

When the user presses the "Run Kruskal's Algorithm" button, a sequence of vertices representing the most efficient path will appear.
The total cost of the most efficient path will also be calculated and displayed.

## Implementation Details
- Edges are named according to the two vertices they connect
- Implement a simple version of the Union-Find algorithm to check for cycles
- using a disjoint set data structure to determine connectivity between vertices and merge sets

Edge class will have properties:
- source : char
- destination
- weight
- name (auto-implemented based on source and destination)

### Testing
For testing the actual algorithm, input each edge and vertice individually, then run the FindMinimalSpanning function.
- Test whether starting with a minimal spanning tree returns the same minimal spanning tree
- Test examples where one edge makes a cycle

## Taking it a Step Further
- Currently, the user is limited to one size of matrix. To make this more functional
and tailor it to specific applications, I would like to implement the ability to 
choose the number of vertices and expand the matrix.
- It would be useful to assign coordinates to each vertice for a more accurate display.

# Main Takeaways