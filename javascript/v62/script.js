console.log("Business name generator")


let first, second, third
let random1 =Math.random()
let random2 =Math.random()
let random3 =Math.random()
{if(random1<0.33){
    first = "Crazy"

}
else if(random1>0.33&&random1<0.66){
    first = "Amazing"
    
}
else{
    first = "Fine"
   
}
}
{if(random2<0.33){
    
    second ="engine"
   
}
else if(random2>0.33&&random2<0.66){
    
    second ="foods"
}
else{
    
    second ="Garments"
}
}
{
if(random3<0.33){
    
    third ="bros"
}
else if(random3>0.33&&random3<0.66){
    
    third ="limited"
}
else{
    
    third ="hub"
}
}

console.log("Your business name generator is " + first + " " +second + " " +third)
