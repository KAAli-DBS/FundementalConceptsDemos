//1. Using Classes and Methods (ES6+)
//You can create an abstraction by defining classes with methods that expose only the relevant behavior to the user 
//and hide internal logic.

class CoffeeMachine {
    // Internal method
    #boilWater() {
      console.log("Boiling water...");
    }
  
    // Internal method
    #brewCoffee() {
      console.log("Brewing coffee...");
    }
  
    // Public method
    makeCoffee() {
      this.#boilWater();
      this.#brewCoffee();
      console.log("Your coffee is ready!");
    }
  }
  
  const myMachine = new CoffeeMachine();
  myMachine.makeCoffee(); 
  //myMachine.#boilWater(); 