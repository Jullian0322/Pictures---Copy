function setToOne(value) {
    if (value = 0) {
        value = 1;
    }
    else {
        value = 0;
    }
}

function doMath() {
    let floor = document.getElementsByName("floor");
    let cieling = document.getElementsByName("ceiling");
    let round = document.getElementsByName("round");
    let truncate = document.getElementsByName("truncate");
    let sine = document.getElementsByName("sine");
    let cosine = document.getElementsByName("cosine");
    let absolute = document.getElementsByName("absolute");
    let power = document.getElementsByName("power");
    let squareRoot = document.getElementsByName("squareRoot");
    let random = document.getElementsByName("random");
    let number = document.getElementsByName("input");
    let output = document.getElementById("results");

    if (floor.value = 1) {
        output.innerHTML += Math.floor(number);
    }
    else if (cieling.value = 1) {
        output.innerHTML += Math.ceil(number)
    }
    else if (round.value = 1) {
        output.innerHTML += Math.round(number)
    }
    else if (truncate.value = 1) {
        output.innerHTML += Math.trunc(number)
    }
    else if (sine.value = 1) {
        output.innerHTML += Math.sin(number)
    }
    else if (cosine.value = 1) {
        output.innerHTML += Math.cos(number)
    }
    else if (absolute.value = 1) {
        output.innerHTML += Math.abs(number)
    }
    else if (power.value = 1) {
        output.innerHTML += Math.pow(number)
    }
    else if (squareRoot.value = 1) {
        output.innerHTML += Math.sqrt(number)
    }
    else if (random.value = 1) {
        output.innerHTML += Math.random(number)
    }
}