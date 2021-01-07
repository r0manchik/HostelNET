var canvas = document.getElementById("my-canvas");

if (canvas.getContext) {

	var ctx = canvas.getContext('2d');

	//прямоугольник
	ctx.fillStyle = '#cecece';
	ctx.fillRect(0, 0, 150, 75); //заливает прямоугольную область
	ctx.strokeStyle = '#000';
	ctx.strokeRect(0, 0, 150, 75); //обводит прямоугольную область
	ctx.clearRect(10, 10, 120, 45) //очищает прям.обл, делая ее прозрачной

	//прямая
	ctx.strokeStyle = 'blue';
	ctx.moveTo(130, 10);
	ctx.lineTo(10, 55);
	ctx.stroke();

	//окружность + кривая
	ctx.fillStyle = 'yellow';
	ctx.beginPath();
	ctx.moveTo(50, 150);
	//arc(x, y, radius, startAngle, endAngle, anticlockwise)
	ctx.arc(50, 150, 30, 0.25 * Math.PI, 1.75 * Math.PI);
	ctx.lineTo(50, 150);
	ctx.stroke();
	ctx.fill();
	ctx.closePath();

	//окружность + кривая
	ctx.fillStyle = 'yellow';
	ctx.beginPath();
	ctx.moveTo(250, 150);
	//arc(x, y, radius, startAngle, endAngle, anticlockwise)
	ctx.arc(250, 150, 30, 0.25 * Math.PI, 1.75 * Math.PI);
	ctx.lineTo(250, 150);
	ctx.stroke();
	ctx.fill();

	//кривая Безье
	ctx.fillStyle = "red";
	ctx.beginPath();
	ctx.moveTo(75, 40);
	//bezierCurveTo(cp1x, cp1y, cp2x, cp2y, x, y)
	ctx.bezierCurveTo(75, 37, 70, 25, 50, 25);
	ctx.bezierCurveTo(20, 25, 20, 62.5, 20, 62.5);
	ctx.bezierCurveTo(20, 80, 40, 102, 75, 120);
	ctx.bezierCurveTo(110, 102, 130, 80, 130, 62.5);
	ctx.bezierCurveTo(130, 62.5, 130, 25, 100, 25);
	ctx.bezierCurveTo(85, 25, 75, 37, 75, 40);
	ctx.fill();

	//квадратичная кривая
	ctx.beginPath();
	ctx.moveTo(75, 25);
	//quadraticCurveTo(cpx, cpy, x, y)
	ctx.quadraticCurveTo(25, 25, 25, 62.5);
	ctx.quadraticCurveTo(25, 100, 50, 100);
	ctx.quadraticCurveTo(50, 120, 30, 125);
	ctx.quadraticCurveTo(60, 120, 65, 100);
	ctx.quadraticCurveTo(125, 100, 125, 62.5);
	ctx.quadraticCurveTo(125, 25, 75, 25);
	ctx.stroke();

	//градиенты
	//createLinearGradient(x0, y0, x1, y1)
	var lingrad = ctx.createLinearGradient(0, 0, 0, 150);
	//addColorStop(offset, color)
	lingrad.addColorStop(0, '#00ABEB');
	lingrad.addColorStop(0.5, '#fff');
	lingrad.addColorStop(0.5, '#66CC00');
	lingrad.addColorStop(1, '#fff');
	ctx.fillStyle = lingrad; //подключение градиента
	ctx.fillRect(250, 0, 130, 110);

	//createRadialGradient(x0, y0, r0, x1, y1, r1)
	var radgrad = ctx.createRadialGradient(45, 45, 10, 52, 50, 30);
	radgrad.addColorStop(0, '#A7D30C');
	radgrad.addColorStop(0.9, '#019F62');
	radgrad.addColorStop(1, 'rgba(1,159,98,0)');
	ctx.fillStyle = radgrad;
	ctx.fillRect(0, 0, 150, 150);

} //end_if





