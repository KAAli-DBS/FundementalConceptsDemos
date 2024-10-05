// 1. Creating a Map
let myMap = new Map();

// 2. Adding key-value pairs
myMap.set('name', 'Alice');
myMap.set(1, 'one');
myMap.set(true, 'true value');
myMap.set({ key: 'objectKey' }, 'object value');

/*
// 3. Retrieving a value using a key
console.log(myMap.get('name')); 
console.log(myMap.get(1)); 
console.log(myMap.get(true));
console.log(myMap.get({ key: 'objectKey' })); 


// 4. Iterating over Map using for...of
console.log('Iterating over map:');
for (let [key, value] of myMap) {
    console.log(`Key: ${key}, Value: ${value}`);
}


// 5. Iterating over keys and values separately
console.log('Keys in the map:');
for (let key of myMap.keys()) {
    console.log(key);
}


console.log('Values in the map:');
for (let value of myMap.values()) {
    console.log(value);
}
*/

// 6. Iterating over entries
console.log('Entries in the map:');
for (let entry of myMap.entries()) {
    console.log(entry); 
}
