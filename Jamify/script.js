
console.log('script working');
let currentSong = new Audio();
let playbar = document.querySelector(".pl");
let previous = document.querySelector(".prev");
let next = document.querySelector(".next");


function secondsToMinutesSeconds(seconds) {
    if (isNaN(seconds) || seconds < 0) {
        return "00:00";
    }

    const minutes = Math.floor(seconds / 60);
    const remainingSeconds = Math.floor(seconds % 60);

    const formattedMinutes = String(minutes).padStart(2, '0');
    const formattedSeconds = String(remainingSeconds).padStart(2, '0');

    return `${formattedMinutes}:${formattedSeconds}`;
}

async function getsongs() {
    let a = await fetch('http://127.0.0.1:3000/songs/');
    let response = await a.text();
    let div = document.createElement("div");
    div.innerHTML = response;
    let as = div.getElementsByTagName("a");
    let songs = [];
    for (let index = 0; index < as.length; index++) {
        const element = as[index];
        if (element.href.endsWith(".mp3")) {
            songs.push(element.href.split("/songs/")[1]);
        }
    }
    console.log(songs); // Log the songs array
    return songs;
}


const playmusic = (track, pause = false) => {
    currentSong.src = "/songs/" + track;
    if (!pause) {
        currentSong.play();
        playbar.src = "img/pause.svg";
    }
    document.querySelector(".songinfo").innerHTML = decodeURI(track);
    document.querySelector(".songtime").innerHTML = "00:00 / 00:00";
};


async function main() {



    let songs = await getsongs()
    playmusic(songs[0], true)
    // The play button (image) in the playbar
    playbar.addEventListener("click", () => {
        if (currentSong.paused) {
            currentSong.play();
            playbar.src = "img/pause.svg"; // Change the playbar SVG to pause when the music plays
            console.log('played');
        } else {
            currentSong.pause();
            playbar.src = "img/playbar.svg"; // Change the playbar SVG to play when the music is paused
            console.log('paused');
        }
    });


    let songul = document.querySelector(".songlist").getElementsByTagName("ul")[0];
    for (const song of songs) {
        songul.innerHTML = songul.innerHTML + `
        <li>
            <img class="invert" src="img/music.svg" alt="">
            <div class="info">
                <div class="songname">${song.replaceAll("%20", " ")}</div>
                <div class="songartist">ilaibasheikh</div>
            </div>
            <div class="playnow">
                <img class="invert" src="img/playbar.svg" alt="">
            </div>
        </li>`;
    }


    Array.from(document.querySelector(".songlist").getElementsByTagName("li")).forEach((e) => {
        e.addEventListener("click", (element) => {
            console.log(e.querySelector(".info .songname").innerText);
            let songName = e.querySelector(".info .songname").innerText.trim();
            playmusic(songName);
        });
    });


    currentSong.addEventListener("timeupdate", () => {
        console.log(currentSong.currentTime, currentSong.duration);

        document.querySelector(".songtime").innerHTML = `${secondsToMinutesSeconds(currentSong.currentTime)} / ${secondsToMinutesSeconds(currentSong.duration)}`
        document.querySelector(".circle").style.left = (currentSong.currentTime / currentSong.duration) * 100 + "%";
    })

    document.querySelector(".seekbar").addEventListener("click", e => {
        let percent = (e.offsetX / e.target.getBoundingClientRect().width) * 100;
        document.querySelector(".circle").style.left = percent + "%";
        currentSong.currentTime = ((currentSong.duration) * percent) / 100
    })

    document.querySelector(".hamburger").addEventListener("click", () => {
        document.querySelector(".left").style.left = "0"
    })
    document.querySelector(".close").addEventListener("click", () => {
        document.querySelector(".left").style.left = "-120%"
    })

    previous.addEventListener("click", () => {


        currentSong.pause()
        console.log("Previous clicked")
        let index = songs.indexOf(currentSong.src.split("/").slice(-1)[0])
        if ((index - 1) >= 0) {
            playmusic(songs[index - 1])
        }
    })


    next.addEventListener("click", () => {

        currentSong.pause()
        console.log("Next clicked")

        let index = songs.indexOf(currentSong.src.split("/").slice(-1)[0])
        if ((index + 1) < songs.length) {
            playmusic(songs[index + 1])
        }
    })


}
main()