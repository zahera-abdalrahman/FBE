var nums= [1,2,3,8,9]
function oddArrayForLoop(array) {
    let oddNewArray=[];
    for (let i = 0; i < array.length; i++) {
        if(array[i]%2!=0){
            oddNewArray.push(array[i]);
        }
    }
    return oddNewArray;
}

console.log(oddArrayForLoop(nums));

function oddArrayWhileLoop(array) {
    let oddNewArray=[];
    let i=0;
    while(i < array.length) {
        if(array[i]%2!=0){
            oddNewArray.push(array[i]);
        }
        i++;
    }
    return oddNewArray;
}
console.log(oddArrayWhileLoop(nums));
