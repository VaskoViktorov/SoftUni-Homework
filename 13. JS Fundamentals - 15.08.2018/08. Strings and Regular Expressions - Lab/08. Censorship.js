function censorship(text,words) {

    for(let word of words){
        while (text.includes(word)) {
            text = text.replace(word,'-'.repeat(word.length))
        }
    }
    console.log(text);
}

function censorshipTwo(text, words) {

    for(let word of words) {
        text = text.split(word).join("-".repeat(word.length));
    }

    return text;
}

censorship('roses are red, violets are blue', [', violets are', 'red']);