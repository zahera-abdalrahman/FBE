var nums= [1,2,3,8,9];
function aveArrayForLoop(array) {
    let sum=0;
    for(let i=0;i<array.length;i++){
        sum+=array[i];
    }
    let avg=sum/array.length;
    return avg;
}

console.log(aveArrayForLoop(nums));

function aveArrayWhileLoop(array) {
    let sum=0;
    let i=0;
    while(i<array.length){
        sum+=array[i];
        i++;
    }
    let avg=sum/array.length;
    return avg;
}

console.log(aveArrayWhileLoop(nums));