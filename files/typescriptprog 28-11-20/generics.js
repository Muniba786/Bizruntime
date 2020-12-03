function getArray2(items) {
    return new Array().concat(items);
}
var myNumArr2 = getArray2([100, 200, 300]);
var myStrArr2 = getArray2(["Hello", "World"]);
myNumArr2.push(400); // OK
myStrArr2.push("Hello TypeScript"); // OK
console.log(myNumArr2);
console.log(myStrArr2);
