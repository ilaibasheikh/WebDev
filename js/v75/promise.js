
console.log('this is promises');
let prom1=new Promise ((resolve,reject) => {
    let a =Math.random();
    console.log(a)
    if(a<0.5){
        reject("ARE YOU CRAZY  1")
        

    }
    else{
        setTimeout(() => {
          console.log("Promise 1:")
          resolve("laiba 1")
        }, 1000);
      }

    }
)
let prom2=new Promise ((resolve,reject) => {
    let a =Math.random();
    console.log(a)
    if(a<0.5){
        reject("ARE YOU CRAZYm 2")
        

    }
    else{
        setTimeout(() => {
          console.log("Pomise 2")
          resolve("laiba 2")
        }, 1000);
      }

    }
)

let p3=Promise.race([prom1,prom2])
p3.then((a)=>{
    console.log(a);
    
}).catch((err)=>{
    console.log(err);
    
})