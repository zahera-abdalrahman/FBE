var array2=[1,3,4,6,8,9,10] 
// var array2 = [5,9,-7,3.5]
array2.pop();
for(let i=0;i<5;i++)
    {
        array2.shift();   
    }
array2.push(-7,3.5);
array2.unshift(5);
console.log(array2);