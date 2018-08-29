function countWords(text) {

    let words = {};

    let arr = text.toString().split(/\W+/).filter(x => x !== '');

    for (let i = 0; i < arr.length; i++) {

        words[arr[i]] ? words[arr[i]]++ : words[arr[i]] = 1;
    }

    return console.log(JSON.stringify(words));
}

countWords("Far too slow, you're far too slow.");

