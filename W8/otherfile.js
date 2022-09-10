
console.log('Hey hey world ');

//each file constitutes a 'module' a module
//must be exported from the file where they are declared an
let myConst = 'chris'

exports.myConst=myConst;
exports.Mostlikley=Mostlikley;

function Mostlikley(str,num){
    return `${str} is ${num} more likely to drop out of school`;
}