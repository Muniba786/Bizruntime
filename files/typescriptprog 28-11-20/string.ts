let str: string = 'TypeScript';
function letDeclare() { 

str.indexOf('T'); // returns 0
str.indexOf('p'); // returns 2
str.indexOf('e'); // returns 3
str.indexOf('T', 1); // returns -1
str.indexOf('t', 1); // returns 9
console.log(str);
}
letDeclare();
