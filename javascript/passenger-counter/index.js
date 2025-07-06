
let count = 0;
let counter = document.getElementById("counter")
let addentry = document.getElementById("prev")

function increment() {
    count += 1
    console.log("Count is: ", count)
    console.log("The button was clicked")
    counter.innerText = count
}

function save() {
    let prevCount = count + " -> ";
    addentry.textContent += prevCount
    count =0;
    counter.textContent = count;   
}


let firstName = "laiba"
let lastName = "fatima"
let fullName = firstName +" "+lastName;
console.log(fullName)


