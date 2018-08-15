function wordsUppercase(str) {

    let words = str
            .split(/\W+/)
            .filter(w => w != '')
            .join(', ')
            .toUpperCase();

    return console.log(words);
}