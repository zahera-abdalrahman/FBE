const array=[2, 5, 100];

function doubleNumbers(arr){
  const newArray=arr.map(item =>{
    return item*2;
  });
  return newArray;
}

console.log(doubleNumbers(array));