function  aggregateElements(elements) {

    aggregate(elements, 0, (a, b) => a + b);
    aggregate(elements, 0, (a, b) => a + 1 / b);
    aggregate(elements, '', (a, b) => a + b);

    function aggregate(arr, initVal, func) {

        for (let i = 0; i < arr.length; i++) {

            initVal = func(initVal, arr[i]);
        }

        console.log(initVal);
    }
}

aggregateElements([1,2,3]);