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

## UI
The user will be able to fill out an adjacency matrix, outlining the edge weights between given vertices.

When the user presses the "Find Best Path" button, a sequence of vertices representing the most efficient path will appear.
The total cost of the most efficient path will also be calculated and displayed.

Bonus points: A tree with labeled vertices and edges that aligns with the user's input will be rendered.

## To-Do
- [x] implement the Kruskal's algorithm
- [x] implement the Union-Find algorithm
- [x] add forms to UI
- [x] display results of Kruskal's in UI
- [x] button to call kruskal
- [x] reset button
- [x] display static tree based on input vertices and edges
- [x] basic tests
- [ ] change fonts and overall styling
- [ ] add self-cycles to UI
- [ ] implement logic to spread out vertices

## Implementation Details
- idea: name edges according to the two vertices they connect
- will likely need to implement the Union-Find algorithm for checking cycles
- using a disjoing set data structure to determine connectivity between vertices and merge sets
- no cycles will be allowed -- every edge must touch two vertices

- for every edge that we check, we have to make sure that its two vertices belong to different trees
Edge class will have properties
- source : char
- destination
- weight
- name (auto-implemented based on source and destination)

### Testing
For testing the actual algorithm, input each edge and vertice individually, then run the FindMinimalSpanning function.


- Test whether starting with a minimal spanning tree returns the same minimal spanning tree
- Test an example where one edge makes a cycle
## Time Complexity Analysis

## More About Kruskal's Algorithm
Kruskal's algorithm is a greedy algorithm. Greedy algorithms are an approach towards optimization, 
implemented by always taking the best possible option at a given moment.
This type of algorithm finds solutions to problems in the smallest amount of time possible.

## Taking it a Step Further
- Currently, the user is limited to one size of matrix. To make this more functional
and tailor it to specific applications, I would like to implement the ability to 
choose the number of vertices and expand the matrix.
- It would be useful to assign coordinates to each vertice for a more accurate display.


# Lessons Learned
