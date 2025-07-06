let students = ["laiba", "hani", "mustafaamasood", "SabinaRasheed", "hayaali", "neha", "battool", "muhammadali"]

let houses =[]

for (const c of students) {
    
    if(c.length<6){
houses.push("Gryffindor")
    }
    else if(c.length>6 && c.length<8){
        houses.push("Hufflepuff")
    }
    else if(c.length>8 && c.length<12){
        houses.push("Ravenclaw")
    }
    else{
        houses.push("Slytherin")
    }
}
console.log(houses);
