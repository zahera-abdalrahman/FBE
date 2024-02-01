var strings= ["alex","mercer","madrasa","rashed2","emad","hala"];
function shorterInArrayForLoop(array) {
    let short=array[0].length;
    let value=array[0];
    for (let i = 0; i < array.length; i++) {
        if(array[i].length<short)
        {
            value=array[i];
        }
    }
    return value;
}

console.log(shorterInArrayForLoop(strings));

function shorterInArrayWhileLoop(array) {
    let short=array[0].length;
    let value=array[0];
    let i=0;
    while (i < array.length) {
        if(array[i].length<short)
        {
            value=array[i];
        }
        i++;
    }
    return value;
}
console.log(shorterInArrayWhileLoop(strings));