function startQuiz() {
	output = document.getElementById("leftCol");
	output2 = document.getElementById("middleCol");
	output3 = document.getElementById("rightCol");
	/* use only if I want a serten amount of square roots*/
	let a = Math.sqrt(1);
	let b = Math.sqrt(4);
	let c = Math.sqrt(9);
	let d = Math.sqrt(16);
	let e = Math.sqrt(25);
	let f = Math.sqrt(36);
	let g = Math.sqrt(49);
	let h = Math.sqrt(64);
	let j = Math.sqrt(81);
	let k = Math.sqrt(100);
	
	for (var i=1; i<=100; i++) {
		if (i % 2 == 0) {
			output.innerHTML += i;
		}
		else if (i != 1) {
			output.innerHTML += ", ";
			output2.innerHTML += ", ";

		}
		if (i % 2 != 0) {
			output2.innerHTML += i;
		}
		/*
		if (i == a && b && c && d && e && f && h && j && k) {
			output3.innerHTML += 1 + ", " + 4 + ", " + 9 + ", " + 16 + ", " + 25 + ", " + 36 + ", " + 49 + ", " + 64 + ", " + 81 + ", " + 100;
		}
		*/
		output3.innerHTML += i*i + ", ";
	}
}