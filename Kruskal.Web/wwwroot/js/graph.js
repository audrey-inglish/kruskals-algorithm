
function drawGraph(edges) {
    var canvas = document.getElementById('graphCanvas');
    if (!canvas) return;

    var ctx = canvas.getContext('2d');
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    // Draw vertices
    edges.forEach(function (edge) {
        ctx.beginPath();
        ctx.arc(edge.x, edge.y, 10, 0, Math.PI * 2);
        ctx.fillStyle = 'red';
        ctx.fill();
        ctx.closePath();
    });

    // Draw edges
    edges.forEach(function (edge) {
        ctx.beginPath();
        ctx.moveTo(edge.source.x, edge.source.y);
        ctx.lineTo(edge.destination.x, edge.destination.y);
        ctx.strokeStyle = 'black';
        ctx.lineWidth = 2;
        ctx.stroke();
        ctx.closePath();
    });
}
