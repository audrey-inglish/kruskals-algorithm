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

## To-Do
- [ ] implement the actual algorithm
- [ ] add forms to UI
- [ ] display results of Kruskal's in UI
- [ ] basic tests
- [ ] 

## Implementation Details
- idea: name edges according to the two vertices they connect



edge class will have properties
- source
- destination
- weight
- name (auto-implemented based on source and destination)