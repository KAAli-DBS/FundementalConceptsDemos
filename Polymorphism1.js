// 1. Method Overriding (Runtime Polymorphism)
// Method overriding is the most common form of polymorphism in JavaScript, 
// where a subclass provides a specific implementation of a method that is already defined in its parent class. 
// This allows subclasses to define their own behavior while maintaining a consistent interface.

class Animal {
    makeSound() {
      console.log("The animal makes a sound");
    }
  }

  class Dog extends Animal { 
    makeSound() {
      console.log("The dog barks");
    }
  }
  
  class Cat extends Animal {
    makeSound() {
      console.log("The cat meows");
    }
  }
  
  const myDog = new Dog();
  const myCat = new Cat();
  
  myDog.makeSound(); 
  myCat.makeSound(); 
  
  //Polymorphism using an array of different animals
  const animals = [myDog, myCat];
  animals.forEach(animal => animal.makeSound()); 