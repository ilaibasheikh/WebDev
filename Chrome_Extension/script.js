let myLeads = []
let oldLeads = []
const inputbtn = document.getElementById('input-btn');
const inputField = document.getElementById('input-el');
const ulEl = document.getElementById('ul-el');
const delbtn = document.getElementById('del-btn');
const leadfromlocal = JSON.parse(localStorage.getItem("myLeads"))

if (leadfromlocal) {
    myLeads = leadfromlocal
    render(myLeads)
}

inputbtn.addEventListener('click', function () {
    myLeads.push(inputField.value);
    inputField.value = ""
    localStorage.setItem("myLeads", JSON.stringify(myLeads))
    render(myLeads) 
})

delbtn.addEventListener('dblclick', function () {
    localStorage.clear();
    myLeads = []
    render(myLeads)
})

function render(leads) {
    let listItems = ""
    for (let index = 0; index < leads.length; index++) {
        // listItems +="<li><a target='_blank' href=' " + leads[index]+ "'>" +leads[index] +"</a></li>"
        listItems += `
        <li>
            <a target='_blank' href='${leads[index]}'>${leads[index]}</a>
        </li>`;
        // const li = document.createElement('li');
        // li.textContent = leads[index];
        // ulEl.append(li)
    }
    ulEl.innerHTML = listItems
}