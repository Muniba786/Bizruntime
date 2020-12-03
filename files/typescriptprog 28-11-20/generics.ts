function getArray2<T>(items : T[] ) : T[] {
    return new Array<T>().concat(items);
}

let myNumArr2 = getArray2<number>([100, 200, 300]);
let myStrArr2 = getArray2<string>(["Hello", "World"]);

myNumArr2.push(400); // OK
myStrArr2.push("Hello TypeScript"); // OK
console.log(myNumArr2);
console.log(myStrArr2);

