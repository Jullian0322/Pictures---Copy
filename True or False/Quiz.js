function startQuiz() {
	output = document.getElementById("leftCol");
	output2 = document.getElementById("middeCol");
	output3 = document.getElementById("rightCol");
	for (var i=1; i<=100; i++) {
		if (i % 2 == 0) {
			output.innerHTML += i
		}
		else if (i % 2 != 0) {
			output2.innerHTML += i
		}
		else if (i = math.sqrt(1)) {
			output3.innerHTML += i
		}
	}
}