//4. Using WeakMap (True Private Variables)
//Another method is to use a WeakMap to store private variables. 
//This method can offer a more secure encapsulation by keeping private data out of the instance itself.

const privateData = new WeakMap();

class User {
  constructor(name, password) {
    this.name = name;
    privateData.set(this, { password }); // private field stored in WeakMap
  }

  checkPassword(input) {
    const data = privateData.get(this);
    return data.password === input;
    // === strict equality operator, It checks both the value and the type of the operands being compared. 
  }
}

const user = new User('Bob', 'mypassword');
console.log(user.name);                
console.log(user.checkPassword('mypassword')); 
//console.log(user.password);            