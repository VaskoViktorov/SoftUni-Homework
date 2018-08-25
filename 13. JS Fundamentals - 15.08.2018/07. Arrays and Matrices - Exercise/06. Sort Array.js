function sortArray(arr) {

    arr = arr.sort().sort((a,b)=> a.length-b.length);

    return console.log(arr.join("\n"));
}