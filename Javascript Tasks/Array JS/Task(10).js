var nums= [1,2,3,8,9];
function indexOfArray(array,index) {
    if(array.length - 1 < index)
        return "Index out of bound"
    else
        return array[index];
}

console.log(indexOfArray(nums,3));
console.log(indexOfArray(nums,1));
console.log(indexOfArray(nums,4));
