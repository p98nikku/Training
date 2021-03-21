var car={
    Color:"red",
    owner:"foo",
    price:1000
}
var displayProduct=(title,price)=>{
    this.title=title;
    this.price=price;
    console.log(this);
    return 9;
}
var a=displayProduct('Pen',900);
console.log(a);
console.log(this);
this.owner="dj";
console.log(this);

displayProduct.call(car,'Pencil' ,900);
console.log(this);
console.log(car);