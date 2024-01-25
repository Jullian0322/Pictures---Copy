function Dropdown() {
	
	var outputBoxthree = document.getElementById("outputBoxthree");
	
	var statements = document.getElementById("statements");
	var Likes = document.getElementById("Likes");
	var Things = document.getElementById("Things");
	
	var statementsValue = statements.options[statements.selectedIndex].value
	var LikesValue = Likes.options[Likes.selectedIndex].value
	var ThingsValue = Things.options[Things.selectedIndex].value
	
	outputBoxthree.innerHTML = statementsValue + " "+ Likes.value + " " + Things.value
	
	if (Likes.selectedIndex == 0) {
		outputBoxthree.style.background = "cyan";
	}
	else if (Likes.selectedIndex == 1) {
		outputBoxthree.style.background = "green";
	}
	else {
		outputBoxthree.style.background = "RGB(194,24,7)";
	}
}