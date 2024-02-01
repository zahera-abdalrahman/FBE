var string= "alex mercer madrasa rashed2 emad hala";
string.char
function repeatCharForLoop(string,char) {
    let counter=0;
    for (let i = 0; i < string.length; i++) {
        if(string.charAt(i)===char)
        {
            counter++;
        }
    }
    return counter;
}

console.log(repeatCharForLoop(string,"a"));
console.log(repeatCharForLoop(string,"z"));

function repeatCharWhileLoop(string,char) {
    let counter=0;
    let i=0;
    while (i < string.length) {
        if(string.charAt(i)===char)
        {
            counter++;
        }
        i++;
    }
    return counter;
}

console.log(repeatCharWhileLoop(string,"a"));
console.log(repeatCharWhileLoop(string,"z"));