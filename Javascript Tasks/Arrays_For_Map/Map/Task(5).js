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
function makeStrings(arr){
    const newArray=arr.map(item => {
        if(item.age > 18)
    {
        return `${item.name} can go to The Matrix`
    }
    else
    {
        return `${item.name} is under age!!`
    }
    });
    return newArray;
}

console.log(makeStrings(namesArr));
