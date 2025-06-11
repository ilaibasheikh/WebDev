const fs= require("fs")


// console.log(fs);
console.log('starting');
// fs.writeFileSync("laiba.txt", "Laiba is good")
fs.writeFile("laiba1.txt", "Hey this is great",()=>{
    console.log('done');
    fs.readFile("laiba1.txt",(error,data)=>{
        console.log(error,data.toString());
        
    })
    
})
fs.appendFile("laiba1.txt", " and i am her" , (e,d)=>{
    console.log('done again');
    
    
    console.log(d);
   
    
})
console.log('ending');