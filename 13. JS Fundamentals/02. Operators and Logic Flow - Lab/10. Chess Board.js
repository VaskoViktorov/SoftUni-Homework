function chessBoard(num) {

    let color;
    let html = '<div class="chessboard">\n';

    for (let i = 0; i <num ; i++) {
        
        html += '  <div>\n';
        color = (i % 2 === 0) ? 'black' : 'white';

        for (let j = 0; j <num ; j++) {

            html+=`    <span class="${color}"></span>\n`;
            color = (color === 'white') ? 'black' : 'white';
        }

        html += '  </div>\n';
    }

    html += '</div>';

    return html;
}