function VeTrucToaDo(context) {
    // Chọn đối tượng vẽ 2D
    // const context = canvas.getContext('2d');
    // Tiến hành vẽ
    context.beginPath();        // Khai báo vẽ đường thẳng mới
    context.moveTo(-250, 0);     // Điểm bắt đầu
    context.lineTo(250, 0);   // Điểm kết thúc
    context.stroke();
    context.beginPath();        // Khai báo vẽ đường thẳng mới
    context.moveTo(0, -250);     // Điểm bắt đầu
    context.lineTo(0, 250);   // Điểm kết thúc
    context.stroke();
}
//------------ Vẽ Đương Tròn
// Lấy đối tượng Canvas
const canvasCircle = document.getElementById('canvas-circle').getContext('2d');;
canvasCircle.translate(250, 250);
canvasCircle.scale(1, -1);
VeTrucToaDo(canvasCircle);
let circleShow = document.getElementById('circle-show');
function drawCircleMidpoint(R, data) {
    let d = 1 - R;
    let x = 0;
    let y = R;
    let i = 1;
    while (x < y) {
        let point = {
            index: i,
            "x": x,
            "y": y,
            "dOld": d
        }
        if (d < 0) {
            d = d + (2 * x + 3);
            x = x + 1;
        }
        else {
            d = d + 2 * x - 2 * y + 5;
            x = x + 1;
            y = y - 1;
        }
        point.xNew = x;
        point.yNew = y;
        point.dNew = d;
        data.push(point);
        i++;
    }
}
circleShow.addEventListener('click', function (e) {
    let X = document.getElementById("circleX").value;
    let Y = document.getElementById("circleY").value;
    let R = document.getElementById("circleR").value;
    let data = [];
    drawCircleMidpoint(R, data);
    if (data && data.length > 0) {
        // const context = canvasCircle.getContext('2d');
        canvasCircle.clearRect(-250, -250, 500, 500);
        VeTrucToaDo(canvasCircle);
        data.map((item) => {
            // context.fillStyle = "#FF0000";
            // console.log(Number(item.x), Number(item.y))
            // context.fillRect(Number(item.x) + Number(X), Number(item.y) + Number(Y), 5, 5);
            //8 điểm đối xứng
            //1
            canvasCircle.fillStyle = "#FF0000";
            canvasCircle.fillRect(Number(X) + (Number(item.x) + Number(X)), Number(Y) + (Number(item.y) + Number(Y)), 5, 5);
            //2
            canvasCircle.fillStyle = "#28de0e";
            canvasCircle.fillRect(Number(X) - (Number(item.x) + Number(X)), Number(Y) + (Number(item.y) + Number(Y)), 5, 5);
            //3
            canvasCircle.fillStyle = "#4319ce";
            canvasCircle.fillRect(Number(X) + (Number(item.x) + Number(X)), Number(Y) - (Number(item.y) + Number(Y)), 5, 5);
            //4
            canvasCircle.fillStyle = "#cec619";
            canvasCircle.fillRect(Number(X) - (Number(item.x) + Number(X)), Number(Y) - (Number(item.y) + Number(Y)), 5, 5);
            //5
            canvasCircle.fillStyle = "#19c0ce";
            canvasCircle.fillRect(Number(X) + (Number(item.y) + Number(Y)), Number(Y) + (Number(item.x) + Number(X)), 5, 5);
            //6
            canvasCircle.fillStyle = "#a8d4ee";
            canvasCircle.fillRect(Number(X) - (Number(item.y) + Number(Y)), Number(Y) + (Number(item.x) + Number(X)), 5, 5);
            //7
            canvasCircle.fillStyle = "#ce5119";
            canvasCircle.fillRect(Number(X) + (Number(item.y) + Number(Y)), Number(Y) - (Number(item.x) + Number(X)), 5, 5);

            canvasCircle.fillStyle = "#39554b";
            canvasCircle.fillRect(Number(X) - (Number(item.y) + Number(Y)), Number(Y) - (Number(item.x) + Number(X)), 5, 5);
        })
    }
})
