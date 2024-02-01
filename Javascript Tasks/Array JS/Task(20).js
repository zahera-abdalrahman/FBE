var strings= ["alex","mercer","madrasa","rashed2","emad","hala"];
function evenIndexOddLengthForLoop(array) {
    let value=[];
    for (let i = 0; i < array.length; i++) {
        if((array.indexOf(array[i])%2===0) && (array[i].length%2!=0))
        {
            value.push(array[i]);
        }
    }
    return value;
}

console.log(evenIndexOddLengthForLoop(strings));

function evenIndexOddLengthWhileLoop(array) {
    let value=[];
    let i=0;
    while (i < array.length) {
        if((array.indexOf(array[i])%2===0) && (array[i].length%2!=0))
        {
            value.push(array[i]);
        }
        i++;
    }
    return value;
}

console.log(evenIndexOddLengthWhileLoop(strings));