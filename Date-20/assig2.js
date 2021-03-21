function animal(owner){
    this.owner=owner
}
function dog(name,color){
  this.name = name;
  this.color=color;}
var a = new animal("foo");
var b = new dog("sheru","safed");
b.__proto__.owner=a.owner;
console.log(b.owner);