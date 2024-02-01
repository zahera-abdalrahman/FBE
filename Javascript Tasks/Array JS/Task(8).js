let arr1=[1,4,5];
let arr2=["t","d","v","x"];
function middleOfArray(arr) {
    const middle= arr.length / 2;
    if(arr.length%2===0)
    {
        return [arr[middle - 1], arr[middle]];
    }
    else
    {
        let center=Math.floor(middle);
        return arr[center];
    }
        
}

console.log(middleOfArray(arr1));
middleOfArray(middleOfArray(arr2));