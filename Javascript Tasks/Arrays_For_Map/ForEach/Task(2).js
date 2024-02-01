const num1=[1,2,3];
const num2=[5,1,2,3,10];

const newArray=[];


function onlyEvenValues(array) {
    num2.forEach(item => {
        if(item%2 === 0){
            newArray.push(item);
        }
    });
    return newArray;
}


console.log(onlyEvenValues(num1));