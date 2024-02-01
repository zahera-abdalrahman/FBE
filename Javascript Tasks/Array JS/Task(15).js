var nums= [1,2,3,8,9]
function removeFromArrayForLoop(array,value) {
    for (let i = 0; i < array.length; i++) {
        if (array[i] === value) {
            array.splice(i,1);
        }
    }
    return array;
}

console.log(removeFromArrayForLoop(nums,8));

function removeFromArrayWhileLoop(array,value) {
    let i=0;
    while (i < array.length) {
        if (array[i] === value) {
            array.splice(i,1);
        }
        i++;
    }
    return array;
}
console.log(removeFromArrayWhileLoop(nums,8));