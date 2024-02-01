let vowelsObject={};
function vowelCount(str){
    let newArray=str.split("");
    let vowels='eoiuyEOIUY'
    newArray.forEach(value => {
        if(vowels.includes(value))
        {
            if(vowelsObject[value])
            {
                vowelsObject[value]++;
            }
                else
                {
                    vowelsObject[value]=1;
                }
            
        }
    })
    return vowelsObject;
}


vowelCount('Elie');
vowelCount('Tim');
vowelCount('Matt');
vowelCount('hmmm');
vowelCount('I Am awesome and so are you');

console.log(vowelsObject);
