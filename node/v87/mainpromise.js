import fs from "fs/promises"
let a= await fs.readFile("laiba.txt")
let b= await fs.writeFile("laiba.txt", "this is awesome")
console.log(a.toString(),b);
