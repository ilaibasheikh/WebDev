let arr=[1,2,3,4,5]
console.log(arr)
console.log(arr.length, typeof arr)
console.log(arr[0])
arr[0]=256
console.log(arr[0])
console.log(arr.toString())
arr.push(100)
console.log(arr)
arr.push("laiba")
console.log(arr)
arr.shift(1)
console.log(arr)
arr.unshift(130)
console.log(arr)
// 

let num=[2,4,5,7,9]

num.forEach(element => {
    console.log(element*element)
});
let f=num.filter(a=>{
return a>5
})
console.log(f)

let x=num1.filter((a)=>{

})