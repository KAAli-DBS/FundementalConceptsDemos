// Objects are not iterables whereas maps are iterables. 

// Create an object
const obj = {
    name: 'Alice',
    age: 25,
    city: 'Wonderland'
};

console.log("Object Example:");

// for (let [key, value] of obj) { 
//    console.log(key, value);
// }

// Instead, use Object.entries() to make it iterable
for (let [key, value] of Object.entries(obj)) {
    console.log(`${key}: ${value}`);
}


// Create a map
const map = new Map();
map.set('name', 'Alice');
map.set('age', 25);
map.set('city', 'Wonderland');

console.log("\nMap Example:");

// Directly use 'for...of' to loop through the map
for (let [key, value] of map) {
    console.log(`${key}: ${value}`);
}