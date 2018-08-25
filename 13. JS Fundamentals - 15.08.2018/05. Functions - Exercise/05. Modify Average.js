function modifyAverage(startNum) {
    let arr = (""+startNum).split("").map(Number);

    while(sumNums(arr)/arr.length<=5){

        arr.push(9);

    }

    return console.log(arr.join(""));

    function sumNums(arr) {

        let sum =0;

        for (let i = 0; i <arr.length ; i++) {
            sum+=arr[i];
        }
        return sum;
    }
}

modifyAverage(5835)