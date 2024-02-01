const array=[2, 5, 100];

function stringItUp(arr){
    const newArray=arr.map(item => {
        return item.toString();
    }); 
    return newArray;
}

console.log(stringItUp(array));