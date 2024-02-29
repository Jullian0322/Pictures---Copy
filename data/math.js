function setToOne() {
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
    let number = document.getElementsByName("input")

    if (floor.value = 1) {
        Math.floor(number)
    }
    else if (cieling.value = 1) {
        Math.ceil(number)
    }
    else if (round.value = 1) {
        Math.round(number)
    }
    else if (truncate.value = 1) {
        Math.trunc(number)
    }
    else if (sine.value = 1) {
        Math.sin(number)
    }
    else if (cosine.value = 1) {
        Math.cos(number)
    }
    else if (absolute.value = 1) {
        Math.abs(number)
    }
    else if (power.value = 1) {
        Math.pow(number)
    }
    else if (squareRoot.value = 1) {
        Math.sqrt(number)
    }
    else if (random.value = 1) {
        Math.random(number)
    }
}