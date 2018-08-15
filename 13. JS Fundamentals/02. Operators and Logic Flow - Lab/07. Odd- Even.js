function oddEven(a) {
    if (!Number.isInteger(a)){

        console.log("invalid");
    }
    else if(a%2===0){
        console.log("even");
    }
    else {
        console.log("odd");
    }
}