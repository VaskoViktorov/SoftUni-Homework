function firstLastKElements(arr) {

    let result = arr
        .filter((num, i) => i % 2 === 1)
        .map(x => 2*x)
        .reverse();

    return console.log(result.join(' '));

}

firstLastKElements([10,15,20,25]);