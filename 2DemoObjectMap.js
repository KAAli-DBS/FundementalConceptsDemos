// An object has a prototype and may contain a few default keys which may collide with your own keys if you are not careful. 
//A map on the other hand does not contain any keys by default. 


// Create an object
const obj = {};

// Add a key named 'toString' to the object
obj.toString = 'This is my custom key';

console.log("Object Example:");
console.log(obj.toString); 

// Check if 'toString' is our custom key or inherited from the prototype
console.log(obj.hasOwnProperty('toString'));
console.log(Object.prototype.toString);      


// Create a Map
const map = new Map();

// Add a key named 'toString' to the map
map.set('toString', 'This is my custom key in Map');

console.log("\nMap Example:");
console.log(map.get('toString')); 

// Check if the map has its own 'toString' key (maps don’t have default keys)
console.log(map.has('toString')); 
console.log(map.get('hasOwnProperty')); 

/*
Key Takeaways for Students:

Objects:
Objects come with built-in keys (like toString, hasOwnProperty) from their prototype.
You can still add a custom key like toString, but there is potential for confusion or key collisions with the inherited methods from the prototype.

Maps:
Maps do not have any inherited properties or methods.
You can add any key (like toString), and there is no risk of conflicting with a built-in method because maps don’t inherit anything from a prototype.
*/