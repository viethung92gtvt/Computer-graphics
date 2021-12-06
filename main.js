// Lấy đối tượng Canvas
const canvasCircle = document.getElementById('canvas-circle');

VeTrucToaDo(canvasCircle);

function VeTrucToaDo(canvas) {
    // Chọn đối tượng vẽ 2D
    const context = canvas.getContext('2d');
    // Tiến hành vẽ
    context.beginPath();        // Khai báo vẽ đường thẳng mới
    context.moveTo(250, 0);     // Điểm bắt đầu
    context.lineTo(250, 500);   // Điểm kết thúc
    context.stroke();
    context.beginPath();        // Khai báo vẽ đường thẳng mới
    context.moveTo(0, 250);     // Điểm bắt đầu
    context.lineTo(500, 250);   // Điểm kết thúc
    context.stroke();
}