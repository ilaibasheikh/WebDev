async function sleep() {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve(56)
        }, 1000);
    })
}


// (async function main() {//iife immediatelyinvoke function

//     let a = await sleep()
//     let b = await sleep()
//     console.log(a);
//     console.log(b);
    
// })()
//Destructuring

// (async function main() {

//     let [a,b , ...rest]= [1,5,7]
//     console.log(a,b, rest);
  
    
// })()

// //spread
// function sum(a,b,c){
//     return a+b+c
// }
// let arr=[1,2,4]
// let g=sum(arr[0],arr[1], arr[2])
// console.log(g);
// console.log(sum(...arr));

//hoisting
console.log(a1);

var a1;

a1=10