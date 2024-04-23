# Write-Up: Kruskal's Algorithm

## General Overview
Kruskal's Algorithm is a tool for constructing a minimal spanning tree from a weighted graph.
This allows us to analyze the most efficient path between vertices, based on the weights of the edges.

## Potential Applications
Kruskal's Algorithm can be applied to a variety of problems, including:

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
### Breakdown by Algorithm Components
- initializing data members, like the edge list, takes constant time: O(1)
- sorting the edge list:
    - I implemented a QuickSort algorithm, which has an average time complexity of O(n log n) and a worst-case time complexity of O(n^2)
        this worst-case complexity occurs when the selected pivot is the smallest or largest in the list
- iterating through the sorted edge list and checking for cycles:
    - the Union-Find algorithm has a time complexity of O(log n)
        - in the best case, this algorithm may also be constant time, O(1)
    - the algorithm iterates through the edge list, leading to a time complexity of O(E), where E is the number of edges

### Overall Time Complexity
Considering the above components, the overall average time complexity of Kruskal's algorithm is O(E log E), where E is the number of edges.
However, given the worst-case complexity of QuickSort, the overall worst-case time complexity is O(E^2).

## UI
The user fills out an adjacency matrix, specifying the edge weights between given vertices.

Once the matrix is filled out, the user can press "Build Tree" to see a visual representation of the weighted adjacency matrix.
Vertices are represented by circles labeled with characters, and weighted edges connect the vertices.
The user can also press "Reset" to clear the matrix and start over.

When the user presses the "Run Kruskal's Algorithm" button, a sequence of vertices representing the most efficient path will appear.
The total cost of the most efficient path will also be calculated and displayed.

## Implementation Details
A few notes on my chosen implementation of the algorithm:

- Edges are named according to the two vertices they connect
- Implementing a simple version of the Union-Find algorithm to check for cycles
- Using a disjoint set data structure to determine connectivity between vertices and merge sets

### Testing
For testing the actual algorithm, input each edge and vertice individually, then run the FindMinimalSpanning function.
- Test whether starting with a minimal spanning tree returns the same minimal spanning tree
- Test examples where one edge makes a cycle

## Taking it a Step Further
A few ideas I have for expanding this project:

- Implement a more efficient sorting algorithm, like MergeSort or HeapSort
- Currently, the user is limited to one size of matrix. To make this more functional
and tailor it to specific applications, I would like to implement the ability to 
choose the number of vertices and expand the matrix.
- It would be useful to assign coordinates to each vertice for a more accurate display.

# Main Takeaways
This project was a great way for me to better understand Kruskal's algorithm, as well as practice
incorporating mathematical concepts into software development. Overall, I'm happy with the
implementation and the user interface. I thoroughly enjoyed working on this project, and I'm
glad to have had the opportunity and resources to do so.
