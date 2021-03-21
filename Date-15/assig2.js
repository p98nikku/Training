//COUNTER FUNCTION
function add()
{
    let count=1;
    function addition()
    {
        count=count+1;
        return count;
    }
    return addition;
}
let a=add();
console.log(a());
console.log(a());
console.log(a());
console.log(a());
