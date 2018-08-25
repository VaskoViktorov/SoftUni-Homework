function matchAllWords(input) {
    console.log( input.split(/\W+/).filter(x => x!= '').join("|"));

}

matchAllWords('A Regular Expression needs to have the global flag in order to match all' +
    'occurrences in the text');