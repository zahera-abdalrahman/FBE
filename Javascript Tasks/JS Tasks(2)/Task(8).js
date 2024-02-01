let firstName=prompt("firstName: ");
let lastName=prompt("lastName: ");
let string="";
function fullName(firstName,lastName) {
    string=`${firstName} ${lastName}`
    console.log(string);
    document.getElementById("name").innerHTML=string;
}
fullName(firstName,lastName);

let fullNameArrow=(firstName,lastName) => {
    string=`${firstName} ${lastName}`
    console.log(string);
    document.getElementById("nameTwo").innerHTML=string;
}

fullNameArrow(firstName,lastName);