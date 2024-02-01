let fullName=[{first: 'Elie', last:"Schoppik"}, {first: 'Tim', last:"Garcia"}, {first: 'Matt', last:"Lane"}, {first: 'Colt', last:"Steele"}];


function extractFullName(arr){
    let newFullName=arr.map(item => {
        return `${item.first} ${item.last}`;
    });
    return newFullName;
}

console.log(extractFullName(fullName));