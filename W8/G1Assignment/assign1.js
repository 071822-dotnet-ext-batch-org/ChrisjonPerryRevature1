const lib = require('./lib2.js');
const fs = require('fs-extra');

fs.writeFileSync('./newfile.txt','This is a new file');
fs.appendFile('./newfile.txt',`${lib.myVar}`);
//console.log(fs.readFileSync('./newfile.txt'));
let str1 = 'append again with this fuunc';
fs.appendFile('./newfile.txt',`${lib.writeFile}`)
fs.readFile('./newfile.txt',(error,data)=>
{
    if(error){
        throw error;
    }
    console.log(data.toString());
});
