let base=prompt("Enter triangle base: ");
let height=prompt("Enter triangle height: ");
function triangle(base,height) {
    let area= 0.5 * base * height;
    return area;
}

alert(triangle(base,height));


let triangleArrow=(base,height) => {
    let area= 0.5 * base * height;
    return area;
}
alert(triangleArrow(base,height));
