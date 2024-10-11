// 4. Function Polymorphism with apply(), call(), and bind()
// JavaScript functions can also exhibit polymorphic behavior with the help of apply(), call(), and bind(). 
// These methods allow you to invoke a function with different this contexts, 
// enabling you to reuse functions across different objects.

// Object Declaration 
const person = {
    firstName: "John",
    lastName: "Doe",
    getFullName: function() {
      return this.firstName + " " + this.lastName;
    }
  };
  
  const anotherPerson = {
    firstName: "Jane",
    lastName: "Smith"
  };
  
  // Using call() to reuse the method on another object
  console.log(person.getFullName.call(anotherPerson)); 