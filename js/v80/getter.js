class User {
    constructor(name) {
      this.name = name; // directly assign to the private variable
    }
  
    get name() {
      return this._name;  // return the private variable
    }
  
    set name(value) {
      if (value.length < 4) {
        console.log("Name is too short.");
        return;
      }
      this._name = value;  // assign to the private variable
    }
  }
  
  let user = new User("Joh");
  console.log(user.name); // Outputs: John (if the name is valid)
  user.name = "Harry";
  console.log(user.name); // Outputs: Harry
  