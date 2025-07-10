let firstCard;
let secondCard;
let cards = []
let sum = 0;
let hasblackjack = false;
let isAlive = false;
let message = ""
let messageEl = document.getElementById("messageEl");
let sumEl = document.querySelector("#sumEl");
let cardEl = document.getElementById("cardEl");

let player = {
    name: 'Laiba',
    chips: 145
};

let playerArea =document.getElementById('playerArea');
playerArea.textContent= player.name + ": $" + player.chips



function startGame() {
    isAlive = true;
    firstCard = getRandomCard();
    secondCard = getRandomCard();
    cardEl.textContent = "Cards: ";
    sumEl.textContent = "Sum: ";
    cards = [firstCard, secondCard]
    sum = firstCard + secondCard

    renderGame();
}

function renderGame() {
    cardEl.textContent = " Cards: "
    for (let index = 0; index < cards.length; index++) {

        cardEl.textContent += cards[index] + " "

    }

    sumEl.textContent = "Sum: " + sum;
    if (sum < 21) {
        message = 'Do u want to draw a new card?';

    }
    else if (sum === 21) {

        message = 'YOU WIN! :)';
        hasblackjack = true;


    }
    else {
        message = 'YOU LOSE! :(';
        isAlive = false;
    }

    messageEl.textContent = message;
}

function newCard() {

    if (isAlive === true && hasblackjack === false) {
        console.log('Drawing a new card');
        let card = getRandomCard();
        sum += card;
        cards.push(card)
        renderGame()

    }

}


function getRandomCard() {

    let newerCard = Math.floor((Math.random() * 13)) + 1;
    if (newerCard > 10) {
        return 10;
    }
    else if (newerCard === 1) {
        return 11;
    }
    else {
        return newerCard;

    }
}