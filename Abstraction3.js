//3. Using Abstract Base Classes and Interfaces (Simulating)
//JavaScript doesn’t have built-in support for "abstract" classes like in some other OOP languages (e.g., Java or C#), 
//but you can simulate abstraction using base classes (parent classes) and inheritance. 
//You can create methods in a base class that act as a guideline for child classes, and those methods can be overridden.

class Animal {
    // "Abstract" method - should be implemented by child classes
    makeSound() {
      throw new Error("This method must be implemented by a subclass");
    }
  
    // Common method
    sleep() {
      console.log("Sleeping...");
    }
  }
  
  class Dog extends Animal {
    // Implementing the abstract method
    makeSound() {
      console.log("Woof! Woof!");
    }
  }
  
  const myDog = new Dog();
  myDog.makeSound(); 
  myDog.sleep();    
   
  // Attempting to create an instance of the abstract class itself will fail
  // const myAnimal = new Animal(); 