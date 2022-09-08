"use strict";

const xhr = new XMLHttpRequest();
console.log(`the ready state is ${xhr.readyState} `)

xhr.onreadystatechange = ()=>{
    console.log(`this readystate is ${xhr.readyState} - \nthe status is ${xhr.status}`)
    if(xhr.readyState == 4 && xhr.status==200){
        console.log(`The response type is ${xhr.responseType}`);
        console.log(`The response text is ${xhr.responseText}`);
        displayResponseTextinBrowser();
    }  
    else{
        console.log("Jokes aren't ready yet.")
    }
    }
xhr.open('get','http://api.icndb.com/jokes/random?firstName=John&lastName=Doe',true);
xhr.send();

function displayResponseTextinBrowser(){
    // get the body object
    let bodie = document.body;
    // create the div
    let myDiv =document.createElement('div');
    //create the element p
    let myP = document.createElement('p');
    //add div and p to the html
    myDiv.appendChild(myP);
    bodie.appendChild(myDiv);
    // convert the JSON string a JS object
    let resText = JSON.parse(xhr.responseText);
    console.log(resText);
    // add the text into the p element
    myP.textContent = resText.value.joke;
}

// now get 5 Jokes
const xhr2 = new XMLHttpRequest();
console.log(`The readystate is ${xhr2.readystate}`);
xhr2.onreadystatechange = () => {
  if (xhr2.readyState == 4 && xhr2.status == 200) {
    displyJokesInBrowser();
  }
  else {
    console.log(`Jokes are not ready yet!`);
  }
};
let five = 5;

xhr2.open('GET', `http://api.icndb.com/jokes/random/${five}`, true);
xhr2.send();
displyJokesInBrowser();
function displyJokesInBrowser() {

    console.log(xhr2.responseText);
    let bodie = document.body;
    // i want 5 separate jokes named joke1, joke2, joke3, joke4, joke5
    let joke1 = document.createElement("p");
    let joke2 = document.createElement("p");
    let joke3 = document.createElement("p");
    let joke4 = document.createElement("p");
    let joke5 = document.createElement("p");
    // populate the div with p elements
    // next, add the div and p to the html body
    bodie.appendChild(joke1);
    bodie.appendChild(joke2);
    bodie.appendChild(joke3);
    bodie.appendChild(joke4);
    bodie.appendChild(joke5);
    // convert the JSON string into a JavaScript object
    let jokeObj = JSON.parse(xhr2.responseText);
    // get the joke text from the object
    let jokeText1 = jokeObj.value[0].joke;
    let jokeText2 = jokeObj.value[1].joke;
    let jokeText3 = jokeObj.value[2].joke;
    let jokeText4 = jokeObj.value[3].joke;
    let jokeText5 = jokeObj.value[4].joke;
    // put the joke text into the p element
    joke1.innerHTML = jokeText1;
    joke2.innerHTML = jokeText2;
    joke3.innerHTML = jokeText3;
    joke4.innerHTML = jokeText4;
    joke5.innerHTML = jokeText5;
} 

// Fetch
fetch('http://api.icndb.com/jokes/random/5')
.then((res) =>{
    console.log(res.ok, res.headers ,res.value)
    return res.JSON()
},
(rej) => { throw new Error('There was an error')})
.then(body=>{
    for (let x of body.value){
    console.log(x.joke);
    }
})
.catch(err => {throw new Error("error")})