let num1=[1,2,3];
let num2=[1,-2,-3];

function valTimesIndex(arr){
    let newNumbers=arr.map((item,index) => {
        return item*index;
    });
    return newNumbers;
}

console.log(valTimesIndex(num1));