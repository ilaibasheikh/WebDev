const inputbtn = document.getElementById('input-btn');
let myLeads=[]
const inputField = document.getElementById('input-el');
const ulEl=document.getElementById('ul-el');

inputbtn.addEventListener('click', function(){    
    myLeads.push(inputField.value);
   
    renderLeads()
    inputField.value=""
    
})
function renderLeads(){

    let listItems=""
    for (let index = 0; index < myLeads.length; index++) {
        // listItems +="<li><a target='_blank' href=' " + myLeads[index]+ "'>" +myLeads[index] +"</a></li>"
        listItems +=`
        <li>
            <a target='_blank' href='${myLeads[index]}'>${myLeads[index]}</a>
        </li>`;
        
        
        // const li = document.createElement('li');
        // li.textContent = myLeads[index];
        // ulEl.append(li)
        
    }
    ulEl.innerHTML=  listItems
}