var op = "";
var holdA = 0;
var clear = false;
var point = true;

function setTheNumbers(obj) {
	var output = document.getElementById("result");
	if (output.value == "" || clear)
	{
		output.value = obj.value;
	}
	else
	{
		output.value += obj.value
	}
	clear = false;
}

function clearInput() {
	var output = document.getElementById("result");
	output.value = "";
	op = "";
	holdA = 0;
	point = true;
}
function doTheZero() {
	var  output = document.getElementById("result");
	if (output.value != "") {
		output.value += "0";
	}
	else
	{
	output.value = "";
	}
}
function setTheOperator(OP) {
	output = document.getElementById("result");
	op = OP.value;
	holdA = parseFloat(output.value);
	clear = true;
	point = true;
	
}
function solveThePromblem() {
	output = document.getElementById("result");
	if (op == "+")
	{
		output.value = parseFloat(output.value) + holdA;
	}
	else if (op == "-")
	{
		output.value = holdA - parseFloat(output.value);
	}
	else if (op == "*")
	{
		output.value = parseFloat(output.value) * holdA;
	}
	else
	{
		output.value = holdA / parseFloat(output.value);
	}
}