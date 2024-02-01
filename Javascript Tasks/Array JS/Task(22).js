var nums= [5,2,2,1,8,66,55,77,34,9,55,1];
function evenNumberEvenIndexForLoop(array) {
    let value=[];
    for (let i = 0; i < array.length; i++) {
        if((array.indexOf(array[i])%2===0) && (array[i]%2===0))
        {
            value.push(array[i]);
        }
    }
    return value;
}
console.log(evenNumberEvenIndexForLoop(nums));

function evenNumberEvenIndexWhileLoop(array) {
    let value=[];
    let i=0;
    while (i < array.length) {
        if((array.indexOf(array[i])%2===0) && (array[i]%2===0))
        {
            value.push(array[i]);
        }
        i++;
    }
    return value;
}
console.log(evenNumberEvenIndexWhileLoop(nums));