// Task(1)

var num1=prompt("Enter Number One:");
var num2=prompt("Enter Number Two:");

var operation=prompt("Choose One Operation (-,/,*,+):");
var result;

switch(operation){
    case "-":
        result=num1-num2;break;
    case "+":
        result=num1+num2;break;
    case "*":
        result=num1*num2;break;
    case "/":
        result=num1/num2;break;
    default:"Enter The Numbers Again."
}

alert(num1+" "+operation+" "+num2+"="+result);
console.log(num1+" "+operation+" "+num2+"="+result);
document.getElementById("operation").innerHTML =num1+" "+operation+" "+num2+"="+result;
//Task(2)

var grade=prompt("Enter your grade:");
var gradeResult;
if(grade <= 100 && grade >=90)
    gradeResult="A+";
else if(grade <= 89 && grade >=80)
    gradeResult="A";
else if(grade <= 79 && grade >=70)
    gradeResult="B";
else if(grade <= 69 && grade >=60)
    gradeResult="C";
else if(grade <= 59 && grade >=50)
    gradeResult="C";
else
    gradeResult="F";

alert(gradeResult);
console.log(gradeResult);
document.getElementById("grades").innerHTML ="Your grade is:"+gradeResult;

//Task(3)
var radius=prompt("Enter the radius of the circle:");
const _pi=Math.PI;

var areaCircle=_pi*radius*radius;

alert("The area of the circle is: "+areaCircle.toFixed(2));
console.log("The area of the circle is: "+areaCircle.toFixed(2));
document.getElementById("circle").innerHTML ="The area of the circle is: "+areaCircle.toFixed(2);
//Task(4)

var numberOne=prompt("Enter Number One:");

var numberTwo=prompt("Enter Number Two:");

if(numberOne>numberTwo)
{
    console.log("Hello World");
}
else{
    console.log("GoodBye");
}

if(numberOne>numberTwo)
{
    alert("Hello World");
}
else{
    alert("Goodbye");
}

if(numberOne>numberTwo)
{
    document.getElementById("hello").innerHTML ="Hello World";
}
else{
    document.getElementById("hello").innerHTML ="Goodbye";
}