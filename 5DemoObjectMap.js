// Apart from storing data, you can attach functionality to an object whereas maps are restricted to just storing data. 

// Create an object with data and a method
const person = {
    name: 'Alice',
    age: 25,
    city: 'Wonderland',

    getInfo: function() {
        return `${this.name}, ${this.age} years old, lives in ${this.city}.`;
    }
};

console.log("Object Example:");
console.log(person.name); 
console.log(person.age);  

console.log(person.getInfo()); 


// Create a Map to store data
const personMap = new Map();
personMap.set('name', 'Alice');
personMap.set('age', 25);
personMap.set('city', 'Wonderland');


console.log("\nMap Example:");
console.log(personMap.get('name')); 
console.log(personMap.get('age'));  


//personMap.set('getInfo', function() {
  //  return `${this.get('name')}, ${this.get('age')} years old, lives in ${this.get('city')}.`;
});

console.log(personMap.get('getInfo')());