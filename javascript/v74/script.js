let btn = document.getElementById("btn")

btn.addEventListener("click", ()=> {
    // alert("I was clicked")
    document.querySelector(".box").innerHTML = "I was clicked so i changed"
})
btn.addEventListener("dblclick", ()=> {
    // alert("I was clicked")
    document.querySelector(".box").innerHTML = "I was  double clicked so i changed"
})
btn.addEventListener("contextmenu", ()=> {
    // alert("I was clicked")
    document.querySelector(".box").innerHTML = "only right click"
})
document.addEventListener("keydown", (e)=> {
    console.log(e.key, e.keyCode)
})