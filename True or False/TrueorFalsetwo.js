function myFunctionstwo() {
	backwardsNumbers();
	noVowels();
	upVowels();
}
function backwardsNumbers() {
	var output = document.getElementById("LoopOutputbox");
	var add = 0;
	var multiply = 1;
    for (var i=20; i>=-20; i--) {
		if (i != 20) {
			output.innerHTML +=  ", ";
        }
		else if (i == -20) {
			output.innerHTML +=  ",";
		}
		if (i % 3 ==  0) {
			add += i;
		}
		if (i % 5 ==  0) {
			multiply += i;
		}
        output.innerHTML += i;
	}
}
function noVowels() {
	var output = document.getElementById("LoopOutputbox");
    for (var i=66; i<=90; i++) {
		if (i == 66) {
			output.innerHTML += " ";
		}
		else if (i != 66) {
			output.innerHTML += ", ";
		}
		else if (i != 66 && i != 73 && i != 79 && i != 85) {
			output.innerHTML += String.fromCharCode(i) + " ";
        }
        output.innerHTML += String.fromCharCode(i);
	}
}
function upVowels() {
	var output = document.getElementById("LoopOutputbox");
    for (var i=98; i<=120; i++) {
		if (i == 98) {
			output.innerHTML += " ";
		}
		else if (i != 98) {
			output.innerHTML +=  ", ";
        }
		else if (i == 101) {
			output.innerHTML +=  "E";
		}
		else if (i == 105) {
			output.innerHTML +=  "I";
		}
		else if (i == 111) {
			output.innerHTML +=  "O";
		}
		else if (i == 117) {
			output.innerHTML +=  "U";
		}
        output.innerHTML += String.fromCharCode(i)
	}
}
function theForty() {
	var output = document.getElementById("Loops");
	for (var i=40; i<=60; i++) {
		if (i != 40) {
			output.innerHTML += ", ";
		}
		output.innerHTML += i;
	}
	mutipleoftwo ()
}
/* teacher helped */
function mutipleoftwo () {
	var output = document.getElementById("Loops");
	var mult = 1;
	for (var i=0; i<=15; i++) {
		mult *=2;
		output.innerHTML += i;
		if (i != 0) {
			output.innerHTML += ", ";
		}
		else if (i  == 0){
			output.innerHTML += ", "
		}
	}
}
function totalTwo() {
	var total2;
	var mult = i;
	var output = document.getElementById("twelve");
	for (var i=0; i<=15; i++) {
		mult *= 3*4;
		if (i != 0) {
			output.innerHTML += ", ";
		}
		output.innerHTML += i;
	}
}