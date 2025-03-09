// let obj ={
//     a:1,
//     b:"laibba"
    
// }
// console.log(obj)

// let animal={
//     eats: true
// }

// let rabbit={
//     jumps:true
// }
// rabbit.__proto__=animal;
// console.log(rabbit);
 
class Animal{
    
    constructor(name){
        this.name =name
        console.log('object animal created');
        
    }
    eats(){
        console.log('eating');
        
    }
    jumps(){
        console.log('jumping');
        
    }
}
let a = new Animal('Bunny')
console.log(a);

class lion extends Animal{
    constructor(){
        super('babbar')
        console.log('and iam a lion');
        

    }
    eats(){
        super.eats()
        console.log('eating like a lion');
        
    }
}
let l=new lion("babbar")
console.log(l);