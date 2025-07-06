document.querySelector(".box").innerHTML
document.querySelector(".box").outerHTML
document.querySelector(".box").innerText
document.querySelector(".box").tagName
document.querySelector(".box").hidden=true
document.querySelector(".box").hidden=false

document.querySelector(".box").innerHTML ="laiba has changed"
document.querySelector(".box").hasAttribute("style")
document.querySelector(".box").getAttribute("style")
document.querySelector(".box").setAttribute("style", "display:flex")

document.querySelector(".box").removeAttribute("style")


let div=document.createElement("div");
div.innerHTML ="i have been inserted in container by <b>laiba </b>";
div.setAttribute("class","created");
document.querySelector(".container").append(div);

let div1=document.createElement("div");
div1.innerHTML ="i have been inserted before container by <b>laiba </b>";
div1.setAttribute("class","created");
document.querySelector(".container").before(div1);

let div2=document.createElement("div");
div2.innerHTML ="i have been inserted after container by <b>laiba </b>";
div2.setAttribute("class","created");
document.querySelector(".container").after(div2);

let cont =document.querySelector(".container");
cont.insertAdjacentHTML("afterbegin", "<b> afterbegin  i am present and here</b> ");
cont.insertAdjacentHTML("afterend", "<b> afterend  i am present and here</b> ");
cont.insertAdjacentHTML("beforebegin", "<b> beforebegin i am present and here</b> ");
cont.insertAdjacentHTML("beforeend", "<b> beforeend i am present and here</b> ");


// document.querySelector(".box").remove()

document.querySelector(".container").classList
document.querySelector(".container").classList.add("laiba")
document.querySelector(".container").classList.add("fatima")
document.querySelector(".container").classList.toggle("fatima")
document.querySelector(".container").classList.remove("fatima")
document.querySelector(".container").className