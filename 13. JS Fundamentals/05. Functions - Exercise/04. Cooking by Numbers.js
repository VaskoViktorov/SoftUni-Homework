function  cookingByNumbers(arr) {
    function chop(x) {return x/2;}
    function dice(x) {return Math.sqrt(x);}
    function spice(x) {return x+1;}
    function bake(x) {return x*3;}
    function fillet(x) {return x-x*0.2;}

    function cook(cookType,x) {
        switch (cookType) {
            case "chop": return chop(x);
            case "dice": return dice(x);
            case "spice": return spice(x);
            case "bake": return bake(x);
            case "fillet": return fillet(x);
        }
    }

    let x = arr[0];

    for (let i = 1; i <arr.length; i++) {
       x = cook(arr[i],x);
       console.log(x);
    }
}
