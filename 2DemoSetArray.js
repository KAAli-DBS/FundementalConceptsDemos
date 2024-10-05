//Searching and deleting an element in the set is faster compared to arrays.  


// Array search - O(n)
//let array = [10, 20, 30, 40, 50];
//console.log(array.includes(30));  // Output: true (has to iterate to find 30)//

// Set search - O(1)
//let set = new Set([10, 20, 30, 40, 50]);
//console.log(set.has(30));  // Output: true (direct lookup, faster)


let array = [];
let set = new Set();

// Fill array and set with 1 million elements
for (let i = 0; i < 1000000; i++) {
    array.push(i);
    set.add(i);
}

let searchElement = 999999;  

// Measure search time for Array
console.time("Array Search Time");
array.includes(searchElement);
console.timeEnd("Array Search Time");

// Measure search time for Set
console.time("Set Search Time");
set.has(searchElement);
console.timeEnd("Set Search Time");


// Measure delete time for Array
console.time("Array Delete Time");
let index = array.indexOf(searchElement);
if (index > -1) {
    array.splice(index, 1);
}
console.timeEnd("Array Delete Time");

// Measure delete time for Set
console.time("Set Delete Time");
set.delete(searchElement);
console.timeEnd("Set Delete Time");
