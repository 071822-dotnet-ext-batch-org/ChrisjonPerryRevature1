"use strict";
console.log("Hello world")
let chris = 4560707995
// alert("Your browser is hacked")
// confirm("do you want to continue?")

// three ways to initialize variables
//var
var var1;
console.log(`${var1}`);
// using { } here is simular to to C# using()statement 
{
let var2=1; // only in the scope
var var3=2;// global
}

//let 
let myString = 'This a string';
console.log(myString);
myString = 1044;
console.log(myString);

//const
const MYCONST = 'This a const';
console.log(MYCONST);


if (" ") {
console.log("\nAn empty string");    
}
else {
    console.log("as expected")
}

// Json in javascript
//Creation of a json object
let jason = {
    name: "Chris",
    age: 23,
    height: "5'3",
};
let jasonString=JSON.stringify(jason);
console.log(jasonString);
let jasonstr = JSON.parse(jasonString);
console.log(jasonstr);

console.log(jasonstr.name,jasonstr.age,jasonstr.height);

jason.weight= 202;
console.log(jason);

function func1(){
    alert('theres a function here')
}

func1();

function func2(par1, par2){
    alert(`theres a ${par1} function ${par2}ing here`)
}


func2("dang", "2");

function func3(par1, par2){
    return(`theres a ${par1} function ${par2}ing here`)
}


console.log(func2('short','swimm'))

// function express
let func4 = function (param1) {
  return ++param1;  
}
console.log(func4(5));

//lamda expression 
let func7 = () => "This is a 0 Parameter function"
let func5 = parma1 => ++parma1;// arrow function with one parameter
let func6 = (p1,p2) => p1 + p2; //arrow fucntion with two param
let ret5 = func5(5);
console.log(ret5);

let func8 = p1 =>{
    let myVar = `${p1} is`;
    let myVar1 = 'Santa';
    return myVar+myVar1;
}
console.log(func8('chris brown'));

let func9 = (p1,p2) =>{
    let res = p1(p2);
    let myVar =`${res} is `
    let var1 = 'santa'
    return myVar + var1;
}
//Imediatly invoked expressions 
//They don't have parameters 
(()=>console.log("Hello kingy"))();

let myp1 = (p1)=> {
    let swords = p1;
    swords +=swords;
    return swords;
}
// callback function (myp1) 
let res1 = func9(myp1, 'magn');
console.log(res1);

//closure!!!!!
function Mynested(p1){
 return () => p1++;   
}
let mynestedresult = Mynested(12);
console.log(`my nested function returned ${mynestedresult()}`);

// object constuctor  syntax
let user = new Object();
// literal syntax
let user1 = {};

class Rectangle{
    constructor(height,width){
        this.height=height;
        this.width=width;
    }
}
let Rectangle1 = class{
    constructor(height,width){
        this.height = height;
        this.width=width
    }
}

let m1 ={
    
    name1 : chris,
    age: 23,
    
}
m1.myDescrip = function(){  
    return `my name is${this.name1} and ${this.name1} is ${this.age}`}

console.log(m1.myDescrip());
class m2{
    constructor(name,age){
    this.name1= name;
    this.age= 18;
    };
}
let m3 =  new m2('Jim',18);
console.log(m3.age,m3.name1);
let m5 =  new m2('chrisy', 50);

class m6{
    constructor(namee,age){
    this.name1= namee;
    this.age= age;
    }
    get nameandage(){
    return `${this.name1} is ${this.age} years old`
    }
    set setage(v){
        if (v> 100 || v<1) throw new RangeError(`that age, ${v} is invalid`) 
        else this.age = v;    
        
    }
    static staticname ='chris';
    static giveStatic(){
        return `Do you wanna get jammed up ${this.staticname} ?`
    }
};
let m7 = new m6('shari',30);
console.log(m7.nameandage);
console.log(m6.giveStatic());

class m6inh extends m6{
    constructor(myName,page, address= '123 nowhere st.'){
        super(myName, page);
        this.address;
    };
};

let n1 = new m6inh('maurice',56);
console.log(`My dad is ${n1.name1} and ${n1.name1} is ${n1.age} years old and lives at ${n1.address}`)


const paragraphs = document.getElementsByTagName('p'); // grab all ellemts
const dody = document.body;
const myDiv = document.createElement('div');
dody.appendChild(myDiv);
//  for (const x of paragraphs) {
//     myDiv.innerHTML += x.innerText;
//  }

 const list = document.querySelector('.oli');
 console.log(list.lastElementChild.textContent);
 list.lastElementChild.classList.add("ul")
 let button = document.querySelector('button');
 button.addEventListener('click',(e)=>
 {
// dynamically apply and remove the classlist
let elem = list.lastElementChild;
if(elem.classList.contains("redBackground")){
    elem.classList.remove('redBackround')
}
});