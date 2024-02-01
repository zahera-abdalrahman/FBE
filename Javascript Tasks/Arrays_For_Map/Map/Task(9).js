let names=[{name: 'Elie'}, {name: 'Tim'}, {name: 'Matt'}, {name: 'Colt'}];


function extractKey(arr,key){
    let newNames=arr.map(item => {
        return item[key];
    });
    return newNames;
}

console.log(extractKey(names,"name"));