// 2. Method Overloading (Simulating Compile-Time Polymorphism)
// Method overloading refers to having multiple methods with the same name but different parameters. 
// JavaScript does not support true method overloading like other languages such as Java or C#. 
// However, you can simulate method overloading by using techniques such as checking the number of arguments 
// or using rest parameters.

class Calculator {
    // Single method that can behave differently based on input types
    add(a, b) {
      if (typeof a === "number" && typeof b === "number") {
        return a + b;
      } else if (Array.isArray(a) && Array.isArray(b)) {
        return [...a, ...b]; // Merging arrays if inputs are arrays

      } else if (typeof a === "string" && typeof b === "string") {
        return a + " " + b; // Concatenating strings if inputs are strings

      } else {
        return "Unsupported data types";
      }
    }
  }
  
  const calc = new Calculator();
  
  console.log(calc.add(2, 3));               
  console.log(calc.add("Hello", "Everyone!"));   
  console.log(calc.add([1, 2], [3, 4]));     
  console.log(calc.add(5, "test"));          