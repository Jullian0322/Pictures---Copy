let output = document.getElementById("hangman");
let wrong = document.getElementById("wrong");

function hangMan() {
    let random = Math.floor(Math.random() * 5);

    return random;
}

function pickAnAnswer() {
    const fruits = ["oranges", "strawberries", "avocado", "watermelon", "grapes", "kiwi", "blueberries", "mango", "grapefruit", "apple"];
    const games = ["mario", "sonic", "megaman", "pikmin", "pokemon", "battlefield", "gta", "fallout", "splatoon", "cod"];
    const sports = ["basketball", "baseball", "football", "soccer", "hockey", "cricket", "skateboard", "vollyball", "tenis", "golf"];
    const countries = ["usa", "france", "uk", "russia", "turkey", "greece", "germany", "japan", "china", "india"];
    const animals = ["dog", "cat", "fish", "hamster", "pig", "horse", "cow", "chicken", "kiwi", "turkey"];

    if (hangMan() = 0) {
        let FRUITS = Math.floor((Math.random(fruits) * 10));

        output.innerhtml = FRUITS;

        if (keypress() = FRUITS) {
            for (let i = 0; i < FRUITS.Length(); i++) {
                if (i != keypress()) {
                    temp += " ";
                }
                else {
                    temp += keypress();
                }
            }
        }
        else {
            wrong += keypress();
        }
    }
    else if (hangMan() = 1) {
        let GAMES = Math.floor((Math.random(games) * 10));

        output.innerhtml = GAMES;

        if (keypress() = GAMES) {
            for (let i = 0; i < GAMES.Length(); i++) {
                if (i != keypress()) {
                    temp += " ";
                }
                else {
                    temp += keypress();
                }
            }
        }
        else {
            wrong += keypress();
        }
    }
    else if (hangMan() = 2) {
        let SPORTS = Math.floor((Math.random(sports) * 10));

        output.innerhtml = SPORTS;

        if (keypress() = SPORTS) {
            for (let i = 0; i < SPORTS.Length(); i++) {
                if (i != keypress()) {
                    temp += " ";
                }
                else {
                    temp += keypress();
                }
            }
        }
        else {
            wrong += keypress();
        }
    }
    else if (hangMan() = 3) {
        let COUNTRIES = Math.floor((Math.random(countries) * 10));

        output.innerhtml = COUNTRIES;

        if (keypress() = COUNTRIES) {
            for (let i = 0; i < COUNTRIES.Length(); i++) {
                if (i != keypress()) {
                    temp += " ";
                }
                else {
                    temp += keypress();
                }
            }
        }
        else {
            wrong += keypress();
        }
    }
    else if (hangMan() = 4) {
        let ANIMALS = Math.floor((Math.random(animals) * 10));

        output.innerhtml = ANIMALS;

        if (keypress() = ANIMALS) {
            for (let i = 0; i < ANIMALS.Length(); i++) {
                if (i != keypress()) {
                    temp += " ";
                }
                else {
                    temp += keypress();
                }
            }
        }
        else {
            wrong += keypress();
        }
    }
}