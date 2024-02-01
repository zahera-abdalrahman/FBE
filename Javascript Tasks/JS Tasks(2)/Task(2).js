let n = 4;
let string = "";
let counter=1;
for (let i = 1; i <= n; i++) {
  for (let j = 0; j < i; j++) {
    string +=counter;
      counter++;
  }
  string += "<br>";
}
console.log(string);

document.getElementById("shape").innerHTML=string;