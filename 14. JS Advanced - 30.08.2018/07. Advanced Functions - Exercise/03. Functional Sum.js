let add = (function () {
    let sum = 0;
    return function summary(number) {
         sum += number;

         summary.toString = function () {
             return sum;
         };
         return summary;
    }
})();


console.log(add(1)(6)(-3).toString());