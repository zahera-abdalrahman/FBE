var nums= [1,2,3,8,9];
function sumArrayForLoop(array) {
    let sum=0;
    for(let i=0;i<array.length;i++){
        sum+=array[i];
    }
    return sum;
}

console.log(sumArrayForLoop(nums));


function sumArrayWhileLoop(array) {
    let sum=0;
    let i=0;
    while(i<array.length){
        sum+=array[i];
        i++;
    }
    return sum;
}

console.log(sumArrayWhileLoop(nums));
