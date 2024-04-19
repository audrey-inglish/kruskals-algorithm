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

## To-Do
- [ ] implement the Kruskal's algorithm
- [ ] implement the Union-Find algorithm
- [ ] add forms to UI
- [ ] display results of Kruskal's in UI
- [ ] display static tree based on input vertices and edges
- [ ] basic tests
- [ ] 

## Implementation Details
- idea: name edges according to the two vertices they connect
- will likely need to implement the Union-Find algorithm for checking cycles
- using a disjoing set data structure to determine connectivity between vertices and merge sets


- for every edge that we check, we have to make sure that its two vertices belong to different trees
Edge class will have properties
- source : char
- destination
- weight
- name (auto-implemented based on source and destination)


## Taking it a Step Further
- Currently, the user is limited to one size of matrix. To make this more functional
and tailor it to specific applications, I would like to implement the ability to 
choose the number of vertices and expand the matrix.
- It would be useful to assign coordinates to each vertice for a more accurate display.