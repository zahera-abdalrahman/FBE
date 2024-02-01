let numberofChildren,partnerName,jobTitle,yourLocation;
partnerName=prompt("Your partner name: ");
numberofChildren=prompt("number of children: ");
jobTitle=prompt("job title: ");
yourLocation=prompt("your location: ")
function tellFortune(numberofChildren,partnerName,yourLocation,jobTitle) {
    let string="";
    string=`You will be a ${jobTitle} in ${yourLocation}, and married to ${partnerName} with ${numberofChildren} kids.`;
    console.log(string);
    document.getElementById("fullName").innerHTML=string;
}

tellFortune(numberofChildren,partnerName,yourLocation,jobTitle);



let tellFortuneArrow=(numberofChildren,partnerName,yourLocation,jobTitle) => {
    let string="";
    string=`You will be a ${jobTitle} in ${yourLocation}, and married to ${partnerName} with ${numberofChildren} kids.`;
    console.log(string);
    document.getElementById("fullNameTwo").innerHTML=string;
}

tellFortuneArrow(numberofChildren,partnerName,yourLocation,jobTitle);