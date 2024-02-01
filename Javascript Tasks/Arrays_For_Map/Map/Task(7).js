let num1=[1,2,3];
let num2=[1,-2,-3];


function doubleValues(arr){
  let newNumbers=arr.map(item => {
    return item*2;
  });
    return newNumbers;
  }

console.log(doubleValues(num1));