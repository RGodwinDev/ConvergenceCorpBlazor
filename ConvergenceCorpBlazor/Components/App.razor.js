// JavaScript for App component

//times the public convergences open
var openTimes = [
    new Date(), //not any
    new Date(), //Tyria
    new Date(), //HoT
    new Date(), //PoF
    new Date(), //EoD
    new Date(), //SotO
    new Date(), //JW
    new Date()  //VoE
];

var intervals = [
    0, //not any
    0, //Tyria
    0, //HoT
    0, //PoF
    0, //EoD
    0, //SotO
    0, //JW
    0  //VoE
]


function ConvertToLocal(element) {
    let newdate = new Date(element.innerText);
    element.innerText = newdate.toLocaleString([], {
        hour: 'numeric',
        minute: '2-digit'
    });
}

function SetOpenSoon(element) {
    if (!element.classList.contains("timersub5")) {
        element.classList.add("timersub5");
    }
}
function UnsetOpenSoon(element) {
    if (element.classList.contains("timersub5")) {
        element.classList.remove("timersub5");
    }
}

function SetOpenNow(element) {
    if (!element.classList.contains("timeropen")) {
        console.log("adding timeropen!");
        element.classList.add("timeropen");
    }
}
function UnsetOpenNow(element) {
    if (element.classList.contains("timeropen")) {
        console.log("removing timeropen!");
        element.classList.remove("timeropen");
    }
}

function SetCountdownTime(region, date) {
    openTimes[region] = new Date(date);
}

function StartInterval(region) {
    intervals[region] = setInterval(function () {
        var distance = openTimes[region].getTime() - Date.now();
        var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
        var second = Math.floor((distance % (1000 * 60)) / 1000);
        var days = Math.floor((distance % (1000 * 60 * 60 * 24 * 365)) / (1000 * 60 * 60 * 24));

        var timers = document.getElementsByClassName("Timer" + region);
        for (var t of timers) {
            if (distance < 0) {
                t.innerHTML = "NOW";
            }
            else if (days >= 1) {
                t.innerHTML = days.toString() + " Days!";
            }
            else {
                t.innerHTML = hours.toString().padStart(2, '0') + ":" + minutes.toString().padStart(2, '0') + ":" + second.toString().padStart(2, '0');
            }


            if (distance < -600000) { //after 10 minutes of being 'NOW', reset to the next time.
                openTimes[region].setHours(openTimes[region].getHours() + 3);
                var timercontainers = document.getElementsByClassName("timercontain" + region);
                for (var tc of timercontainers) {
                    UnsetOpenNow(tc);
                }
            }
            else if (distance < 0) {
                var timercontainers = document.getElementsByClassName("timercontain" + region);
                for (var tc of timercontainers) {
                    SetOpenNow(tc);
                    UnsetOpenSoon(tc);
                }
            }
            else if (distance < 600000) { //600k ms, 10 minutes
                var timercontainers = document.getElementsByClassName("timercontain" + region);
                for (var tc of timercontainers) {
                    SetOpenSoon(tc);
                }
            }
        }
    }, 1000);
}