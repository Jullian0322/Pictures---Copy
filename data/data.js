
/*Intro*/
pageSize() ;
     function pageSize() {
        document.getElementById("Size").innerhtml = window.innerWidth + " x " + window.innerHeight;
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
        Switch.addEventListener("click", playMusic(Switch))
        if (Switch.value === "OFF") {
            Switch.value = "ON";
        }
        else {
            Switch.value = "OFF";
        }
    }
    function playMusic(Switch) {
        let Music = document.getElementById("music");
        if (Switch.value === "OFF" && keypress(patternABC())) {
            Music.play();
        }
        else {
            Music.pause();
        }
    }
    function patternABC() {
        let i = 0
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
    /*
    function addEventListener() {
        let Output = document.getElementById("output")
        let Outside = document.getElementsByClassName("outside").addEventListener("clcik", Output);
        let Inside = document.getElementsByClassName("inside").addEventListener("clcik", Output);
        Outside.innerHTML += "outside";
        Inside.innerHTML += "inside";
    }
    */
    function dataStuff() {
        let Output = document.getElementById("output")
        Output.innerHTML = "Today is " + todaysDay() + "of " + monthPlusYear() + "It is a " + getWeek() + "There are " + getMin() + "minutes left for the " + getHour() + "hour. Just for kicks there have been " + getSecFor70() + "secounds since January 1, 1970";
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
    function playRPS() {
        let user = 1;
        let computer = Math.random() * 3;

        document.getElementById("rock").addEventListener("click", rockFun());
        document.getElementById("paper").addEventListener("click", paperFun());
        document.getElementById("scissors").addEventListener("click", scissorsFun());
        if (EventListener = rock) {
            if (user > computer) {
                console = "You Win";
                console = "computer picked scissors"
            }
            else if (user < computer) {
                console = "You lose";
                console = "computer picked paper"
            }
            else {
                console = "Tie try again";
            }
        }
        else if (EventListener = paper) {
            if (user > computer) {
                console = "You Win";
                console = "computer picked rock"
            }
            else if (user < computer) {
                console = "You lose";
                console = "computer picked scissors"
            }
            else {
                console = "Tie try again";
            }
        }
        else if (EventListener = scissors) {
            if (user > computer) {
                console = "You Win";
                console = "computer picked paper"
            }
            else if (user < computer) {
                console = "You lose";
                console = "computer picked rock"
            }
            else {
                console = "Tie try again";
            }
        }
    }

    function rockFun() {
        value = rock;
        return value;
    }
    function paperFun() {
        value = paper;
        return value;
    }
    function scissorsFun() {
        value = scissors;
        return value;
    }