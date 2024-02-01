const objArray=[{name: 'Elie'}, {name: 'Tim'}, {name: 'Matt'}, {name: 'Colt'}];
function addKeyAndValue(arr, key, value) {
  arr.forEach(obj => {
    obj[key] = value;
  });

  return arr;
}
addKeyAndValue(objArray, 'title', 'instructor');