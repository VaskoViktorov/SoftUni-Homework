function concatAndReverse(input) {

   console.log(input
       .join("")
       .split('')
       .reverse()
       .join(''));
}

concatAndReverse(["hello", "hi", "bye"]);