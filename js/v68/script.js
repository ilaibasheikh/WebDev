document.getElementById("3").style.backgroundColor ="red"
document.querySelector(".box").style.backgroundColor ="blue" //pehla element with .box
document.querySelectorAll(".box").forEach(e=>{
e.style.backgroundColor="pink"
})
document.getElementsByTagName("div")