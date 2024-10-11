//1. Using Closures (Functional Encapsulation)
//In this approach, we create functions that can access variables within their lexical scope. 
//This creates "private" variables that cannot be accessed from outside the function.

function Person(name) {
    let age = 30; // Private variable
  
    return {
      getName: function() {
        return name;
      },
      getAge: function() {
        return age;
      },
      celebrateBirthday: function() {
        age++; // Modifying the private variable
        console.log(`Happy Birthday! Age is now ${age}`);
      }
    };
  }
  
  const person = Person('John');
  console.log(person.getName());  
  console.log(person.getAge());  
  person.celebrateBirthday();     
  //console.log(person.age);       