var nums= [44, 5, 4, 3, 2, 10];
function powerElementIndexForLoop(array) {
    let newArray=[];
    for (let i = 0; i < array.length; i++) {
        let value=Math.pow(array[i],i);
        newArray.push(value);
    }
    return newArray;
}

console.log(powerElementIndexForLoop(nums));


function powerElementIndexWhileLoop(array) {
    let newArray=[];
    let i=0;
    while (i < array.length) {
        let value=Math.pow(array[i],i);
        newArray.push(value);
        i++;
    }
    return newArray;
}
console.log(powerElementIndexWhileLoop(nums));
