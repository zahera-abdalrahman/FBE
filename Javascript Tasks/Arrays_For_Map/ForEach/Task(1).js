const num1=[1,2,3];
const num2=[5,1,2,3,10];


function doubleValues (array){
    array.forEach(item => {
        console.log(item*2);
    });
    
}

doubleValues(num1);
doubleValues(num2);
