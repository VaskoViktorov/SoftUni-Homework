function wordOccurrences(text,word) {
    let count = 0;
    let regex = new RegExp("\\b"+word+"\\b", "gi");
    let match = regex.exec(text);

    while(match) {
        count++;
        match = regex.exec(text);
    }

    console.log(count)
}

wordOccurrences("The waterfall was so high, that the child couldn’t see its peak.","the");