var string="";
for(let i=1;i<=1000;i++)
    {
        if(i%13===0)
        {
            string+=i+" ";
        }
    }
    console.log(string);

    document.getElementById("numbers").innerHTML=string;