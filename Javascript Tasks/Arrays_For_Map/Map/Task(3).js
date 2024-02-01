const names=["john", "JACOB", "jinGleHeimer", "schmidt"];




function capitalizeNames(arr){
  const newNames=arr.map(item => {
    let firstChar=item.charAt(0).toUpperCase();
    let word=item.slice(1).toLowerCase();
    return firstChar+word;
  });
  return newNames;
}

console.log(capitalizeNames(names));