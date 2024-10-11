//2. With ES6 and later versions, JavaScript introduced class syntax and private class fields, 
//denoted by the # prefix. 
//This allows for true encapsulation, where the field is private to the class and 
//not accessible from outside the class.

class Car {
    #speed = 0;  // Private field
  
    constructor(model) {
      this.model = model;  // Public property
    }
  
    accelerate() {
      this.#speed += 10;
      console.log(`Speed is now ${this.#speed}`);
    }
  
    getSpeed() {
      return this.#speed;
    }
  }
  
  const myCar = new Car('Tesla');
  console.log(myCar.model);       
  myCar.accelerate();             
  console.log(myCar.getSpeed());  
  //console.log(myCar.#speed);     