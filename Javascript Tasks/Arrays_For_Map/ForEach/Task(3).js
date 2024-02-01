const strings=['colt','matt', 'tim', 'udemy'];
const newArray=[];

function showFirstAndLast(array) {
    array.forEach(item => {
        let firstChar=item.substring(0, 1);
    let lastChar=item.slice(-1)
    newArray.push(firstChar+lastChar);
    });
    return newArray;
}
console.log(showFirstAndLast(strings));