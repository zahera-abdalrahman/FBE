var nums= [1,2,3,8,9]
function minInArray(array) {
    let min=array[0];
    for(let i =0;i<array.length;i++){
        if(array[i]<min)
            min=array[i];
    }
    return min;
}

console.log(minInArray(nums))