const namesArr=[
    {
        name: "Angelina Jolie",
        age: 80
    },
    {
        name: "Eric Jones",
        age: 2
    },
    {
        name: "Paris Hilton",
        age: 5
    },
    {
        name: "Kayne West",
        age: 16
    },
    {
        name: "Bob Ziroll",
        age: 100
    }
    ]; 

function namesOnly(arr){
    const newArray=arr.map(item => {
        return item.name;
    });
    return newArray;
}

console.log(namesOnly(namesArr));