function hangMan() {
    const fruits = ["oranges", "strawberries", "avocado", "watermelon", "grapes", "kiwi", "blueberries", "mango", "grapefruit", "apple"];
    const games = ["mario", "sonic", "megaman", "pikmin", "pokemon", "battlefield", "gta", "fallout", "splatoon", "cod"];
    const sports = ["basketball", "baseball", "football", "soccer", "hockey", "cricket", "skateboard", "vollyball", "tenis", "golf"];
    const countries = ["usa", "france", "uk", "russia", "turkey", "greece", "germany", "japan", "china", "india"];
    const animals = ["dog", "cat", "fish", "hamster", "pig", "horse", "cow", "chicken", "kiwi", "turkey"];

    let random = Math.floor((Math.random() * 4));
    let output = document.getElementById("hangman");
    if (random = 0) {
        let FRUITS = fruits.floor((Math.random() * 9));

        output.innerhtml = FRUITS;
    }
    else if (random = 1) {
        let GAMES = games.floor((Math.random() * 9));

        output.innerhtml = GAMES;
    }
    else if (random = 2) {
        let SPORTS = sports.floor((Math.random() * 9));

        output.innerhtml = SPORTS;
    }
    else if (random = 3) {
        let COUNTRIES = countries.floor((Math.random() * 9))

        output.innerhtml = COUNTRIES;
    }
    else if (random = 4) {
        let ANIMALS = animals.floor((Math.random() * 9))

        output.innerhtml = ANIMALS;
    }
}