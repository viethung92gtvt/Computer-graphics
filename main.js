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
function circleMidpoint(R, data) {
    let d = 1 - R;
    let x = 0;
    let y = Number(R);
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
    circleMidpoint(R, data);
    if (data && data.length > 0) {
        // const context = canvasCircle.getContext('2d');
        canvasCircle.clearRect(-250, -250, 500, 500);
        VeTrucToaDo(canvasCircle);
        data.map((item) => {
            console.log(item);
            // context.fillStyle = "#FF0000";
            // console.log(Number(item.x), Number(item.y))
            // context.fillRect(Number(item.x) + Number(X), Number(item.y) + Number(Y), 4,4);
            //8 điểm đối xứng
            //1
            canvasCircle.fillStyle = "#FF0000";
            canvasCircle.fillRect((Number(X) + Number(item.x)), (Number(Y) + Number(item.y)), 4, 4);
            //2
            canvasCircle.fillStyle = "#28de0e";
            canvasCircle.fillRect((Number(X) - Number(item.x)), (Number(Y) + Number(item.y)), 4, 4);
            //3
            canvasCircle.fillStyle = "#4319ce";
            canvasCircle.fillRect((Number(X) + Number(item.x)), (Number(Y) - Number(item.y)), 4, 4);
            // //4
            canvasCircle.fillStyle = "#cec619";
            canvasCircle.fillRect((Number(X) - Number(item.x)), (Number(Y) - Number(item.y)), 4, 4);
            // //5
            canvasCircle.fillStyle = "#19c0ce";
            canvasCircle.fillRect((Number(X) + Number(item.y)), (Number(Y) + Number(item.x)), 4, 4);
            // //6
            canvasCircle.fillStyle = "#a8d4ee";
            canvasCircle.fillRect((Number(X) - Number(item.y)), (Number(Y) + Number(item.x)), 4, 4);
            //7
            canvasCircle.fillStyle = "#ce5119";
            canvasCircle.fillRect((Number(X) + Number(item.y)), (Number(Y) - Number(item.x)), 4, 4);

            canvasCircle.fillStyle = "#39554b";
            canvasCircle.fillRect((Number(X) - Number(item.y)), (Number(Y) - Number(item.x)), 4, 4);
        })
    }
})
//------------ Vẽ Đương Thẳng

const canvasLine = document.getElementById('canvas-line').getContext('2d');;
canvasLine.translate(250, 250);
canvasLine.scale(1, -1);
VeTrucToaDo(canvasLine);
let lineShow = document.getElementById('line-show');
function Bres(xa, ya, xb, yb, k, data) {
    let Dx = xb - xa;
    let Dy = yb - ya;
    let d = 2 * Dy - Dx;
    let x = xa;
    let y = ya;
    let i = 0;
    while (x <= xb && y <= yb) {
        let point = {
            index: i,
            "x": x,
            "y": y,
            "dOld": d
        }
        switch (k) {
            case 0:
                canvasLine.fillStyle = "#FF0000";
                canvasLine.fillRect(Number(x), Number(y), 4, 4);
                break;
            case 1:
                canvasLine.fillStyle = "#28de0e";
                canvasLine.fillRect(Number(y), Number(x), 4, 4);
                break;
            case 2:
                canvasLine.fillStyle = "#cec619";
                canvasLine.fillRect(Number(x), -Number(y), 4, 4);
                break;
            case 3:
                canvasLine.fillStyle = "#cec619";
                canvasLine.fillRect(Number(y), -Number(x), 4, 4);
                break;
            default:
                break;
        }
        if (d < 0) { d += 2 * Dy; x++; }
        else { d += 2 * (Dy - Dx); y++; x++; }
        point.xNew = x;
        point.yNew = y;
        point.dNew = d;
        data.push(point);
        console.log(point);
        i++;

    }
}
lineShow.addEventListener('click', function (e) {
    let xa = Number(document.getElementById("LineXa").value);
    let ya = Number(document.getElementById("LineYa").value);
    let xb = Number(document.getElementById("LineXb").value);
    let yb = Number(document.getElementById("LineYb").value);
    let data = [];
    canvasLine.clearRect(-250, -250, 500, 500);
    VeTrucToaDo(canvasLine);
    if (xa > xb)//luon co xa < xb
    {
        let t = xa; xa = xb; xb = t;
        t = ya; ya = yb; yb = t;
    }
    let Dx = xb - xa;
    let Dy = yb - ya;
    /* 0 < m < 1*/
    if (0 < Dy && Dy < Dx)
        Bres(xa, ya, xb, yb, 0, data);
    /* m > 1*/
    if (Dy > Dx) {
        let xa_new = ya, ya_new = xa;
        let xb_new = yb, yb_new = xb;
        Bres(xa_new, ya_new, xb_new, yb_new, 1, data);
    }
    /* -1 < m < 0*/
    if (-Dx < Dy && Dy < 0) {
        let xa_new = xa, ya_new = -ya;
        let xb_new = xb, yb_new = -yb;
        Bres(xa_new, ya_new, xb_new, yb_new, 2, data);
    }
    /* m < -1*/
    if (Dy < -Dx) {
        let xa_new = -ya, ya_new = xa;
        let xb_new = -yb, yb_new = xb;
        Bres(xa_new, ya_new, xb_new, yb_new, 3, data);
    }
    //song song Ox
    if (Dy == 0) {
        for (let x = xa; x <= xb; x++) {
            canvasLine.fillStyle = "#39554b";
            canvasLine.fillRect(Number(x), Number(ya), 4, 4);
        }
    }
    //song song Oy
    if (Dx == 0) {
        let min = ya < yb ? ya : yb;
        let max = ya > yb ? ya : yb;
        for (let y = min; y <= max; y++) {
            canvasLine.fillStyle = "#e7a955";
            canvasLine.fillRect(Number(xa), Number(y), 4, 4);
        }
    }
    //song song y = x (m=1)
    if (Dy == Dx) {
        let x, y;
        for (x = xa, y = ya; x <= xb; x++, y++) {
            canvasLine.fillStyle = "#9ee755";
            canvasLine.fillRect(Number(x), Number(y), 4, 4);
        }
    }
    //song song y = -x (m=-1)
    if (Dy == -Dx) {
        let x, y;
        for (x = xa, y = ya; x <= xb; x++, y--) {
            canvasLine.fillStyle = "#6aebb2";
            canvasLine.fillRect(Number(x), Number(y), 4, 4);
        }
    }
})

//Vẽ elip
// Lấy đối tượng Canvas
const canvasElip = document.getElementById('canvas-elip').getContext('2d');;
canvasElip.translate(250, 250);
canvasElip.scale(1, -1);
VeTrucToaDo(canvasElip);
let elipShow = document.getElementById('elip-show');
function elipMidpoint(a, b, data) {
    let x = 0, y = b;
    let a2 = a * a;
    let b2 = b * b;
    let d = b2 + a2 * (1 / 4 - b);
    console.log(d)
    let i = 0;
    while (b2 * (x + 1) < a2 * (y - 0.5))//trong mien 1
    {
        let point = {
            index: i,
            "x": x,
            "y": y,
            "mien": "Mien 1",
            "dOld": d
        }
        if (d < 0) {
            d += b2 * (2 * x + 3);
        }
        else {
            d += (b2 * (2 * x + 3) - a2 * (2 * y - 2));
            y--;
        }
        x++;
        point.xNew = x;
        point.yNew = y;
        point.dNew = d;
        data.push(point);
        i++;
    }
    //    d = F(x+0.5, y -1)
    d = b2 * (x + 0.5) * (x + 0.5) + a2 * (y - 1) * (y - 1) - a2 * b2;
    //Bat dau mien 2
    while (y >= 0) {
        let point = {
            index: i,
            "x": x,
            "y": y,
            "mien": "Mien 2",
            "dOld": d
        }
        if (d > 0) {
            d -= a2 * (2 * y - 3);
        }
        else {
            d += b2 * (2 * x + 2) - a2 * (2 * y - 3);
            x++;
        }
        y--;
        point.xNew = x;
        point.yNew = y;
        point.dNew = d;
        data.push(point);
        i++;
    }
}

elipShow.addEventListener('click', function (e) {
    let X = Number(document.getElementById("elipX").value);
    let Y = Number(document.getElementById("elipY").value);
    let Rx = Number(document.getElementById("elipR1").value);
    let Ry = Number(document.getElementById("elipR2").value);
    let data = [];
    elipMidpoint(Rx, Ry, data);
    if (data && data.length > 0) {
        // const context = canvasCircle.getContext('2d');
        canvasElip.clearRect(-250, -250, 500, 500);
        VeTrucToaDo(canvasElip);
        data.map((item) => {
            console.log(item);
            //1
            canvasElip.fillStyle = "#FF0000";
            canvasElip.fillRect((Number(X) + Number(item.x)), (Number(Y) + Number(item.y)), 4, 4);
            //2
            canvasElip.fillStyle = "#28de0e";
            canvasElip.fillRect((Number(X) - Number(item.x)), (Number(Y) + Number(item.y)), 4, 4);
            //3
            canvasElip.fillStyle = "#4319ce";
            canvasElip.fillRect((Number(X) + Number(item.x)), (Number(Y) - Number(item.y)), 4, 4);
            // //4
            canvasElip.fillStyle = "#cec619";
            canvasElip.fillRect((Number(X) - Number(item.x)), (Number(Y) - Number(item.y)), 4, 4);
        })
    }
})
