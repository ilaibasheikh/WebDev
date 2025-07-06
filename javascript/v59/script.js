function calculator(x, y){
    let a=Math.random( )
    console.log(a)
    if( a<0.1){
        console.log("Addition= "+faultyadd(x,y))
        console.log("Multiplication= "+faultymultiply(x,y))
        console.log("Subtraction= "+faultysubtract(x,y))
        console.log("Divison= "+faultydivide(x,y))
    }
    else{
        console.log("Addition= "+ (x+y))
        console.log("Multiplication= "+(x*y))
        console.log("Subtraction= "+(y-x))
        console.log("Divison= "+(y/x))
    }

}
function faultyadd(x,y){
    return y-x
}
function faultymultiply(x,y){
    return y+x
}
function faultysubtract(x,y){
    return y/x
}
function faultydivide(x,y){
    return y**x
}

calculator(5,15)