console.log('Welcome to learn language');

let element = document.getElementById('myfirst');

document.body.style.color = 'red';
element.innerText = 'Languages';
element.innerHTML = '<b>Languages</b>';



let sel = document.querySelector('#myfirst');
sel = document.querySelector('.Languages');
sel = document.querySelector('div');
sel.style.color = 'green';
console.log(sel)


let elems = document.getElementsByClassName('Languages');
elems = document.getElementsByClassName('container');
elems = document.getElementsByTagName('div');
console.log(elems)

for (let index = 0; index < elems.length; index++) {
    const element = elems[index];
    console.log(element);
   element.style.color = 'blue'; 
}
