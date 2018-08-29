function JsonToHtmlTable(scoreJSON) {

    /* Needed only for the softUni judge system*/
    //scoreJSON = JSON.parse(scoreJSON);

    let html = "<table>\n   <tr>";

    for (let key of Object.keys(scoreJSON[0]))
        html += `<th>${key}</th>`

    html += "</tr>\n";

    for (let obj of scoreJSON) {
        html += '   <tr>';
        for (let value of Object.keys(obj)) {
            html += '<td>' + htmlEscape(obj[value])+'</td>'
        }
        html+='</tr>\n';
    }
    return console.log(html + "</table>");

    function htmlEscape(line) {
        let forbidden = ["&", "<", ">", '"',"'"];
        let allowed = ["&amp;", "&lt;", "&gt;", "&quot;","&#39;"];

        for(let i in forbidden) {
            line = line.toString().split(forbidden[i]).join(allowed[i]);
        }

        return line;
    }
}

JsonToHtmlTable([{"name":"Pesho & Kiro","score":479},{"name":"Gosho, Maria & Viki","score":205}]);