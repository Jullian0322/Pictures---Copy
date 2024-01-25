function TrueorFalse () {
	var outputBoxtwo = document.getElementById("outputBoxtwo");
	var Inputbox = document.getElementById("Inputbox").value;
	var Inputboxtwo = document.getElementById("Inputboxtwo").value;
	
	if (Inputbox == Inputboxtwo) {
		outputBoxtwo.innerHTML = "True";
		if (Inputbox == 7) {
		outputBoxtwo.innerHTML = "False";
	}
	if (Inputbox == "6" || Inputboxtwo == "6") {
        output.innerHTML = "True";
	}
	else {
		outputBoxtwo.innerHTML = "False";
	}
	}
}
/*
	var a=7
	var b=6
	if (a==b) {
	}
	if (a*b)<c {
	}
	*/
function TrueorFalsetwo () {
	var outputBoxtwo = document.getElementById("outputBoxtwo");
	var Inputbox = document.getElementById("Inputbox").value;
	var Inputboxtwo = document.getElementById("Inputboxtwo").value;
	
	if (Inputbox == "A" || Inputboxtwo == "A") {
		outputBoxtwo.innerHTML = "Compound Second <br> True";
	}
	if (Inputbox == "a" || Inputboxtwo == "a") {
		outputBoxtwo.innerHTML = "Compound Second <br> True";
	}
	else if (Inputbox >= "B" && Inputbox <= "Z") {
		outputBoxtwo.innerHTML = "Compound Second <br> True Any Letter";
	}
	else if (Inputbox >= "b" && Inputbox <= "z") {
		outputBoxtwo.innerHTML = "Compound Second <br> True Any Letter";
	}
	else if (Inputboxtwo >= "B" && Inputboxtwo <= "Z") {
		outputBoxtwo.innerHTML = "Compound Second <br> True Any Letter";
	}
	else if (Inputboxtwo >= "b" && Inputbox <= "z") {
		outputBoxtwo.innerHTML = "Compound Second <br> True Any Letter";
	}
	else if (Inputbox - Inputboxtwo <50) {
		outputBoxtwo.innerHTML = "Compound Second <br> True";
	}
	else if (Inputbox * Inputboxtwo == 100) {
		outputBoxtwo.innerHTML = "Compound Second <br> True";
	}
}