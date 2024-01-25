let outputObj;
window.onload = loadTheObj;
function loadTheObj() {
	outputObj = document.getElementById("output");
	
	outputObj.innerHTML += sum1(4,5,6) + "<br>";
	outputObj.innerHTML += sum2(6,7,8) + "<br>";
	outputObj.innerHTML += sum3(9,10,11) + "<br>";
	
	let sum4 = function(a,b,c) { return a+b+c; }
	outputObj.innerHTML += sum4(12,13,14) + "<br>";
	
	outputObj.innerHTML += myCar1.toString() + "<br>" + myCar2.toString() + "<br>" + myCar3.toString() + "<br>";
	
	outputObj.innerHTML += mycarArray[0].toString() + "<br>" + mycarArray[1].toString() + "<br>" + mycarArray[2].toString() + "<br>";
	
	for (let i=0; i<mycarArray.length; i++) {
		outputObj.inner += mycarArray[i].toString() + "<br>";
	}
}
function sum1(a, b, c) {
	return (a+b+c);
}

let sum2 = (a, b, c) => a + b + c;

let sum3 = (a, b, c,) => {
	let d = a + b;
	d += c;
	return d;
}

/* This is dealing with class */

class Car {
	constructor(n, m, year, color) {
		this.name = n;
		this.model = m;
		this.year = year;
		this.color= color;
	}
	getAge() {
		const date = new Date();
		return date.getFullYear() - this.year;
	}
	toString() {
		const date = new Date();
		return this.name + " " + this.model + " (" + this.color + ") is " + this.getAge() + " years old";
	}
}

const myCar1 = new Car("Ford", "Tempo", 1990, "Green");
const myCar2 = new Car("Plymouth", "Scamp", 1988, "Green");
const myCar3 = new Car("Toyota", "Tundra", 2007, "silver");

let mycarArray = new Array(3);
mycarArray[0] = myCar1;
mycarArray[1] = myCar2;
mycarArray[2] = myCar3;

/*
var, let, const
*/

console.log(l(5));
console.log(l(9));
function l(a) {
	let retVal = (a>7) ? "hi" : "bye";
	return retVal;
}

doDASwitch("peanuts");
doDASwitch("a");
doDASwitch("");
doDASwitch("Elaphant");
doDASwitch("blue");

function doDASwitch(x) {
	switch (x.length) {
		case 0:
		case 1:
			console.log("ain;t much there");
			break;
		case 7:
			console.log("We found peanuts");
			break;
		case 8:
			console.log("there's to much here");
			break;
		default: 
			console.log("yippe");
			break;
	}
}

function goWhile(loop) {
	output = document.getElementById("output2");
	if ( loops = "for") {
		for (let i=1; i<11; i++) {
			if (i > 1) {
				output.innerHTML += ", "
			}
			else {
				output.innerHTML += i;
			}
		}
	}
	else if ( loops = "while") {
		let i = 1;
		while (i < 11) {
			output.innerHTML += i + ", ";
			if (i == 10) {
				output.innerHTML += i + ""
			}
		}
	}
	else if ( loops = "Do") {
		let i = 1;
		do {
			output.innerHTML += i + ", ";
			i++;
			if (i == 10) {
				output.innerHTML += i + "";
			}
		}
		while (i < 11);
	}
	else {
		output = "There's nothing there try for, while, Do"
	}
}

function changeColor() {
	Div = documents.getElementById("color");
	Elements = Div.getElementsByTagName("p");
	for (i=0; i=Elements.getLength; i++)
		Elements[i]
}

function texts(scripts) {
	input = document.getElementById("texts");
	output = document.getElementById("box");
	let scripts = 0;
	let input = [input];
	if (script = 0) {
		output.innerHTML = input + input.push("Hello");
	}
	else if (script = 1) {
		output = input + input.unshift("Hello");
	}
	else if (script = 2) {
		output.innerHTML = input + input.pop();
	}
	else {
	output = input + input.shift();
	}
}
// To add a item to the shopping list
function addG() {
	input = document.getElementsByName("shoppingl");
	output = document.getElementById("list");
	let number = 4
	if (input==4) {
		output = document.write(<li class="item">input</li> <input type="checkbox" name=`Grocery${number}` value="Have" class="move" onclick=`haveIt$(item)`> <input type="checkbox" name=/*Tried to add a varible to a string*/`delete${firstName}` value="Delete" class="move" onclick= $`delete(Grocery${number})`>);
	}
	else if (input==5) {
		output = document.write(<li class="item">input</li> <input type="checkbox" name= `Grocery${number}` value="Have" class="move2" onclick=`haveIt$(item)`> <input type="checkbox" name=`delete${number}` value="Delete" class="move2" onclick=`delete(Grocery${number})`>);
	}
	else if (input==0) {
		input.innerHTML = "There's nothing to add";
	}
}
// To say I have the item
function haveIt(item) {
  let have = false;
  if (have == flase) {
    document.getElementsByClassName('item').style.green;
    have = true;
  } else if (have == true) {
    document.getElementsByClassName('item').style.blue;
    have = flase;
  }
}
// To delete the item when a mistake is made
function Delete(item) {
  const list = doctype.getElementById("list");
  list.delete(0);
}
