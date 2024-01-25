function TrueorFalse() {
	
	var outputbox = document.getElementById("outputbox");
	
	var and = document.getElementById("And");
	var or = document.getElementById("Or");
	var xor = document.getElementById("Xor");
	var not = document.getElementById("Not");
	var andtwo = document.getElementById("Andtwo");
	var ortwo = document.getElementById("Ortwo");
	var xortwo = document.getElementById("Xortwo");
	
	var andValue = and.options[and.selectedIndex].value
	var orValue = or.options[or.selectedIndex].value
	var xorValue = xor.options[xor.selectedIndex].value
	var notValue = not.options[not.selectedIndex].value
	var andtwoValue = andtwo.options[andtwo.selectedIndex].value
	var ortwoValue = ortwo.options[ortwo.selectedIndex].value
	var xortwoValue = xortwo.options[xortwo.selectedIndex].value
	
	if (and.selectedIndex != andtwo.selectedIndex) {
		outputbox.innerHTML = "False";
	}
	else {
		outputbox.innerHTML = "True";
	}
	if (or.selectedIndex == 1 && ortwo.selectedIndex == 1) {
		outputboxtwo.innerHTML = " False";
	}
	else if (or.selectedIndex || ortwo.selectedIndex == 1) {
		outputboxtwo.innerHTML = "True";
	}
	else {
		outputboxtwo.innerHTML = "True";
	}
	if (xor.selectedIndex == 1 && xortwo.selectedIndex == 1) {
		outputboxthree.innerHTML = "False";
	}
	else if (xor.selectedIndex == 1 || xortwo.selectedIndex == 1) {
		outputboxthree.innerHTML = "True";
	}
	else {
		outputboxthree.innerHTML = "False";
	}
	if (not.selectedIndex == 0) {
		outputboxfour.innerHTML = "False";
	}
	else {
		outputboxfour.innerHTML = "True";
	}
}
function myFunction() {
	someLetters();
	someLetterstwo();
	someLettersthree();
	/*
	someLettersfour() ;
	*/
}
function someLetters() {
	var output = document.getElementById("LoopOutput");
    for (var i=65; i<=90; i++) {
		if (i != 65) {
			output.innerHTML +=  ", ";
        }
		else if (i == 90) {
			output.innerHTML += ", ";
		}
        output.innerHTML += String.fromCharCode(i);
	}
}
function someLetterstwo() {
	var output = document.getElementById("LoopOutput");
    for (var i=97; i<=122; i++) {
		if (i == 97) {
			output.innerHTML += ", ";
			output.innerHTML += " ";
		}
		else if (i != 97) {
			output.innerHTML +=  ", ";
        }
        output.innerHTML += String.fromCharCode(i);
	}
}
function someLettersthree() {
	var output = document.getElementById("LoopOutput");
	for (var i=0; i<=25; i++) {
		if (i == 0) {
			output.innerHTML += ", ";
			output.innerHTML += " ";
		}
		else if (i != 0) {
			output.innerHTML += ", ";
		}
		output.innerHTML += String.fromCharCode(i+65);
		output.innerHTML += String.fromCharCode(i+97);
	}
}
/*
function someLettersfour() {
	var output = document.getElementById("LoopOutput");
	for (var i=25; i>=0; i--) {
		if (i == 25) {
			output.innerHTML += ", ";
			output.innerHTML += " ";
		}
		else if (i != 25) {
			output.innerHTML += ", ";
		}
		output.innerHTML += String.fromCharCode(i+65);
		output.innerHTML += String.fromCharCode(i+97);
	}
}
*/