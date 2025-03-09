let x =prompt("enter num")
let num = parseInt(x)
function factorial(num){
    let arr = Array.from(Array(num+1).keys())
    console.log(arr.slice(1,))
    let c= arr.slice(1,).reduce((a,b)=>{
return a*b
    })
    console.log(c)
}
factorial(num);