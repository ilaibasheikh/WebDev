console.log("laiba")
console.log("fatima")

setTimeout(() => {
    console.log("Timeout working")
}, 2000);
console.log("the end")

const callback = (arg) => {
    console.log(arg)
}


const loadScript = ((src, callback) => {
    let sc = document.createElement("script")
    sc.src = src;
    sc.onload = callback("laiba")
    document.head.append(sc)
})

