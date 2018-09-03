function extractText() {

    let list = $('#items li')
        .toArray()
        .map(li =>  li.textContent)
        .join(", ");

    $("#result").text(list);
}