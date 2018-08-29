function scoreToHTMLTable(scoreJSON) {

    let html = "<table>\n  <tr><th>name</th><th>score</th></tr>\n";

    /* Needed only for the softUni judge system*/
   // scoreJSON = JSON.parse(scoreJSON);

    for (let obj of scoreJSON) {
        html += `   <tr><td>${htmlEscape(obj['name'])}` +
            `</td><td>${obj['score']}</td></tr>\n`;
    }

    return console.log(html + "</table>");

    function htmlEscape(line) {
        let forbidden = ["&", "<", ">", '"',"'"];
        let allowed = ["&amp;", "&lt;", "&gt;", "&quot;","&#39;"];
        
        for(let i in forbidden) {
            line = line.split(forbidden[i]).join(allowed[i]);
        }

        return line;
    }
}

scoreToHTMLTable([{"name":"Pesho & Kiro","score":479},{"name":"Gosho, Maria & Viki","score":205}]);