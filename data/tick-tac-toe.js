function playTTT() {
    let output = document.getElementsByClassName("grid-item");
}

function showImg() {
    let output = document.getElementsByClassName("grid-item");

    if (output.value = 0) {
        output.createElement("IMG");
        output.setAttribute("src", "X.png");
        output.value = 1;
    }
    else {
        output.createElement("IMG");
        output.setAttribute("src", "O.png");
        output.value = 0;
    }
}