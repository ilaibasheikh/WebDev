console.log("functions")

function greeting(name) {
    console.log("hey, "+name +", how are you?")
}
greeting("laiba")
function sum(a,b){
    console.log(a+b)
}
sum(5,6)

 let result =0
function sumreturn(a,b){
   result =a+b
    return result
}
 result = sumreturn(3,5)
console.log("your result: " +result)

//arrow function
const func1= (x)=>{
    
    console.log("iam arrow function"+x)
}

func1(34)