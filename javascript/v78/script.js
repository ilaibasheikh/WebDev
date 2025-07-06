const randomDelay = () => {
    return new Promise((resolve, reject) => {
        let timeout = 1 + 6 * Math.random();
        setTimeout(() => {
            resolve();
        }, timeout * 1000);
    });
};

const addItem = async (item) => {
    await randomDelay();
    let div = document.createElement("div");
    div.innerHTML = item;
    document.body.append(div);
};

let text = ["Hacking initialized", "Reading Files", "Password Files Detected", "Sending all passwords and personal files to server", "Cleaning up"];

async function main() {
    // This interval will add the dots to every message, including the initial message
    setInterval(() => {
        let last = document.body.lastElementChild;
        if (last.innerHTML.endsWith("...")) {
            last.innerHTML = last.innerHTML.slice(0, last.innerHTML.length - 3);
        } else {
            last.innerHTML = last.innerHTML + ".";
        }
    }, 700);

    // Start with the initial message and then add other items
    
    for (const item of text) {
        await addItem(item);
    }
}

main();
