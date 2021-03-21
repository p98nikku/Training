//USER TEST CASES
function add(num1,num2, ...ep)
{
    let res=num1+num2;
    let sum=0;
    if(arguments.length===2)
    {
        if(Number.isNaN(sum)|| Number.isNaN(res) || typeof res==='undefined' || typeof sum==='undefined')
        {
            console.log('error');
        }
        else
        return res;
    }
    else if(arguments.length<2)
    {
        return 0;
    }
    else if(arguments.length>2)
    {
        let sum=0;
        let arr=[];
        let k=0;
        for(let i=2;i<arguments.length;i++)
        {
            arr[k++]=arguments[i];
        }
        arr.forEach(function(item){sum=sum+item});
        if(Number.isNaN(sum)|| Number.isNaN(res) || typeof res==='undefined' || typeof sum==='undefined')
        {
            console.log('error');
        }
        else
        {
            if((sum-res)>0)
            {
                return sum-res;
            }
            else{
                return -1*(sum-res);
            }
        }
    }
}
let a=add(1,NaN);
console.log(a);