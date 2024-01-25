function countIt(input) {
	input= input + 17;
	input = 5;
	return 20;
}

function loops() {
	output = document.getElementById("outputBoxfour");
	for(var i=10; i<countIt(i); i++) {
		if (i > 10) {
			output.innerHTML +=", "
		}
		output.innerHTML += i ;
	}
}
function loops1() {
	output = document.getElementById("outputBoxfour");
	for(var i=10; i>0; i--) {
		output.innerHTML += i;
	}
}
function loops2() {
	output = document.getElementById("outputBoxfour");
	if (i<0 && i > 10) {
			output.innerHTML +=", "
		}
	for(var i=0; i<10; i++) {
		output.innerHTML += i;
	}
	if (i == 10) {
		output.innerHTML += "<br>"
	}
	for(var i=10; i>0; i--) {
		output.innerHTML += i;
	}
}
function loops3() {
	output = document.getElementById("outputBoxfour");
	for(var i=0; i<100; i++) {
		if (i % 2 == 0) {
			output.innerHTML += i + "-" + "Even";
		}
		if (i % 2 == 1) {
			output.innerHTML += i + "-" + "Odd";
		}
		if (i % 5 == 0) {
			output.innerHTML += "<hr>";
		}
		else {
			output.innerHTML += ", "
	}
}
}
function loops4() {
	output = document.getElementById("outputBoxfour");
	for(var i=1; i<101; i++) {
		if (i % 1 == 0) {
			output.innerHTML += "<br>";
		}
		if (i % 15 ==0) {
			output.innerHTML +="The Mighty Thor";
		}
		else if (i % 3 ==  0) {
			output.innerHTML +="The Mighty";
		}
		else if (i % 5 == 0) {
			output.innerHTML +="Thor";
		}
		else {
		output.innerHTML += i ;
		}
	}
}