let firstCard=10;
let secondCard=1;
let cards =[firstCard,secondCard]
let sum = firstCard+secondCard
let hasblackjack= false;
let isAlive= true;
let message =""
let messageEl =document.getElementById("messageEl");
// let sumEl = document.getElementById("sumEl");
let sumEl = document.querySelector("#sumEl");
let cardEl =document.getElementById("cardEl");

function startGame(){
    renderGame();
}

function renderGame(){
    cardEl.textContent="Cards: " + cards[0] + " and " +cards[1]
    sumEl.textContent ="Sum: " + sum;
    if(sum<21){
        message ='Do u want to draw a new card?';
        
    }
    else if(sum===21){
        
        message ='YOU WIN! :)';
        hasblackjack=true;
        
        
    }
    else{
        message ='YOU LOSE! :(';
        isAlive=false;
    }
    
    messageEl.textContent=message;
}   

function newCard(){
    console.log('Drawing a new card');
    let card=4;
    sum+=card;
    renderGame()
    
}