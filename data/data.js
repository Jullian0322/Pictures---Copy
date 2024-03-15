
/*Intro*/
pageSize() ;
     function pageSize() {
        document.getElementById("Size").innerHTML = window.innerWidth + " x " + window.innerHeight;
    }

    window.addEventListener('resize', function(event) {
        pageSize();
    }, true);

    let date = new Date();
	document.getElementById("Date").innerHTML = date;

    /*Tuesday work*/
    function item(AddorRemove) {
        let theList = document.getElementById("List");
        let theNumber = document.getElementById("Numbers");
        let theOther = document.getElementById("other");
        let theItem = document.getElementsByName("items").value.trim();

        if(theItem == "") {
            document.getElementById("items").value = "";
        }
        else {
            addRemoveEach(theList, theItem, AddorRemove)
            addRemoveEach(theNumber, theItem, AddorRemove)
            addRemoveEach(the, theItem, AddorRemove)
        }
    }
       function addRemoveEach(theList, theItem, AddorRemove) {
        let foundIt = false;
        let i = 0;
       
        // See if it is there
        for (i=0; i<theList.children.length; i++) {
            if (theList.children[i].textContent == theItem) {
                foundIt = true;
                break;
            }
        }
       
        if (AddorRemove == "Add" && !foundIt) {
            let li = document.createElement('li');
            li.appendChild(document.createTextNode(theItem));
            theList.appendChild(li);
        }

        else if (AddorRemove == "Remove" && foundIt) {
            theList.removeChild(theList.children[i]);
        }
    }
    /*Wednesday work*/
    // Music
    function OnOffSwitch() {
        let Switch = document.getElementById("switch");
        if (Switch.value === "OFF") {
            Switch.value = "ON";
        }
        else {
            Switch.value = "OFF";
        }
    }
    function playMusic(Switch) {
        let Music = document.getElementById("music");
        if (Switch.value === "OFF" && keydown(a)) {
            Music.play();
        }
        else {
            Music.pause();
        }
    }
    // Video
    function VideoShowing() {
        document.getElementById("hide").style.display = "block";
        let Video = document.getElementById("video");
        Video.play();
    }
    function CloseVideo() {
        document.getElementById("hide").style.display = "none";
        let Video = document.getElementById("video")
        Video.pause();
    }
    /*Thursday work*/
    function addEventListener() {
        let Output = document.getElementById("output")
        let Outside = document.getElementsByClassName("outside");
        let Inside = document.getElementsByClassName("inside");

        Outside.addEventListener("clcik", Output);
        Inside.addEventListener("clcik", Output);

        Outside.innerHTML += "outside ";
        Inside.innerHTML += "inside ";
    }
    function dataStuff() {
        let Output = document.getElementById("output")
        Output.innerHTML = "Today is " + todaysDay() + "of " + monthPlusYear() + "It is a " + getWeek() + "There are " + getMin() + "minutes left for the " + getHour() + "hour. Just for kicks there have been " + getSecFor70() + "milisecounds since January 1, 1970";
    }
    function todaysDay() {
        const day = new Date();
        let d = day.getDate();
        return d + " ";
    }
    function monthPlusYear() {
        const month = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

        const m = new Date();
        let Month = month[m.getMonth()];

        let year = m.getFullYear();
        return Month + ", " + year + ". ";
    }
    function getWeek() {
        const weekday = ["Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"];

        const week = new Date();
        let w = weekday[week.getDay()];

        return w + ". ";
    }
    function getMin() {
        const m = new Date();
        let minutes = m.getMinutes();
        let time = 60;
        let result = time - minutes;

        return result + " ";
    }
    function getHour() {
        const h = new Date();
        let hour = h.getHours();

        return hour + " ";
    }
    function getSecFor70() {
        const d = new Date();
        let seconds = d.getTime();
        let result = seconds.toLocaleString();

        return result + " ";
    }
    // friday work
    function playRPS(user) {
        let computer = Math.floor(Math.random() * 3);

        if (computer == 0) {
            if (user == 2) {
                console.log("you win");
            }
            else if (user == 1) {
                console.log("you lost");
            }
            else {
                console.log("draw");
            }
        }
        else if (computer == 1) {
            if (user == 0) {
                console.log("you win");
            }
            else if (user == 2) {
                console.log("you lost");
            }
            else {
                console.log("draw");
            }
        }
        else if (computer == 2) {
            if (user == 1) {
                console.log("you win");
            }
            else if (user == 0) {
                console.log("you lost");
            }
            else {
                console.log("draw");
            }
        }
    }