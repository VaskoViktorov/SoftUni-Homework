function matchDates(inputSentences) {

    let pattern =/\b([0-9]{1,2})-([A-Z][a-z]{2})-([0-9]{4})\b/g;

    let dates = [], match;

    for (let sentence of inputSentences) {
        while (match = pattern.exec(sentence)) {
            dates.push(`${match[0]} (Day: ${match[1]}, Month: ${match[2]}, Year: ${match[3]})`);
        }
    }
    console.log(dates.join("\n"));
}

matchDates('I am born on 30-Dec-1994.\n' +
    'This is not date: 512-Jan-1996.\n' +
    'My father is born on the 29-Jul-1955.');