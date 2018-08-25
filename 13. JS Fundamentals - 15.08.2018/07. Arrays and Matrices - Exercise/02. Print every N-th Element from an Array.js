function printNthElement(arr) {
    let step = Number(arr.pop());

    arr.filter((element, index) => index % step == 0).forEach(element => console.log(element));
}

printNthElement(['asd', 20,'sda', 4,'ass', 2]);