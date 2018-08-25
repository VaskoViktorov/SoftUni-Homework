function extractIncreasingSubseq(arr) {

    let currMaxNum= Number.NEGATIVE_INFINITY;

    for (let i = 0; i < arr.length; i++) {
        if(currMaxNum<=arr[i]){
            console.log(arr[i]);
            currMaxNum=arr[i];
        }
    }
}