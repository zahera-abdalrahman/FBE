let dog=prompt("your dog age: ")
let string="";
function calculateDogAge(dog) {
  let dogAge = dog * 7;
  string=`Your doggie is ${dogAge} years old in human years!`;
    console.log(string);
    document.getElementById('age').innerHTML= string;
}

calculateDogAge(dog);


calculateDogAgeArrow=(dog) => {
  let dogAge = dog * 7;
  string=`Your doggie is ${dogAge} years old in human years!`;
    console.log(string);
    document.getElementById('ageTwo').innerHTML= string;
}

calculateDogAgeArrow(dog);

