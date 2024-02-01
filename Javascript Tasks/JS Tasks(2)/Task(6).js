let seriesOfNumber=prompt("Enter a number: ");
let arrayNumber=Array.from(String(seriesOfNumber),Number);

for (let i = 0; i <= 9; i++) {
    if (!arrayNumber.includes(i))
    {
      console.log(`number ${i} is missing`);
    }
  
  }

