let a=prompt("enter first num")
let b=prompt("enter second num")
sum=parseInt(a)+parseInt(b)
if (isNaN(a) || isNaN(b)){
    throw SyntaxError("this is not okay")
}

console.log("The sum is "+sum);
try{
    console.log("The sum is "+sum*x);
}catch(err){
console.log('Error hai');

}finally{
    console.log('Chal ja bhai');
    
}