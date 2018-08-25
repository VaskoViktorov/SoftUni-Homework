function smallestTwoNumbers(arr) {

    arr.sort((a, b) => a-b);

    let result = arr.slice(0, 2);

    return console.log(result.join(' '));

}
smallestTwoNumbers([1,2,3,4])